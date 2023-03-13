using System;
using System.Xml;

namespace LeerXML
{
    class Program
    {
        private const string Filename = "\\xampp\\htdocs\\profesorcarlos.es\\1DAW-LLMM\\t3\\empleados.xml";

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Filename);
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                String id = node.Attributes["nro"].Value;
                Console.WriteLine("id: " + id);
                if (node.HasChildNodes)
                {
                    for (int i = 0; i < node.ChildNodes.Count; i++)
                    {
                        Console.WriteLine(node.ChildNodes[i].Name + " : " + node.ChildNodes[i].InnerText);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
