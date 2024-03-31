using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    internal class Group : Student
    {
        public string No;
        private byte _studentLimit;

        Student[] Students = new Student[] { };

        public byte StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if( value>0 )
                {
                    _studentLimit = value;
                }
            }
        }
        public Group()
        {
            
        }


        public Group(string fullname,string groupno,double avgpoint,string no,byte studentlimit): base(fullname,groupno,avgpoint)
        {
            no=GroupNo;
            studentlimit=_studentLimit;

            
            
        }

        public void AddStudent(Student student)
        {
            if (StudentLimit>Students.Length)
            {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = student;  
            }
            
        }
        public Student[] ShowAllStudent()
        {
            for(int i=0; i<Students.Length; i++)
            {
                Console.WriteLine($"Fullname:{Students[i].FullName}\n" +
                                      $"Groupno:{Students[i].GroupNo}\n" +
                                      $"AvgPoint:{Students[i].AvgPoint}");
                Console.WriteLine("-------------------------------------");
                
            }
            return Students;
        }


       
        public Student[] SearchStudent(string value)
        {
            bool result;

            for (int i = 0; i < Students.Length; i++)
            {
               if ( result = Students[i].FullName.Contains(value))
                {
                    result = true;
                    Console.WriteLine($"Fullname:{Students[i].FullName}\n" +
                                   $"Groupno:{Students[i].GroupNo}\n" +
                                   $"AvgPoint:{Students[i].AvgPoint}");
                    Console.WriteLine("-------------------------------------");
                }
                

            }  
           
            

            return Students;

            
        }



    }
}
