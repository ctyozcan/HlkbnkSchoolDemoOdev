using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace SchoolDemo
{
    public class ClassRoom 
    {
        public int ClassNo { get; set; }
        public string? Letter { get; set; }
        public string? Department { get; set; }

        //10-FM-C
        public string? ClassName { get; }
        
        private List<Student> students = new List<Student>();
        private List<Instructor> ogretmen = new List<Instructor>();
        private List<ClassRoom> derslik = new List<ClassRoom>();

        

        public void AddInstructor(Instructor ogretmenInf)
        {
            ogretmen.Add(ogretmenInf);
        }

        public void AddStudent(Student ogrenci)
        {
            students.Add(ogrenci);
        }
        

        public List<Student> ListStudent()
        {
            return students;
        }

        public List<Instructor> ListInstructor()
        {
            return ogretmen;
        }

        public List<ClassRoom> ListClassRoom() 
        {
            return derslik;
        }

        public List<Student> GetStudents() => students;
        public List<Instructor> GetInstructors() => ogretmen;
        public List<ClassRoom> GetClassRooms() => derslik;

        public int StudentsCount { get => students.Count; }

        public Instructor? MasterInstructor { get; set; }

        

    }
}
