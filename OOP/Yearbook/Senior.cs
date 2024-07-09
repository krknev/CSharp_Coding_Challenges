﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yearbook
{ 
    public class Senior(string firstName, string lastName, int grade, string photo, string seniorquote) : Student(firstName, lastName, grade, photo)
    { // ToDo fix value to be grade/photo/seniorquote from ctor or if is const remove it from ctor
        public int grade = 12;
        public string photo = "senior picture";
        public string seniorquote = seniorquote;

        public override string ToString()
        {
            return $"{lastName},{firstName}, {grade}, {photo} \t '{seniorquote}'";
        }
    }
}
