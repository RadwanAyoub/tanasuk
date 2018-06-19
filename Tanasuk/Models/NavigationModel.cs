using System.Collections.Generic;

namespace Tanasuk.Models
{
    public class NavigationModel
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
        public List<NavigationModel> Children = new List<NavigationModel>();
    }
}