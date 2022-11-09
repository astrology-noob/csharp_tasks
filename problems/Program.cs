using System.Linq;


static int[] ArrayOfMultiples(int num, int length)
{
    int[] multiples = new int[length];
    for (int i = 1; i <= length; i++)
    {
        multiples[i - 1] = num * i;
    }
    return multiples;
}

//int[] mults = ArrayOfMultiples(17, 6);

//foreach(int mult in mults)
//    Console.Write(mult.ToString() + " ");

static string ReverseCase(string str)
{
    string newStr = string.Empty;
    for (int i = 0; i < str.Length; i++)
        newStr += char.IsUpper(str[i]) ? char.ToLower(str[i]).ToString() : char.ToUpper(str[i]).ToString();

    return newStr;
}

//Console.WriteLine(ReverseCase("KdoIUHynd"));

static bool CheckEquality(object a, object b)
{
    return a.Equals(b);
}

//Console.WriteLine(CheckEquality(1, 1));
//Console.WriteLine(CheckEquality(1, "1"));

static int[] IndexOfCapitals(string str)
{
    List<int> indexes = new();

    for (int i = 0; i < str.Length; i++)
        if (char.IsUpper(str[i]))
            indexes.Add(i);

    return indexes.ToArray<int>();
}

//List<int> indexes = IndexOfCapitals("determine");
//foreach (int index in indexes)
//    Console.WriteLine(index);


static int Collatz(int num)
{
    int count = 0;

    while (num != 1)
    {
        num = num % 2 == 0 ? num / 2 : num * 3 + 1;
        count++;
    }

    return count;
}

//Console.WriteLine(Collatz(1));
//Console.WriteLine(Collatz(2));
//Console.WriteLine(Collatz(3));
//Console.WriteLine(Collatz(10));

static bool isPalindrom(int num)
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

//Console.WriteLine(isPalindrom(838));
//Console.WriteLine(isPalindrom(4433));
//Console.WriteLine(isPalindrom(443344));

static bool isIsogram(string str)
{
    return str.Length == str.ToLower().Distinct().Count();


    //for (int i = 0; i < str.Length - 1; i++)
    //{
    //    for (int j = i + 1; j < str.Length; j++)
    //    {
    //        if (str[i] == str[j])
    //            return false;
    //    }
    //}

    //return true;
}

//Console.WriteLine(isIsogram("Algorism"));
//Console.WriteLine(isIsogram("PasSword"));
//Console.WriteLine(isIsogram("Consecutive"));

static int[] DistanceToNearestVowel(string str)
{
    int[] distances = new int[str.Length];
    char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
    List<int> vow_ind = new List<int>();
    List<int> let_distances = new List<int>();

    for (int i = 0; i < str.Length; i++)
    {
        if (vowels.Contains(str[i]))
            vow_ind.Add(i);
        else 
            distances[i] = -1;
    }

    for (int j = 0; j < str.Length; j++)
    {
        if (distances[j] != 0)
        {
            for (int i = 0; i < vow_ind.Count(); i++)
            {
                let_distances.Add(Math.Abs(vow_ind[i] - j));
            }

            distances[j] = let_distances.Min();
            let_distances.Clear();
        }
    }

    return distances;
}

//int[] dists = DistanceToNearestVowel("a");

//foreach (int dist in dists)
//    Console.Write(dist.ToString() + " ");

static string OverTime(double[] arr)
{
    double sum = arr[1] <= 17 ?
        (arr[1] - arr[0]) * arr[2] :
        arr[0] < 17 ?
        (17 - arr[0]) * arr[2] + (arr[1] - 17) * arr[2] * arr[3]:
        (arr[1] - arr[0]) * arr[2] * arr[3];
    return $"${sum:0.00}";

}

//Console.WriteLine(OverTime(new double[] { 10.5, 17, 32.25, 1.5 }));

static int[] TrackRobot(string steps) {
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

//int[] position = TrackRobot("..>>.");

//Console.WriteLine(position[0].ToString() + " " + position[1].ToString());


// не дорешала
//public class Allergies
//{
//    [Flags]
//    public enum Allergen
//    {
//        Eggs = 1,
//        Peanuts = 2,
//        Shellfish = 4,
//        Strawberries = 8,
//        Tomatoes = 16,
//        Chocolate = 32,
//        Pollen = 64,
//        Cats = 128
//    }

//    // properties
//    string Name { get; }
//    List<Allergen> allergens { get; set; }

//    int Score { 
//        get
//        {
//            return allergens.Select(a => (int) a).Sum();
//        }
//    }

//    // constructors
//    public Allergies(string name)
//    {
//        Name = name;
//    }

//    public Allergies(string name, int score)
//    {
//        Name = name;

//        int temp = score;
//        List<Allergen> tempAllergens = new List<Allergen>();
//        List<Allergen> allergens = Enum.GetValues(typeof(Allergen)).GetEnumerator();
//        while (temp > 0)
//        {
//            for (int i = allergens.Length - 1; i >= 0; i--)
//                if (temp - (int)allergens. > 0)
//                    tempAllergens.Add(allergen);
//        }
//    }

//    public Allergies(string name, string allergens)
//    {

//    }

//    // methods
//    public bool IsAllergicTo(string allergen)
//    {
//        Enum.TryParse(allergen, out Allergen allergen1);
//        return allergens.Contains(allergen1);
//    }

//    public void AddAllergy(string allergen)
//    {
//        Enum.TryParse(allergen, out Allergen allergen1);
//        allergens.Add(allergen1);
//    }

//    public void DeleteAllergy(string allergen)
//    {
//        Enum.TryParse(allergen, out Allergen allergen1);
//        allergens.Remove(allergen1);
//    }

//    public override string ToString()
//    {
//        // add code here to return string representation of this instance
//        return base.ToString();
//    }
//}