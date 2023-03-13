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

            XmlElement element1 = doc.CreateElement(string.Empty, "registrados", string.Empty);
            doc.AppendChild(element1);

            // Las siguientes lineas se harán una vez para cada elemento de un array
            // donde estén todos los datos a ingresar
            // INICIO del bucle de registros a generar

                XmlElement element2 = doc.CreateElement(string.Empty, "usuario", string.Empty);
                element1.AppendChild(element2);
                element2.SetAttribute("id", "1");

                XmlElement element3 = doc.CreateElement(string.Empty, "nombre", string.Empty);
                XmlText text1 = doc.CreateTextNode("USR1");
                element3.AppendChild(text1);
                element2.AppendChild(element3);

                XmlElement element4 = doc.CreateElement(string.Empty, "clave", string.Empty);
                XmlText text2 = doc.CreateTextNode("CLAVE1");
                element4.AppendChild(text2);
                element2.AppendChild(element4);

            // FIN del bucle de registros a generar

            doc.Save("C:\\profesorcarlos.es\\1DAW-LLMM\\t3\\usuariosWeb.xml");

            // ahora LEO el documento nuevo XML recién generado

            XmlDocument docXml = new XmlDocument();
            docXml.Load("C:\\profesorcarlos.es\\1DAW-LLMM\\t3\\usuariosWeb.xml");
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