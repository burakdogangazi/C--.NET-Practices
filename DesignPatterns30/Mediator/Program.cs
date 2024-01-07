using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    { //Arabulucu farklı sistemleri
      //birbirleriyle görüştürür.
      //Havayolu kule iletişimi aynı piste inmeye çalışan
      //5 uçak uçaklar bilgiyi gönderir kule de yönetir.
        static void Main(string[] args)
        {

            Mediator mediator = new Mediator();
            Teacher teacher = new Teacher(mediator);
            teacher.Name = "Burak";
            mediator.Teacher = teacher;

            Student student = new Student(mediator);
            student.Name = "Metin";

            

            Student student1 = new Student(mediator);
            student1.Name = "Aziz";

            mediator.Students = new List<Student> {student1,student };
           
            


        }
    }


    abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    class Teacher : CourseMember
    {
        public string Name { get; set; }
        public Teacher(Mediator mediator) : base(mediator)
        {

        }

        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("Teacher recieved a question from {0},{1}",student.Name,question);
        }

        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher change slide : {0}", url);
            Mediator.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Teacher Answered question {0}{1}", student.Name, answer);
        }
    }

    class Student : CourseMember
    {

        public Student(Mediator mediator) : base(mediator)
        {

        }
        public string Name { get; set; }

        public void RecieveImage(string url)
        {
            Console.WriteLine("Student recieved image :{0}",url);
        }

        public void RecieveAnswer(string answer, Student student)
        {
            Console.WriteLine("Student received answer {0}", answer);
        }
    }

    class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);
            }
        }
        public void SendQuestion(string question, Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }

        public void SendAnswer(string answer,Student student)
        {
            student.RecieveAnswer(answer, student);
        }







    }


}
