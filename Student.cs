using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    [XmlRoot(ElementName ="Student")]
    public class Student
    {
        [XmlElement(ElementName ="Id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }
    [XmlRoot(ElementName = "StudentList")]
    public class StudentList
    {
        [XmlElement(ElementName = "Student")]
        public  List<Student> Student { get; set; }
    }
}
