using System.Collections.Generic;
using Sitecore.Data.Items;
using Sitecore.Links;
using Tanasuk.Models;

namespace Tanasuk.Business
{
    public class BreadCrumbBuilder
    {
        public List<NavigationModel> lo = new List<NavigationModel>();
        public bool active = false;
        public List<NavigationModel> Bread(Item _current)
        {
            if (_current.Parent != null && _current.Name.ToLower() != "home")
            {
                var url = LinkManager.GetItemUrl(Sitecore.Context.Database.GetItem(_current.ID));
                lo.Add(new NavigationModel { Title = _current.Name, Url = url, Active = active });
                Bread(_current.Parent);
            }
            else if (_current.Name.ToLower() == "home")
            {
                var url = LinkManager.GetItemUrl(Sitecore.Context.Database.GetItem(_current.ID));
                lo.Add(new NavigationModel { Title = _current.Name, Url = url });
                return lo;
            }
            return lo;
        }
    }
}