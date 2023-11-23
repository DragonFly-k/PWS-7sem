using lab3.Student;
using lab3.StudentsHttp;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace lab3.Serializer
{
    public class StudentSerializer
    {
        public StringContent JsonSerialize(StudentsResponse studentsResponse) //коллекция
        {
            return new StringContent(JsonConvert.SerializeObject(studentsResponse), Encoding.UTF8, "application/json");
        }

        public StringContent JsonSerialize(StudentResponse studentsResponse)
        {
            return new StringContent(JsonConvert.SerializeObject(studentsResponse), Encoding.UTF8, "application/json" );
        }

        public StringContent XmlSerialize(StudentsResponse studentsResponse)
        {
            var jsonTest = JsonConvert.SerializeObject(studentsResponse);
            var xmlTest = JsonConvert.DeserializeXmlNode(jsonTest, "root");
            return new StringContent(xmlTest.OuterXml, Encoding.UTF8,"application/xml");
        }

    }
}