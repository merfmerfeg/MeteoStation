using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOModule
{
    public class Tag
    {
        public ValueType Value
        {
            get => default(int);
            set
            {
            }
        }

        public TagsType Type
        {
            get => default(int);
            set
            {
            }
        }

        public DateTime TimeStamp
        {
            get => default(DateTime);
            set
            {
            }
        }

        public string ID
        {
            get => default(string);
            set
            {
            }
        }

        internal string DeviceId
        {
            get => default(string);
            set
            {
            }
        }
    }
}