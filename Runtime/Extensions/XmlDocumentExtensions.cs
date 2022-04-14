using System.Text.RegularExpressions;
using System.Xml;

namespace SorceressSpell.LibrarIoh.Xml
{
    public static class XmlDocumentExtensions
    {
        #region Methods

        public static void AppendDeclaration(this XmlDocument xmlDocument, string version, string encoding, string standalone)
        {
            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration(version, encoding, standalone);
            xmlDocument.AppendChild(xmlDeclaration);
        }

        public static XmlElement AppendElement(this XmlDocument xmlDocument, XmlElement parentElement, string prefix, string localName, string namespaceURI)
        {
            XmlElement xmlElement = xmlDocument.CreateElement(prefix, localName, namespaceURI);
            parentElement.AppendChild(xmlElement);
            return xmlElement;
        }

        public static XmlElement AppendRootElement(this XmlDocument xmlDocument, string prefix, string localName, string namespaceURI)
        {
            XmlElement xmlElement = xmlDocument.CreateElement(prefix, localName, namespaceURI);
            xmlDocument.AppendChild(xmlElement);
            return xmlElement;
        }

        public static void RemoveSingleLineComments(this XmlDocument xmlDocument)
        {
            xmlDocument.InnerXml = Regex.Replace(xmlDocument.InnerXml, "(<!--.*?-->)", string.Empty, RegexOptions.Singleline);
        }

        public static XmlElement SelectSingleElement(this XmlDocument xmlDocument, string xpath)
        {
            return xmlDocument.SelectSingleNode(xpath) as XmlElement;
        }

        #endregion Methods
    }
}
