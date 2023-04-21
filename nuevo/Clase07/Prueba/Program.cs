using System.Xml.Serialization;
using System.Xml;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string dataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        List<string> listaStringXml = new List<string>();
        listaStringXml.Add("hola");
        listaStringXml.Add("Pedro");
        List<string> strings = new List<string>();

        try
        {
            
            using (StreamReader sr = new StreamReader(dataPath + @"\listaSupermercado.xml"))
            {
                XmlSerializer serializer = new XmlSerializer((typeof(List<string>)));

                listaStringXml = (List<string>)serializer.Deserialize(sr);
            }

            foreach (string item in listaStringXml)
            {
                strings.Add(item);
                Console.WriteLine(item);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}