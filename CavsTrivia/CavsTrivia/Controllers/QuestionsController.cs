using CavsTrivia.DAO;
using CavsTrivia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CavsTrivia.Controllers
{
    [Route("questions")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private IQuestionDAO questionDAO;

        public QuestionsController(IQuestionDAO questiondao)
        {
            this.questionDAO = questiondao;
        }

        [HttpGet]
        public List<Question> GetQuestions()
        {
            return questionDAO.GetQuestions();
        }
    }
}
