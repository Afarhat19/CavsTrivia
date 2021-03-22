using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CavsTrivia.Models
{
    public class Question
    {
        //Each question needs 4 options and an answer 
        public int questionID { get; set; }
        public string question { get; set; }
        public string Option1 { get; set; }

        public string Option2 { get; set; }

        public string Option3 { get; set; }
        public string Option4 { get; set; }

        public int CorrectOption { get; set; }


        public Question(int id, string question, string option1, string option2, string option3, string option4, int correctOption)
        {
            questionID = id;
            this.question = question;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
        }

        public Question()
        {

        }
    }
}
