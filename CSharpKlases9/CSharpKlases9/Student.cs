using System.Xml.Linq;

namespace CSharpKlases9
{
    public class Student : Person
    {
        // Tada sukurkite paveldėtas klases Student ir Teacher su papildomomis savybėmis,
        // tokiais kaip GradeLevel ir Subject atitinkamai, bei papildomais metodais PrintStudentInfo() ir PrintTeacherInfo(),
        // kurie išveda informaciją apie mokinį ar mokytoją. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public Student(string name, int age, string gradeLevel) : base(name, age)
        {
            GradeLevel = gradeLevel;
        }

        public string GradeLevel { get; }

        public string PrintStudentInfo()
        {
            return $"Vardas: {Name}, metai: {Age}, klases lygis: {GradeLevel}";
        }
    }
}
