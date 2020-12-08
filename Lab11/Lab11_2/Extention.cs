using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2
{
    //TASK 1
    static class Extention
    {
        //TASK 5
        public static List<Student> FindStudent(this List<Student> mainList, StudentPredicateDelegate del)
        {
            //TASK 6
            List<Student> temp = new List<Student>();

            foreach(Student i in mainList)
            {
                if (del(i))
                {
                    temp.Add(i);
                }
            }

            return temp;
        }
    }
}
