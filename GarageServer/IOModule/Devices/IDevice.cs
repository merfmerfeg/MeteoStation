using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOModule
{
    internal interface IDevice
    {
        event Action<List<Tag>> OnChangeTagsValue;
        event Action<ConnectionStatus> OnChangeConnectionStatus;

        string Name { get; set; }
        bool IsConnect { get; set; }
        string Path { get; set; }
        string Id { get; set; }

        List<Tag> GetTagsList();
        List<Tag> GetTagsValue(List<Tag> tagList);
        void SubscribeTags(string[] tagsId);
        void SetTagsValue(List<Tag> tagList);
        void UnsubscribeTags(string[] tagsId);
        List<Tag> GetTagsValue(string[] tagsId);
        bool Connect();
        bool Disconnect();
    }
}