using Sitecore.Data;
using Sitecore.Diagnostics;
using Sitecore.Security.Authentication;
using Sitecore.WFFM.Abstractions.Actions;

namespace Tanasuk.SaveActions
{
    public class ContactUsLog : ISaveAction
    {
        public ID ActionID { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string UniqueKey { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public ActionType ActionType => throw new System.NotImplementedException();
        public void Execute(ID formId, AdaptedResultList adaptedFields, ActionCallContext actionCallContext = null, params object[] data)
        {
            throw new System.NotImplementedException();
        }
        public ActionState QueryState(ActionQueryContext queryContext)
        {
            throw new System.NotImplementedException();
        }
        public void Log()
        {
            Sitecore.Diagnostics.Log.Info("XXX________________________________XXX", this);
        }
    }
}