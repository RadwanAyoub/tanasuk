using Sitecore.Mvc.Presentation;
using Tanasuk.Models;
using Sitecore.Resources.Media;
using Sitecore.Data.Items;

namespace Tanasuk.Business
{
    public class IMedia
    {
        public static Image Source()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);
            Sitecore.Data.Fields.ImageField imi = dataSource.Fields["Image"];
            var image = new MediaItem(imi.MediaItem);
            return new Image() { Src = MediaManager.GetMediaUrl(image)};
        } 
    }
}