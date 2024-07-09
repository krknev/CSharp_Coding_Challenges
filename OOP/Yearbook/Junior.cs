using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yearbook
{
    public class Junior(string firstName, string lastName, int grade, string photo) : Student(firstName, lastName, grade, photo)
    {
        // ToDo fix value to be grade/photo from ctor or if is const remove it from ctor of the Junior
        public int grade = 11;
        public string photo = "class photo";

        public override string ToString()
        {
            return $"{lastName},{firstName}, {grade}, {photo}";
        }
    }
}
