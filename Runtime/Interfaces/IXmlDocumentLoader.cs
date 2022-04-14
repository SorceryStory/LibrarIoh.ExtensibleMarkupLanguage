using System.Xml;

namespace SorceressSpell.LibrarIoh.Xml
{
    public interface IXmlDocumentLoader
    {
        #region Methods

        XmlDocument LoadXmlDocument(string path);

        #endregion Methods
    }
}
