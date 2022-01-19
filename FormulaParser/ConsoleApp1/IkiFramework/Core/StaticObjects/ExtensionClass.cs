using System.IO;
using System.Xml.Serialization;
namespace IkiCore
{
    public static class ExtensionClass
    {
        /// <summary>
        /// Convert a class to an XML string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToXml<T>(this T value)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                string c;
                using(StringWriter stringWriter = new StringWriter())
                {
                    xmlSerializer.Serialize(stringWriter, value);
                    c = stringWriter.ToString();
                }
                return c;
            }
            catch
            {
                
            }
            return null;
        }
        /// <summary>
        /// Convert an XML string to a class.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlValue"></param>
        /// <returns></returns>
        public static T XmlToClass<T>(this string xmlValue)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T result;
            using (TextReader reader = new StringReader(xmlValue))
            {
                result = (T)serializer.Deserialize(reader);
            }
            return result;
        }
    }
}
