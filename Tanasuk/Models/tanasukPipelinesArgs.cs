using Sitecore.Data.Items;
using Sitecore.Pipelines;

namespace Tanasuk.Models
{
    public class TanasukPipelinesArgs : PipelineArgs
    {
        private bool m_valid = false;
        private string m_message = string.Empty;
        private Item m_item = null;

        public bool Valid
        {
            get { return m_valid; }
            set { m_valid = value; }
        }

        public string Message
        {
            get { return m_message; }
            set { m_message = value; }
        }

        public Item Item
        {
            get { return m_item; }
            set { m_item = value; }
        }

        public TanasukPipelinesArgs(Item item)
        {
            m_item = item;
        }

    }
}