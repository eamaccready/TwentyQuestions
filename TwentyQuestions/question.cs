﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyQuestions
{
    class Question
    {
        public string question;
        public Question yes; //left
        public Question no;  //right

        //Constructor here?

        public bool isleaf()
        {
            return yes == null || no == null;
        }
    }
}
