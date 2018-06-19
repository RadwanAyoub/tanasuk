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
        public List<NavigationModel> Navi()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            var list = dataSource.GetChildren().Where(o=> is_navigation(o));
            List<NavigationModel> NavItems = new List<NavigationModel>();
            List<NavigationModel> children = new List<NavigationModel>();
            foreach (Item riz in list)
            {
                if (riz.HasChildren)
                {
                    children = GetChill(riz);
                }
                var title = riz.Fields["Title"].Value;
                Sitecore.Data.Fields.LinkField linkfield = riz.Fields["Destination"];
                var url = linkfield.GetFriendlyUrl();
                NavItems.Add(new NavigationModel { Title = title, Url = url, Children = children });
            }

            return NavItems;
        }
        private List<NavigationModel> GetChill(Item item)
        {
            List<NavigationModel> Chill = new List<NavigationModel>();
            foreach (Item riz in item.Children)
            {
                var title = riz.Fields["Title"].Value;
                Sitecore.Data.Fields.LinkField linkfield = riz.Fields["Destination"];
                var url = linkfield.GetFriendlyUrl();
                Chill.Add(new NavigationModel { Title = title, Url = url });
            }
            return Chill;
        }

        private bool is_navigation(Item currentitem)
        {
            Sitecore.Data.Fields.LinkField link = currentitem.Fields["Destination"];
            var item = Sitecore.Context.Database.GetItem(link.TargetID);
            CheckboxField field = (CheckboxField)item.Fields["IncludeInNavigation"];
            return field.Checked;
        }
    }
}