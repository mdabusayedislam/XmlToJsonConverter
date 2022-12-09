using Newtonsoft.Json;
using System.Xml;

const string DirectoryPath = @"E:\DotNet7\XmlToJsonConverter\XmlToJsonConverter\Data";

string[] files = Directory.GetFiles(DirectoryPath);

foreach (string fileName in files)
{
    ProcessFile(fileName);
}

 static void ProcessFile(string fileName)
{
    if (fileName.Contains(".xml"))
    {
        Console.WriteLine($"File Name {fileName}");
        string xml = File.ReadAllText(fileName);

        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);

        Console.WriteLine("xml load completed");

        string json = JsonConvert.SerializeXmlNode(doc);

        Console.WriteLine("json convert completed");

        File.WriteAllText(fileName.Replace(".xml", ".json"), json);

        Console.WriteLine("json file save completed");
    }    
}
