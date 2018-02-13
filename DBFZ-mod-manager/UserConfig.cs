using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace ModManager.UserConfig
{
    /// <summary>
    /// Holds user config settings and provides events that notify another class
    /// when a property is changed.
    /// </summary>
    [Serializable]
    public class ConfigData : INotifyPropertyChanged
    {
        /*
         * Boilerplate code that is used to detect when a property is
         * changed. (boring, you can ignore this)
         */
        // [Event Handling]

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        /*
         * Add properties here.
         */
        // [Properties]

        private string _GameDirectory = Properties.Settings.Default.gamePath;
        /// <summary>
        /// The installation path of DragonBallFighterZ
        /// </summary>
        public string GameDirectory
        {
            get { return _GameDirectory; }
            set
            {
                if (value != _GameDirectory)
                {
                    _GameDirectory = value;// Update property if value is different.
                    OnPropertyChanged("GameDirectory");// Trigger event
                }
            }
        }

    }


    /// <summary>
    /// Contains config singleton that automatically saves updated config settings
    /// to disk as a JSON file by simply updating the property.
    /// Can be accessed application-wide. (Thread-Safe)
    /// </summary>
    public sealed class ConfigSingleton
    {
        /*
         * Singleton boilerplate code. (boring, you can ignore this)
         */
        private static readonly Lazy<ConfigSingleton> lazy =
            new Lazy<ConfigSingleton>(() => new ConfigSingleton());

        public static ConfigSingleton Instance { get { return lazy.Value; } }

        /*
         * Class Code
         */
        // [Internal Properties]
        private string configPath = Properties.Settings.Default.userConfigPath;// UserConfig.json

        // [Properties]
        private ConfigData _Config = null;// This will always be null when application starts.
        /// <summary>
        /// Holds all user configuration settings.
        /// </summary>
        public ConfigData Config
        {
            get
            {
                if (_Config == null)
                {
                    if (System.IO.File.Exists(configPath))
                    {
                        //Load and deserialize file into object from UserConfig.json
                        _Config = JsonConvert.DeserializeObject<ConfigData>(System.IO.File.ReadAllText(configPath));
                    }
                    else
                    {
                        // Create new UserConfig.json file with default values and serialize it to the file
                        _Config = new ConfigData();
                        System.IO.File.WriteAllText(configPath, JsonConvert.SerializeObject(_Config));
                    }
                }

                return _Config;
            }
        }

        // [Constructors]

        /// <summary>
        /// Constructor (Default).
        /// Sets up event handling to detect propety changes in this.Config
        /// in singleton instance.
        /// </summary>
        private ConfigSingleton() { this.Config.PropertyChanged += Config_PropertyChanged;/*Handle PropertyChanged event.*/ }

        // [Event Handlers]

        /// <summary>
        /// Even Handler.
        /// When property is updated, it is then automatically saved to disk.
        /// (Cool I know)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Config_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Save updated config object to file (UserConfig.json)
            System.IO.File.WriteAllText(configPath, JsonConvert.SerializeObject(_Config));
        }
    }


}
