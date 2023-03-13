using System;
using System.Xml;

//ejemplo tomado de la pagina decodigo.com

namespace CrearXml
{
    class Program
    {
        static void Main(string[] args)
        {
            // primero genero el nuevo documento XML
            
            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement element1 = doc.CreateElement(string.Empty, "empresa", string.Empty);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(string.Empty, "empleado", string.Empty);
            element1.AppendChild(element2);
            element2.SetAttribute("id", "1");

            XmlElement element3 = doc.CreateElement(string.Empty, "nombre", string.Empty);
            XmlText text1 = doc.CreateTextNode("Empleado 1");
            element3.AppendChild(text1);
            element2.AppendChild(element3);

            XmlElement element4 = doc.CreateElement(string.Empty, "estatus", string.Empty);
            XmlText text2 = doc.CreateTextNode("activo");
            element4.AppendChild(text2);
            element2.AppendChild(element4);

            doc.Save("\\xampp\\htdocs\\profesorcarlos.es\\1DAW-LLMM\\t3\\nuevo.xml");

            // ahora LEO el documento nuevo XML recién generado

            XmlDocument docXml = new XmlDocument();
            docXml.Load("\\xampp\\htdocs\\profesorcarlos.es\\1DAW-LLMM\\t3\\nuevo.xml");
            foreach (XmlNode node in docXml.DocumentElement.ChildNodes)
            {
                String id = node.Attributes["id"].Value;
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
