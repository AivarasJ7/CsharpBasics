using System.Diagnostics;
using System.Xml.Linq;

namespace CSharpKlases9
{
    public class Teacher : Person
    {
        // Tada sukurkite paveldėtas klases Student ir Teacher su papildomomis savybėmis,
        // tokiais kaip GradeLevel ir Subject atitinkamai, bei papildomais metodais PrintStudentInfo() ir PrintTeacherInfo(),
        // kurie išveda informaciją apie mokinį ar mokytoją. Savo nuožiūra galite sugalvoti naujų paveldinčių klasių ir sąvybių.

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public string Subject { get; }

        public string PrintTeacherInfo()
        {
            return $"Vardas: {Name}, metai: {Age}, tema: {Subject}";
        }
    }
}
