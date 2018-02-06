using System;
using System.IO;
using System.Collections.Specialized;


namespace ModManager
{
    class Ini
    {
        public static NameValueCollection Parse(string path) {

            NameValueCollection parsedData = new NameValueCollection();

            string file = File.ReadAllText(path);
            string[] descriptions = file.Split(
                Environment.NewLine.ToCharArray(), 
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (var description in descriptions) {
                var split = description.Split(new[] { "=" }, StringSplitOptions.None);
                string key = split[0].ToString();
                string value = split[1].ToString();
                parsedData[key] = value;
            }

            return parsedData;
        }
    }
}
