using CavsTrivia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CavsTrivia.DAO
{
    public interface IQuestionDAO
    {
        List<Question> GetQuestions();
    }
}
