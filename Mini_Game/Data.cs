using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mini_Game
{
    internal class Data
    {
        public static CharacterData characterData = new CharacterData();

        public static T ReadFromXMLData<T>() where T : new()
        {
            TextReader reader = null;

            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader("Config.xml");

                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                reader.Close();
            }
        }

        public static void ReadConfigDataStrings()
        {
            CharacterData data = ReadFromXMLData<CharacterData>();
            characterData.HealthPoints = Convert.ToInt32(data.HealthPoints);
        }

        public static void WriteToConfigData<T>(T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter("Config.xml", append);
                serializer.Serialize(writer, objectToWrite);
                if (writer == null)
                    writer.Close();
            }
            finally
            {
                writer.Close();
            }
        }
    }

    public class CharacterData
    {
        private int healthPoints { get; set; }

        public int HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }

        }
    }
}
