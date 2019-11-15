using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOModule
{
    public class IODataManager
    {
        public event System.Action<System.Collections.Generic.List<IOModule.Tag>> OnChangeTagsValue;
        public event Action<int, string> OnLogMessage;

        public List<Device> Devices
        {
            get => null;
        }

        public List<Tag> GetTagsValue()
        {
            throw new System.NotImplementedException();
        }

        public List<Tag> GetTagsList()
        {
            throw new System.NotImplementedException();
        }

        public List<Tag> GetTagsValue(List<Tag> tagList)
        {
            throw new System.NotImplementedException();
        }

        public List<Tag> GetTagsValue(string[] tagsId)
        {
            throw new System.NotImplementedException();
        }

        public void SetTagsValue(List<Tag> tagList)
        {
            throw new System.NotImplementedException();
        }

        public void SubscribeTags(string[] tagsId)
        {

        }

        public void UnsubscribeTags(string[] tagsId)
        {

        }
    }
}
