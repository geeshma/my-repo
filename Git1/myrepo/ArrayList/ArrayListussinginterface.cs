using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    interface IStudentRepositroy
    {
        void AddStudent(Student student);
        Student GetStudent(int id);
        ArrayList GetStudents();
        void DeleteStudent(int id);
        void UpdateStudent(int id, int age);
    }
    class StudentRepository : IStudentRepositroy
    {
        ArrayList list = new ArrayList();
        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        public void DeleteStudent(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (((Student)list[i]).Sid == id)
                {
                    list.RemoveAt(i);
                    break;
                }
            }
        }

        public Student GetStudent(int id)
        {
            foreach (Student s in list)
            {
                if (s.Sid.Equals(id))
                {
                    return s;
                }
            }
            return null;
        }

        public ArrayList GetStudents()
        {
            return list;
        }

        public void UpdateStudent(int id, int age)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (((Student)list[i]).Sid == id)
                {
                    ((Student)list[i]).Age = age;
                }
            }
        }
    }

    class Student
    {
        static void Main()
        {
            StudentRepository sr = new StudentRepository();
            bool restart = true;
            while (restart)
            {
                Console.WriteLine("Product Details");
                Console.WriteLine("(a) Add the Student's info\n(b) Deleting the recordt\n(c) Searching the record\n(d) Display the records\n(e) Update record\n(f) Quit\nYour Choice : ");
                char c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case 'a':
                        sr.AddStudent(new Student() { Sid = 1, Sname = "Rohan", Age = 20 });
                        sr.AddStudent(new Student() { Sid = 2, Sname = "Charan", Age = 12 });
                        sr.AddStudent(new Student() { Sid = 3, Sname = "Karan", Age = 10 });
                        break;
                    case 'b':
                        sr.DeleteStudent(2);
                        break;
                    case 'c':
                        Student st = sr.GetStudent(1);
                        Console.WriteLine("{0}'s details:-", st.Sname);
                        Console.WriteLine("ID  : {0}\nAGE : {1}", st.Sid, st.Age);
                        break;
                    case 'd':
                        foreach (var x in sr.GetStudents())
                        {
                            Student s = (Student)x;
                            Console.WriteLine("Students details:-");
                            Console.WriteLine("{0} {1} {2}", s.Sid, s.Sname, s.Age);
                        }
                        break;
                    case 'e':
                        sr.UpdateStudent(3, 24);
                        break;
                    case 'f': restart = false; break;
                    default: Console.WriteLine("Invalid Choice...TRY AGAIN"); break;
                }
            }
        }
    }
}
