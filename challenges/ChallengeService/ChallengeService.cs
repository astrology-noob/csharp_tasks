namespace ChallengeService;
public class ChallengeService
{
    // Задача #1
    // Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.

    public int[] GetArrayOfMultiples(int num, int arrLength)
    {
        if (arrLength <= 0)
            return new int[0];

        int[] multiples = new int[arrLength];
        for (int multiplier = 1; multiplier <= arrLength; multiplier++)
        {
            multiples[multiplier - 1] = num * multiplier;
        }
        return multiples;
    }

    // Задача #2
    // Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

    public string ReverseCase(string str)
    {
        string newStr = string.Empty;
        for (int i = 0; i < str.Length; i++)
            newStr += char.IsUpper(str[i]) ? char.ToLower(str[i]).ToString() : char.ToUpper(str[i]).ToString();

        return newStr;
    }


    // Задача #3
    // In this challenge, you must verify the equality of two different values given the parameters a and b.

    //Both the value and type of the parameters need to be equal. The possible types of the given parameters are: Numbers, Strings, Booleans (false or true)
    //What have you learned so far that will permit you to do two different checks (value and type) with a single statement?

    //Implement a function that returns true if the parameters are equal, and false if they are not.

    public bool CheckEquality(object a, object b)
    {
        return a.Equals(b);
    }

    // Задача #4
    // Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.
    // Return an empty array if no uppercase letters are found in the string.
    // Special characters($#@%) and numbers will be included in some test cases.
    // Assume all words do not have duplicate letters.

    public int[] IndexOfCapitals(string str)
    {
        List<int> indexes = new();

        for (int i = 0; i < str.Length; i++)
            if (char.IsUpper(str[i]))
                indexes.Add(i);

        return indexes.ToArray<int>();
    }

    // Задача #5
    // Consider the following operation on an arbitrary positive integer:

    //If n is even -> n / 2
    //If n is odd -> n * 3 + 1
    //Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.

    //See the following example, using 10 as the input, with 6 steps:

    //10 is even - 10 / 2 = 5
    //5 is odd - 5 * 3 + 1 = 16
    //16 is even - 16 / 2 = 8
    //8 is even - 8 / 2 = 4
    //4 is even - 4 / 2 = 2
    //2 is even - 2 / 2 = 1->Reached 1, so return 6

    public int SolveCollatz(int num)
    {
        if (num <= 0)
            return 0;

        int count = 0;

        while (num != 1)
        {
            num = num % 2 == 0 ? num / 2 : num * 3 + 1;
            count++;
        }

        return count;
    }

    // Задача #6
    // Create a function that returns true if a number is a palindrome.
    // A palindrome is a number that remains the same when reversed.
    // Bonus: Try solving this without turning the number into a string.

    public bool IsPalindrom(int num)
    {
        int num1 = num;
        int num2 = 0;

        while (num != 0)
        {
            num2 = num2 * 10 + num % 10;
            num /= 10;
        }

        return num2 == num1;
    }

    // Задача #7
    // An isogram is a word that has no duplicate letters. Create a function that takes a string and returns either true or false depending on whether or not it's an "isogram".

    public bool IsIsogram(string str)
    {
        return str.Length == str.ToLower().Distinct().Count();
    }

    // Задача #8
    // Write a function that takes in a string and for each character, returns the distance to the nearest vowel in the string. If the character is a vowel itself, return 0.
    // All input strings will contain at least one vowel.
    // Strings will be lowercased.
    // Vowels are: a, e, i, o, u

    public int[] CountDistanceToNearestVowel(string str)
    {
        int[] distances = new int[str.Length];
        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
        List<int> vow_indexes = new List<int>();
        List<int> let_distances = new List<int>();

        for (int char_ind = 0; char_ind < str.Length; char_ind++)
        {
            if (vowels.Contains(str[char_ind]))
                vow_indexes.Add(char_ind);
            else
                distances[char_ind] = -1;
        }

        for (int char_ind = 0; char_ind < str.Length; char_ind++)
        {
            if (distances[char_ind] != 0)
            {
                for (int vow_ind = 0; vow_ind < vow_indexes.Count(); vow_ind++)
                {
                    let_distances.Add(Math.Abs(vow_indexes[vow_ind] - char_ind));
                }

                distances[char_ind] = let_distances.Min();
                let_distances.Clear();
            }
        }

        return distances;
    }


    // Задача #9
    // Write a function that calculates overtime and pay associated with overtime.

    // Working 9 to 5: regular hours
    // After 5pm is overtime
    // Your function gets an array with 4 values:

    // Start of working day, in decimal format, (24 - hour day notation)
    // End of working day. (Same format)
    // Hourly rate
    // Overtime multiplier

    // Your function should spit out:

    // $ + earned that day(rounded to the nearest hundreth)
    // OverTime([16, 18, 30, 1.8]) ➞ "$84.00"
    // From 16 to 17 is regular, so 1 * 30 = 30
    // From 17 to 18 is overtime, so 1 * 30 * 1.8 = 54
    // 30 + 54 = $84.00

    public string CountRevenueOverTime(double[] workDayParams)
    {
        double sum = workDayParams[1] <= 17 ?
            (workDayParams[1] - workDayParams[0]) * workDayParams[2] :
            workDayParams[0] < 17 ?
            (17 - workDayParams[0]) * workDayParams[2] + (workDayParams[1] - 17) * workDayParams[2] * workDayParams[3] :
            (workDayParams[1] - workDayParams[0]) * workDayParams[2] * workDayParams[3];
        return $"${sum:0.00}";

    }


    // Задача #10
    // A robot moves around a 2D grid. At the start, it is at [0, 0], facing east.It is controlled by a sequence of instructions:

    // . means take one step forwards in the current direction.
    // < means turn 90 degrees anticlockwise.
    // > means turn 90 degrees clockwise.
    // Your job is to process the instructions and return the final position of the robot.

    // For example, if the robot is given the sequence of instructions ..<.<., then:

    // Step 1: . It still faces east, and is at [1, 0].
    // Step 2: . It still faces east, and is at [2, 0].
    // Step 3: < It now faces north, and is still at [2, 0].
    // Step 4: . It still faces north, and is at [2, 1].
    // Step 5: < It now faces west, and is still at [2, 1].
    // Step 6: . It still faces west, and is now at [1, 1].
    // So, TrackRobot("..<.<.") returns[1, 1].

    // The instruction strings will only contain the three valid characters ., < or >.
    // You will always be passed a string (but the string might be empty).


    public int[] TrackRobot(string steps)
    {
        int[] position = new int[2] { 0, 0 };

        if (steps.Length == 0)
            return position;

        // east - 0, south - 1, west - 2, north - 3 clockwise
        int direction = 0;

        foreach (char sym in steps)
        {
            if (sym == '.')
            {
                if ((direction + 4) % 4 == 0) position[0]++;
                else if ((direction + 4) % 4 == 1) position[1]--;
                else if ((direction + 4) % 4 == 2) position[0]--;
                else position[1]++;
            }

            else if (sym == '<')
                direction = direction == 0 ? 3 : direction - 1;
            else
                direction = direction == 3 ? 0 : direction + 1;
        }

        return position;
    }
}
