int NearToTen(int[] num_array)
{
    int pad_to_ten = 10 - num_array[0];
    int max_num = num_array[0];
    for (int i = 1; i < num_array.Length; i++)
    {
        if (num_array[i] == 10)
        {
            return num_array[i];
        }

        if (Math.Abs(10 - num_array[i]) < pad_to_ten)
        {
            max_num = num_array[i];
            pad_to_ten = Math.Abs(10 - num_array[i]);
        }
        else if (Math.Abs(10 - num_array[i]) == pad_to_ten)
        {
            if (max_num < num_array[i])
            {
                max_num = num_array[i];
            }
        }
    }

    return max_num;
}


//int[] numbers = new int[2];

//numbers[0] = 10;
//numbers[1] = 13;

//Console.WriteLine(NearToTen(numbers));


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

//string[] words = new string[3];

//words[0] = "do";
//words[1] = "doggy";
//words[2] = "dogecar";

//Console.WriteLine(FindPrefix(words));



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

int[] numbers = new int[5];

numbers[0] = 10;
numbers[1] = 11;
numbers[2] = 12;
numbers[3] = 13;
numbers[4] = 14;

Console.WriteLine(FindSame(numbers));