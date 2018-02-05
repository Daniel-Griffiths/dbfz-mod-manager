using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ModManager
{
    class GameBanana
    {
        // Downloads a mod from gamebannana (example url: dbfmm:https://gamebanana.com/skins/160397,Skin,160397)
        public static void Process(string[] args)
        {
            try
            {
                if (args.Length > 1)
                {
                    string[] parameters = args[1].Replace(Protocol.ProtocolName + ":", "").Split(new string[] { "," }, StringSplitOptions.None);
                    string url = parameters[0];
                    string type = parameters[1];
                    string id = parameters[2];

                    string apiResponse = new WebClient().DownloadString($"https://api.gamebanana.com/Core/Item/Data?itemtype={type}&itemid={id}&fields=name,description,text,userid,Credits().aAuthors(),Preview().sStructuredDataFullsizeUrl()&format=xml");

                    XDocument xml = XDocument.Parse(apiResponse);
                    List<System.Xml.Linq.XElement> values = xml.Root.Elements("value").ToList();
                    
                    GameBananaForm GameBananaForm = new GameBananaForm();
                    GameBananaForm.downloadUrl = url;
                    GameBananaForm.SetContent(values);
                    GameBananaForm.ShowDialog();                  
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
