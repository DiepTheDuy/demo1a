using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1a
{
    public class Student
    {
        public string StudentID{ get; set; }
        public string FullName{ get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }

        public Student()
        {
                
        }


        public Student( string id , string name , DateTime dtbirthday , string add)
        {
            StudentID = id;
            FullName = name;
            Birthday = dtbirthday;
            Address = add;
        }

    }
}
