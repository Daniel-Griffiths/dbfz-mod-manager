using System;
using System.Text.RegularExpressions;

namespace ModManager
{
    class Helper
    {
        // Remove html from a string
        public static string StripHtml(string html)
        {
            return Regex.Replace(
                html
                .Replace("</br>", Environment.NewLine)
                .Replace("<br>", Environment.NewLine)
                .Replace("&nbsp;", " "),
                "<.*?>", String.Empty
            );
        }
    }
}
