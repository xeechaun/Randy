using System;
using System.IO;
using System.Xml.Serialization;

namespace Randy
{
    [Serializable()]
    public class Settings
    {
        public string FeedSources { get; set; }

        public Settings()
        {
            FeedSources = "";
            //if (!Directory.Exists(appDirectory))
            //    Directory.CreateDirectory(appDirectory);

        }

        public static Settings CurrentSettings = new Settings();
        //-------------------------------------//
        public static void LoadSettings()
        {
            if (File.Exists("config.xml"))
            {
                CurrentSettings = ReadFromXmlFile<Settings>("config.xml");
            }
            else
            {
                CurrentSettings = new Settings();
                SaveSettings();
            }
        }
        //-------------------------------------//
        public static void SaveSettings()
        {
            WriteToXmlFile<Settings>("config.xml", CurrentSettings, false);
        }
        //-------------------------------------//
        private static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append) where T : new()
        {
            TextWriter writer = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        //-------------------------------------//
        private static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        //-------------------------------------//
    }
}
