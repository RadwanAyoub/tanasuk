using System.Collections.Generic;
using Sitecore.Data.Items;
namespace Tanasuk.Models
{
    public class NavigationModel
    {
        public Item Name { get; set; }
        public List<NavigationModel> Children = new List<NavigationModel>();
        public bool Active { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
    }
}