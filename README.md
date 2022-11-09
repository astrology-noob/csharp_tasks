# Домашние (и не только) задания по C#

## linq_hw
Домашнее задание за 07.09.2022

### Решение
```c#
var result = digits
    .GroupBy(p => p)
    .Select(g => new {
        name = String.Format("{0}-hello", g.Key), 
        count = g.Count()
    }).ToDictionary(x => x.name, x => x.count);
```

## tdd_arrays
Задачи на занятии 28.09.2022

### Задача "Найти ближайшее к 10 значение"
```c#
int NearToTen(int[] num_array)
{
    int pad_to_ten = 10 - num_array[0];
    int max_num = num_array[0];
    for (int i = 1; i < num_array.Length; i++)
    {
        if (num_array[i] == 10)
            return num_array[i];

        if (Math.Abs(10 - num_array[i]) < pad_to_ten)
        {
            max_num = num_array[i];
            pad_to_ten = Math.Abs(10 - num_array[i]);
        }
        
        else if (Math.Abs(10 - num_array[i]) == pad_to_ten)
            if (max_num < num_array[i])
                max_num = num_array[i];
    }

    return max_num;
}
```

### Задача "Найти общий префикс (начало строки) у данных в массиве"
```c#
string FindPrefix(string[] str_array)
{
    string prefix = str_array[0];
    for (int i = 1; i < str_array.Length; i++)
    {
        if (prefix[0] != str_array[i][0]) return "";

        for (int j = 1; j < prefix.Length; j++)
        {
            if (prefix[j] != str_array[i][j])
            {
                prefix = prefix.Substring(0, j);
                break;
            }
        }
    }

    return prefix;
}
```

### Задача "Есть ли одинаковые элементы в массиве"
```c#
bool FindSame(int[] num_array)
{
    HashSet<int> num_set = new HashSet<int>();

    for (int i = 0; i < num_array.Length; i++)
    {
        if (num_set.Contains(num_array[i])) continue;
        num_set.Add(num_array[i]);
    }
    
    return num_array.Length != num_set.Count;
}
```

## quiz
Практическая работа с созданием "викторины". Вопросы и ответы хранятся в файле json

### Решение (содержание файла Program.cs)
``` c#
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
```
