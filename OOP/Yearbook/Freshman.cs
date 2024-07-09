using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yearbook
{
    public class Freshman(string firstName, string lastName, int grade, string photo) : Student(firstName, lastName, grade, photo)
    {
        // ToDo fix value to be grade/photo from ctor or if is const remove it from ctor of the Freshman
        public int grade = 9;
        public string photo = "class photo";

        public override string ToString()
        {
            return $"{lastName},{firstName}, {grade}, {photo}";
        }
    }
}
