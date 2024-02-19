using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

namespace Attendance_C__XML_Project
{
    static public class FileManagment
    {
        //validate the given list against xsd rules
        //takes the list to validate and the xsd file path
        public static bool ValidateAgainstXsd<T>(List<T> loistOfObjects, string xsdFileName)
        {
            // Load XSD schema
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", xsdFileName);

            // Create settings for XML validation
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = schemas;

            // Create a string writer to serialize classes to XML string
            StringWriter stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Class>));
            serializer.Serialize(stringWriter, loistOfObjects);

            // Create XML reader for validation
            using (XmlReader reader = XmlReader.Create(new StringReader(stringWriter.ToString()), settings))
            {
                try
                {
                    // Read through the XML document (this will trigger validation)
                    while (reader.Read()) { }
                    return true; // Validation succeeded
                }
                catch (XmlSchemaValidationException ex)
                {
                    Console.WriteLine("Validation Error: " + ex.Message);
                    return false; // Validation failed
                }
            }
        }

        //Writing the objects to xML file
        //takes a list of objects, ex: classes and the file path, ex: classes.xml
        public static void SerializeClassesToXml<T>(List<T> listOfObjects, string filePath)
        {
            // Serialize listOfObjects to XML file
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, listOfObjects);
            }
        }

        //Read an xml file
        //Takes the xml file path to read from and the list to load with the xml content
        public static void LoadClassesFromFile<T>(string _filePath, ref List<T> listOfObjects)
        {
            string filePath = _filePath; // Path to your XML file

            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Class>));
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        listOfObjects = (List<T>)serializer.Deserialize(fileStream);
                    }

                    // You can now use the 'classes' list as needed
                    // For example, you can bind it to a DataGridView or ListBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Classes file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
