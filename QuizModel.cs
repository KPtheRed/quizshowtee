namespace Quizproject
{
    public class QuizModel
    {
        public String question { get; set; }
        public String questionName { get; set; }

        public List<Answer> answers { get; set; }
    }

    public class Answer
    {
        public string answer { get; set; }
        public bool isRightAns { get; set; }
    }

    public class QuestionVIewModel
    { 
        public QuizModel qone { get; set; }
        public QuizModel qtwo { get; set; }
        public QuizModel qthree { get; set; }
        public QuizModel qfour { get; set; }

    }
}
