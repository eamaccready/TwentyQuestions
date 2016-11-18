using System;
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

        //Constructor here!!!! Do Do not call questions or whatever, will cause recursion/stack overflow!

        public Question()
        {
                
        }

        public Question(string newquestion)
        {
            question = newquestion;
            //need to set .yes and .no?    
        }

        public bool isleaf()
        {
            return yes == null || no == null;
        }
    }
}
