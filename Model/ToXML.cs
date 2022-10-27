using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace BruttoNettoRechner.Model
{
    internal class ToXML
    {
        
        public async Task XMLRunAsync(AbrechnungSerialObject serialObj)
        {
            string? _fileName = "";

           
            if (!string.IsNullOrEmpty(serialObj.Name))
            {
                 _fileName = serialObj.Name + ".xml";
            }
            else
            {
                 _fileName = "Alias.xml";
            }

            try
            {
                XmlWriterSettings xmlWSettings = new()   {  Indent = true, Async = true} ;
                

                var serializer = new XmlSerializer(serialObj.GetType());

                await using FileStream stream = new(_fileName, FileMode.Create, FileAccess.ReadWrite);
                
                using XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWSettings);

                serializer.Serialize(xmlWriter, serialObj);
                await xmlWriter.FlushAsync();

            } 
        
            catch(Exception ex)   
            {
                MessageBox.Show(ex.Message);

            }



        }


    }
}
