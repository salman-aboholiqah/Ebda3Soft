using Ebda3Soft.Views.Core.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ebda3Soft.Core
{
    public class SharedFormat
    {
        public static void WriteXmlFormat<T>(T obj, XmlWriter writer)
        {
            try
            {
                var startName = obj.GetType().Name;
                if (startName.Contains("_"))
                    startName = startName.Split('_')[0];

                writer.WriteStartElement(startName);

                var propeties = obj.GetType().GetProperties();


                foreach (var property in propeties)
                {
                    if (!property.CanWrite)
                    {
                        continue;
                    }
                    bool ignored = false;
                    foreach (var attribute in property.GetCustomAttributes(typeof(XmlIgnoreAttribute), true))
                    {
                        if (attribute is XmlIgnoreAttribute)
                        {
                            ignored = true;
                            break;
                        }
                    }
                    if (ignored)
                        continue;
                    string typeName = property.GetValue(obj)?.GetType()?.Name;
                    if (typeName?.Contains(("HashSet")) == true)
                    {
                        var collection = property.GetValue(obj) as HashSet<object>;
                        if (collection != null)
                        {
                            foreach (var item in collection)
                            {
                                if (item is IXmlSerializable == true)
                                {
                                    break;
                                }
                                WriteXmlFormat(item, writer);

                            }
                        }
                    }
                    else if (property.GetValue(obj) is IXmlSerializable)
                    {
                        (property.GetValue(obj) as IXmlSerializable).WriteXml(writer);
                    }
                    else
                    {
                        writer.WriteElementString(property.Name, property.GetValue(obj)?.ToString() ?? "");

                    }
                }
                writer.WriteEndElement();
                writer.Flush();
            }
            catch (Exception ex)
            {
                ExceptionDialog.Show(ex);
            }
        }
    }
}
