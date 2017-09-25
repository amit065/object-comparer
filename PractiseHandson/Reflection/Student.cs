using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{

    public class Student
    {
        public string  Name { get; set; }

        public int Id { get; set; }

        public int  Age { get; set; }

        public Student(string name,int id,int age)
        {
            Name = name;

            Id = id;

            Age = age;
        }

       
        public void PrintName()
        {
            
        }
        public void PrintId()
        {

        }
        public void PrintAge()
        {

        }

    }


}
