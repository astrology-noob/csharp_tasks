namespace quiz
{
    internal class Question
    {
        public string text { get; set; }
        public List<Answer> answers { get; set; }

        public Question(string text, List<Answer> answers)
        {
            this.text = text;
            this.answers = answers;
        }
    }
}
