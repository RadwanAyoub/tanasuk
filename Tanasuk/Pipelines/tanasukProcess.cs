using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tanasuk.Models;

namespace Tanasuk.Pipelines
{
    public class tanasukProcess
    {
        public void Process(TanasukPipelinesArgs args)
        {/*
            if (args.Item["date"] == string.Empty)
            {
                args.Valid = false;
                args.Message = "Date has not been set";
            }*/
            //Sitecore.Pipelines.CorePipeline.Run("tanasukPipelines", args);
            Log.Audit("ddddd", this);
            Log.Error("XXX_____________________XXX", this);
        }
    }
}