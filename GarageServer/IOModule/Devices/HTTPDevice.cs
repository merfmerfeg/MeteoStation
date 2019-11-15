using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOModule
{
    internal class HTTPDevice : IDevice
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsConnect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action<List<Tag>> OnChangeTagsValue;
        public event Action<ConnectionStatus> OnChangeConnectionStatus;

        public bool Connect()
        {
            throw new NotImplementedException();
        }

        public bool Disconnect()
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetTagsList()
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetTagsValue(List<Tag> tagList)
        {
            throw new NotImplementedException();
        }

        public List<Tag> GetTagsValue(string[] tagsId)
        {
            throw new NotImplementedException();
        }

        public void SetTagsValue(List<Tag> tagList)
        {
            throw new NotImplementedException();
        }

        public void SubscribeTags(string[] tagsId)
        {
            throw new NotImplementedException();
        }

        public void UnsubscribeTags(string[] tagsId)
        {
            throw new NotImplementedException();
        }
    }
}