using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArrayList2
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int age {  get; set; }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Student s1 = new Student() {Sid=1,Sname="gr", age=45 };
            Student s2 = new Student() { Sid = 3, Sname = "rt", age = 34 };
            al.Add(new Student() { Sid = 3, Sname = "karan", age = 23 });
            foreach(Student item in al)
            {
                Console.WriteLine("{0}{1}{2}", item.Sid, item.Sname,item.age);
            }
        }
    }
}
