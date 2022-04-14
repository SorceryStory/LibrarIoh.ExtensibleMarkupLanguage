using System;
using System.Xml;

namespace SorceressSpell.LibrarIoh.Xml
{
    public static class XmlElementExtensions
    {
        #region Methods

        public static void AppendAttribute(this XmlElement xmlElement, string name, string value)
        {
            XmlAttribute xmlAttribute = xmlElement.OwnerDocument.CreateAttribute(name);
            xmlAttribute.Value = value;
            xmlElement.Attributes.Append(xmlAttribute);
        }

        public static void AppendAttribute(this XmlElement xmlElement, string name, string namespaceURI, string value)
        {
            XmlAttribute xmlAttribute = xmlElement.OwnerDocument.CreateAttribute(name, namespaceURI);
            xmlAttribute.Value = value;
            xmlElement.Attributes.Append(xmlAttribute);
        }

        public static T GetAttributeEnumValue<T>(this XmlElement xmlElement, string attributeName, T defaultValue)
            where T : struct, IConvertible
        {
            if (typeof(T).IsEnum)
            {
                XmlAttribute xmlAttribute = xmlElement.Attributes[attributeName];

                if (xmlAttribute != null)
                {
                    return (T)Enum.Parse(typeof(T), xmlAttribute.Value);
                }
            }

            return defaultValue;
        }

        public static T GetAttributeValue<T>(this XmlElement xmlElement, string attributeName, T defaultValue)
            where T : IConvertible
        {
            XmlAttribute xmlAttribute = xmlElement.Attributes[attributeName];

            if (xmlAttribute != null)
            {
                return ConversionOperations.ConvertTo<T>(xmlAttribute.Value);
            }

            return defaultValue;
        }

        public static XmlElement SelectSingleElement(this XmlElement xmlElement, string xpath)
        {
            return xmlElement.SelectSingleNode(xpath) as XmlElement;
        }

        #endregion Methods
    }
}
