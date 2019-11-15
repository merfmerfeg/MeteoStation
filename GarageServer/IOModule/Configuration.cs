using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;


/*
    Класс девайса должен автоматически браться из списка классов




 */


/*
    <Tags>
        <Tag type="Signal" deviceId="1" id="1" />
        <Tag type="Signal" deviceId="1" id="2" />
        <Tag type="Management" deviceId="1" id="3" />
    </Tags>
    <Devices>
        <Device type="HTTPDevice" name="http" path="192.168.1.177" id="1" />
        <Device type="TxtDevice" name="txt" path="123.txt" id="2" />
    </Devices>
 
 * */

namespace IOModule
{
    internal class Configuration
    {
        readonly private XDocument _xdoc;

        internal Configuration(string path)
        {
            _xdoc = XDocument.Load(path);

            var deviceList = from devices in _xdoc.Element("Tags").Elements("Tag")
                             select a /*реализация автоматического определения класса*/


            var tagList = from tags in _xdoc.Element("Tags").Elements("Tag")
                          select new Tag
                          {
                              Type = (TagsType)Enum.Parse(typeof(TagsType), tags.Attribute("type").Value),
                              ID = tags.Attribute("id").Value,
                              DeviceId = tags.Attribute("deviceId").Value,
                              TimeStamp = default(DateTime),
                              Value = default(ValueType)
                          };
        }

        internal List<IDevice> Devices
        {
            get => null;
            set
            {
            }
        }

        internal List<Tag> Tags
        {
            get => null;
            set
            {
            }
        }
    }
}
