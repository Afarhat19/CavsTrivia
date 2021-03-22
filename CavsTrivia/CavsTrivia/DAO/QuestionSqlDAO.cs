using CavsTrivia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CavsTrivia.DAO
{
    public class QuestionSqlDAO : IQuestionDAO
    {
        //We want to have a bunch of methods that we call on 
        //actually its pretty much just two methods I think, Asking the question, comparing the response 

        List<Question> ListOfQuestions = new List<Question>();

        private string connectionString;

        public QuestionSqlDAO(string connectionstring)
        {
            this.connectionString = connectionstring;
        }

        public List<Question> GetQuestions()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Questions", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Question newQuestion = new Question();
                    //Convert the json
                    newQuestion.questionID = Convert.ToInt32(reader["question_id"]);
                    newQuestion.question = Convert.ToString(reader["question"]);
                    newQuestion.Option1 = Convert.ToString(reader["option1"]);
                    newQuestion.Option2 = Convert.ToString(reader["option2"]);
                    newQuestion.Option3 = Convert.ToString(reader["option3"]);
                    newQuestion.Option4 = Convert.ToString(reader["option4"]);
                    newQuestion.CorrectOption = Convert.ToInt32(reader["correctAnswer"]);
                    ListOfQuestions.Add(newQuestion);

                }
            }
            return ListOfQuestions;
        }




    }
}
