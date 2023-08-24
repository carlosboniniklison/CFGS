using System;
using System.Xml;

namespace GrabarXML2_borrar
{
    class Program
    {
        static void Main(string[] args)
        {
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

            doc.Save("G:\\xampp\\htdocs\\profesorcarlos.es\\1DAW-LLMM\\t3\\nuevo.xml");

            // ya lo hemos creado, ahora a ver qué ha salido

            XmlDocument doc1 = new XmlDocument();
            doc1.Load("G:\\xampp\\htdocs\\profesorcarlos.es\\1DAW-LLMM\\t3\\empleados.xml");

            // doc.Load("C:\\profesorcarlos.es\\1DAW-LLMM\\t3\\empleados.xml"); 
            foreach (XmlNode node in doc1.DocumentElement.ChildNodes)
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

        }
    }
}
