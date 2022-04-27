using System.Xml;

namespace SorceressSpell.LibrarIoh.Xml
{
    public static class XmlOperations
    {
        #region Methods

        public static void AppendNewAttribute(XmlDocument xmlDocument, XmlElement xmlElement, string name, string value)
        {
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute(name);
            xmlAttribute.Value = value;
            xmlElement.Attributes.Append(xmlAttribute);
        }

        public static void AppendNewAttribute(XmlDocument xmlDocument, XmlElement xmlElement, string name, string namespaceURI, string value)
        {
            XmlAttribute xmlAttribute = xmlDocument.CreateAttribute(name, namespaceURI);
            xmlAttribute.Value = value;
            xmlElement.Attributes.Append(xmlAttribute);
        }

        public static void AppendNewDeclaration(XmlDocument xmlDocument, string version, string encoding, bool standalone)
        {
            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration(version, encoding, standalone ? "yes" : "no");
            xmlDocument.AppendChild(xmlDeclaration);
        }

        public static XmlElement AppendNewElement(XmlDocument xmlDocument, XmlElement parentElement, string prefix, string localName, string namespaceURI)
        {
            XmlElement xmlElement = CreateNewElement(xmlDocument, prefix, localName, namespaceURI);
            parentElement.AppendChild(xmlElement);
            return xmlElement;
        }

        public static XmlElement AppendNewRootElement(XmlDocument xmlDocument, string prefix, string localName, string namespaceURI)
        {
            XmlElement xmlElement = xmlDocument.CreateElement(prefix, localName, namespaceURI);
            xmlDocument.AppendChild(xmlElement);
            return xmlElement;
        }

        public static XmlElement CreateNewElement(XmlDocument xmlDocument, string prefix, string localName, string namespaceURI)
        {
            return xmlDocument.CreateElement(prefix, localName, namespaceURI);
        }

        #endregion Methods
    }
}
