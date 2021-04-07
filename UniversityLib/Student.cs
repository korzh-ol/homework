using System;

namespace UniversityLib
{
    public class Student
    {
        public string Name;
        public string Surname;
        public readonly long CardID;
        public string Group;
        public string Institute;
        public TypeOfEducation EduType;

        public Student(string name, string surname, long cardID, string group, string institute, TypeOfEducation eduType)
        {
            Name = name;
            Surname = surname;
            CardID = cardID;
            Group = group;
            Institute = institute;
            EduType = eduType;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var eduType = "";
            switch (EduType)
            {
                case TypeOfEducation.Bachelor:
                    eduType = "бакалавриат";
                    break;
                case TypeOfEducation.Specialty:
                    eduType = "специалитет";
                    break;
                case TypeOfEducation.Master:
                    eduType = "магистратура";
                    break;
            }
            
            Console.WriteLine($"Номер зачетной книжки: {CardID}. Группа: {Group}. Институт: {Institute}. Направление обучения: {eduType}.");
        }
    }
}
