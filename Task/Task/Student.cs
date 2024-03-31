using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        private double _avgPoint;

        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if(value>=0)
                {
                    _avgPoint = value;
                }
            }
        }
        public Student()
        {
            
        }

        public Student(string fullname)
        {
            FullName = fullname;
        }
        public Student(string fullname,string groupno): this(fullname) 
        {
            GroupNo = groupno;
        }
        public Student(string fullname, string groupno, double avgpoint): this(fullname, groupno)
        {
            _avgPoint=avgpoint;
        }

    }
}
