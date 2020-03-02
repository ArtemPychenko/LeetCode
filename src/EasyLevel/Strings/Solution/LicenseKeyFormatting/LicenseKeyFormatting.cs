
using System;
using System.Collections;
using System.Text;

namespace Strings.Solution.LicenseKeyFormatting
{
    public class LicenseKeyFormatting
    {
        public string FormatLicenseKey(string S, int K)
        {
            var sb = new StringBuilder();
            var noDashes = new Stack();
            var counter = 0;

            foreach (var s in S)
            {
                if (s != '-')
                {
                    noDashes.Push(s);
                }
            }

            foreach (var noDash in noDashes)
            {
                if (counter % K == 0 && counter != noDashes.Count && counter != 0)
                {
                    sb.Append("-");
                }

                sb.Append(noDash);
                counter++;
            }

            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);

            string final = new string(charArray);

            return final.ToUpper();
        }
    }
}
