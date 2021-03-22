using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CavsTrivia.Models
{
    public class QuestionBank
    {
        public List<Question> ListOfQuestions { get; set; }

        //Question newQuestion = AddQuestionToList(CreateQuestion(1,"What year were the Cleveland Cavaliers founded?", "1970", "1965", "1974", "1972", "1970"));

        public List<Question> AddQuestionToList(Question question1)
        {
           

            question1 = CreateQuestion(1,"What year were the Cleveland Cavaliers founded?", "1970", "1965", "1974", "1972", "1970");

            ListOfQuestions.Add(question1);
            return ListOfQuestions;
        }

        public Question CreateQuestion(int id,string question, string option1, string option2, string option3, string option4, string correctAnswer)
        {
            Question triviaQuestion = new Question();
            triviaQuestion.question = question;
            triviaQuestion.questionID = id;
            triviaQuestion.Option1 = Convert.ToString(option1);
            triviaQuestion.Option2 = Convert.ToString(option2);
            triviaQuestion.Option3 = Convert.ToString(option3);
            triviaQuestion.Option4 = Convert.ToString(option4);
            triviaQuestion.CorrectOption = Convert.ToInt32(correctAnswer);
            return triviaQuestion;
        }

    }
}
