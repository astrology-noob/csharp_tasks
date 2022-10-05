namespace quiz
{
    internal class Answer
    {
        public string text { get; set; }
        public bool isCorrect { get; set; }

        public Answer(string text, bool isCorrect) 
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
    }
}
