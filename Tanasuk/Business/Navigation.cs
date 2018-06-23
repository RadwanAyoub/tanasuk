using System.Collections.Generic;
using System.Linq;
using Tanasuk.Models;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Sitecore.Data.Fields;

namespace Tanasuk.Business
{
    public class Navigation
    {
        public List<NavigationModel> GetHeaderNavigation()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            var list = dataSource.GetChildren();
            List<NavigationModel> NavItems = new List<NavigationModel>();
            foreach (Item item in list)
            {
                NavItems.Add(new NavigationModel { Name = item });
            }
            return NavItems;
        }
        public List<NavigationModel> GetSideNavigation()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            var list = dataSource.GetChildren()/*.Where(o=> Is_Included(o))*/;
            List<NavigationModel> NavItems = new List<NavigationModel>();
            List<NavigationModel> children = new List<NavigationModel>();
            foreach (Item item in list)
            {
                if (item.HasChildren)
                {
                    children = GetChilldren(item);
                }
                NavItems.Add(new NavigationModel { Name = item, Children = children });
            }
            return NavItems;
        }
        private List<NavigationModel> GetChilldren(Item item)
        {
            List<NavigationModel> Chill = new List<NavigationModel>();
            foreach (Item child in item.Children)
            {
                Chill.Add(new NavigationModel { Name = child });
            }
            return Chill;
        }
        private bool Is_Included(Item currentitem)
        {
            Sitecore.Data.Fields.LinkField link = currentitem.Fields["Destination"];
            var item = Sitecore.Context.Database.GetItem(link.TargetID);
            CheckboxField field = (CheckboxField)item.Fields["IncludeInNavigation"];
            return field.Checked;
        }
    }
}