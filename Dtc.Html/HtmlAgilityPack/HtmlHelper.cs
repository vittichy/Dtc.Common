using HtmlAgilityPack;

namespace Dtc.Html.Html
{
    public class HtmlHelper
    {
        /// <summary>
        /// Odstraneni html tagu 
        /// </summary>
        /// <param name="html">Html kod</param>
        /// <returns>Prosty text bez html tagu</returns>
        public string StripHtmlTags(string html)
        {
            if (string.IsNullOrEmpty(html))
                return string.Empty;
            
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            // verze htmlDoc.DocumentNode.InnerText funguje obdobne, ale zanechava &nbsp; v textu
            var deEntitized = HtmlEntity.DeEntitize(doc.DocumentNode.InnerText);
            return deEntitized?.Trim();
        }
    }
}
