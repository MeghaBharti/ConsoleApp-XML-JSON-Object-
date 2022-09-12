using ClosedXML.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"XML Data");
            var filename = "C:\\Users\\PC-38\\OneDrive\\Desktop\\Megha Documents\\Web App Core\\ConsoleApp3\\XMLdata.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(StudentList));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                var obj = (StudentList)serializer.Deserialize(fs);
                Console.WriteLine($"    Id      Name  ");
                foreach (Student student in obj.Student)
                {

                    Console.WriteLine($"    {student.Id}      {student.Name}");

                }
                fs.Close();
                
            }
            Console.WriteLine("JSON Data");
            var fileJson = "C:\\Users\\PC-38\\OneDrive\\Desktop\\Megha Documents\\Web App Core\\ConsoleApp3\\JsonData.json";
            List<Student> students = new List<Student>();   
            var obj1=JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(fileJson));
            foreach(var i in obj1)
            {
                Console.WriteLine($"{i.Id}   {i.Name}");
            }
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");
            var row = 1;
            //Recorrer el objecto
            foreach(var i in obj1)
            {
                ws.Cells();
            }
            
            workbook.SaveAs("C:\\Users\\PC-38\\OneDrive\\Desktop\\Student1.xlsx");
            Console.ReadKey();

        }
    }
}
