using Sitecore.Form.Core.Pipelines.FormUploadFile;
namespace Tanasuk.Pipelines
{
    public class UploadeLimitation
    {
        public void Process(FormUploadFileArgs args)
        {
            int size = 10485760; // == 10 Mb
            if (args.File.Data.Length > size)
            {
                Sitecore.Diagnostics.Log.Info(string.Format("User {0} tried to upload a file larger than 10 Mb. The file name is {1}", Sitecore.Context.User.Name, args.File.FileName), this);
                args.AbortPipeline();
            }
        }
    }
}