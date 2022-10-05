using System.Text.Json;
using quiz;

string fileName = "C:\\Users\\Мелания\\Documents\\csharp_tasks\\quiz\\questions_answers.json";

string json = File.ReadAllText(fileName, System.Text.Encoding.UTF8);

Questions questions = JsonSerializer.Deserialize<Questions>(json);


float correct = 0;
float all = questions.questions.Count;


foreach (Question question in questions.questions)
{
    Console.WriteLine(question.text);
    
    foreach (Answer answer in question.answers)
        Console.WriteLine(answer.text);

    Console.Write("Введите номер правильного ответа (1 или 2): ");
    
    int userAnswer = int.Parse(Console.ReadLine());
    
    if (question.answers[userAnswer - 1].isCorrect)
        correct++;

    Console.Clear();
}

Console.WriteLine(string.Format("Вы правильно ответили на {0}% вопросов", (correct / all) * 100));