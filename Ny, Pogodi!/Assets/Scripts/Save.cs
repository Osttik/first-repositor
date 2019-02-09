using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public class Save : MonoBehaviour {

	public class SaveData
    {
        [XmlAttribute("score")]
        public int score;

        [XmlAttribute("dificulty")]
        public string dificulty;

        public void Save(string path)
        {
            var serializer = new XmlSerializer(typeof(SaveData));
            using (var stream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }

        public static SaveData Load(string path)
        {
            var serializer = new XmlSerializer(typeof(SaveData));
            using (var stream = new FileStream(path, FileMode.Open))
            {
                return serializer.Deserialize(stream) as SaveData;
            }
        }
    }
}
