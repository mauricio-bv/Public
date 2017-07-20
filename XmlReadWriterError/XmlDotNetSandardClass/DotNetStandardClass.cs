using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace XmlDotNetSandardClass
{
    public class DotNetStandardClass
    {
        public void MethodThatFails()
        {

            XDocument doc = new XDocument(
               new XComment("This is a comment"),
               new XElement("Root",
                   new XElement("Child1", "data1"),
                   new XElement("Child2", "data2"),
                   new XElement("Child3", "data3")
               )
           );

            foreach (XNode n in doc.Nodes())
            {
                if (n.NodeType == XmlNodeType.Element)
                {
                    Debug.WriteLine(n.ToString());
                    break;
                }

            }
        }
    }
}
