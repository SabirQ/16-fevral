using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ramin", "Aliyev", "P127", 92, true);
            Student student2 = new Student("Kamil", "Hamidov", "P127", 76, false);

            #region 1ci telebe
            Console.WriteLine(student.Fullname());

            Console.WriteLine(student.Allinfo());

            //student.ExamAgain();      
            
            Console.WriteLine(student.ExamAgain2());
            #endregion


            #region 2ci telebe
            Console.WriteLine(student2.Fullname());

            Console.WriteLine(student2.Allinfo());

            //student2.ExamAgain();

            Console.WriteLine(student2.ExamAgain2());
            #endregion

        }
    }
    class Student
    {
        public Student(string name,string surname,string group,int point,bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = isgraduated;
        }
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduated;

        public string Fullname()
        {
            return $"Name: {Name}\nSurname: {Surname}";
        }
        public string Allinfo()
        {
            string GraduatedOrNot;
            if (isGraduated==true)
            {
                GraduatedOrNot = "Bu telebe mezun olub";
            }
            else
            {
                GraduatedOrNot = "Bu telebe mezun olmayib";
            }
            return $"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\nGraduated: {GraduatedOrNot}";
        }
        public void ExamAgain()         //voidle olan versiya
        {
            if (Point>=80)
            {
                Console.WriteLine($"{Name} {Surname}-adli telebe {Point} bal topladigi ucun yeniden imtahana buraxilir");
            }
            else
            {
                Console.WriteLine($"{Name} {Surname}-adli telebe {Point} bal topladigi ucun yeniden imtahana buraxilmir");
            }
        }
        public string ExamAgain2()     //return ile olan versiya
        { string result;
            if (Point >= 80)
            {
                result=$"{Name} {Surname}-adli telebe {Point} bal topladigi ucun yeniden imtahana buraxilir";
            }
            else
            {
               result=$"{Name} {Surname}-adli telebe {Point} bal topladigi ucun yeniden imtahana buraxilmir";
            }
            return result;
        }
    }
}
