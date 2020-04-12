using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Strings.Solution.HtmlParser
{
    public class HtmlParser
    {
        public string EntityParser(string text)
        {
            var quot = Regex.Replace(text, "&quot;", "\"");
            var apos = Regex.Replace(quot, "&apos;", "'");
            var amp = Regex.Replace(apos, "&amp;", "&");
            var gt = Regex.Replace(amp, "&gt;", ">");
            var lt = Regex.Replace(gt, "&lt;", "<");
            var frasl = Regex.Replace(lt, "&frasl;", "/");

            return frasl;
        }
    }
}
