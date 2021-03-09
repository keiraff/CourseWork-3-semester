using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using CourseWork.Models;
using System.Collections.ObjectModel;

namespace CourseWork.Data
{
    public class DataBase
    {
        private List<Test> tests;
        public List<Test> Tests { get => tests;  set => tests = value; }
        private Test selectedTest;
        public Test SelectedTest { get => selectedTest;  set => selectedTest = value; }
        private Test newTest;
        public Test NewTest { get => newTest; set => newTest = value; }
        public string FileName { get; }
        public DataBase(string filename)
        {
            Tests = Deserialization(filename);
            FileName = filename;
        }
        public static void Serialization(string filename,List<Test> tests)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Test>));
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                ser.Serialize(file, tests);
            }
        }
            public static List<Test>  Deserialization(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Test>));
            using (FileStream file = new FileStream(filename, FileMode.OpenOrCreate))
            {
                return (List<Test>)ser.Deserialize(file);
            }

        }

    }
}
