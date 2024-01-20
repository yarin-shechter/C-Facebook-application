using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace Utils
{
    public class AppSettingsManager
    {
        private static readonly string sr_TargetFilePath = string.Format(@"{0}\..\..\appSettings.xml", Directory.GetCurrentDirectory());
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        
        private AppSettingsManager()
        {
            LastAccessToken = null;
            RememberUser = false;
        }

        internal void SaveSettingsToFile()
        {
            if(File.Exists(sr_TargetFilePath))
            {
                using(Stream fileStream = new FileStream(sr_TargetFilePath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(fileStream, this);
                }
            }
            else
            {
                using(Stream fileStream = new FileStream(sr_TargetFilePath, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(fileStream, this);
                }
            }
        }

        internal static AppSettingsManager LoadSettingsFromFile()
        {
            AppSettingsManager resultObject = new AppSettingsManager();

            if(File.Exists(sr_TargetFilePath))
            {
                using(Stream fileStream = new FileStream(sr_TargetFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettingsManager));
                    resultObject = serializer.Deserialize(fileStream) as AppSettingsManager;
                }
            }

            return resultObject;
        }

        internal static void ClearAppSettings()
        {
            File.Delete(sr_TargetFilePath);
        }
    }
}
