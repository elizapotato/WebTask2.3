using System.Collections.Generic;

namespace Web._931803.Chegodaeva.Lab3.Models
{
    public class QuizModel
    {
        public List<string> ListResult { get; set; } = new List<string>();
        public int RightAnswersCount { get; set; } = 0;
        public int AnswersCount { get; set; } = 0;
    }
}
