namespace ChallengeService.Tests;

public class ChService_ChallengesShould
{
    private readonly ChallengeService challengeService;

    public ChService_ChallengesShould()
    {
        challengeService = new ChallengeService();
    }

    // Задача #1
    [Theory]
    [InlineData(1, 1)]
    [InlineData(-3, 5)]
    [InlineData(7, 6)]
    public void GetArrayOfMultiples_PositiveLength_ReturnArray(int num, int length)
    {
        int[] result = challengeService.GetArrayOfMultiples(num, length);

        Assert.True(result.Length == length && result[result.Length - 1] == num * length, $"В массиве {length} элементов и последний элемент равен {num * length}");
    }

    [Theory]
    [InlineData(1, -1)]
    [InlineData(3, 0)]
    public void GetArrayOfMultiples_NegativeOrZeroLength_ReturnEmptyArray(int num, int length)
    {
        int[] result = challengeService.GetArrayOfMultiples(num, length);

        Assert.True(result.Length == 0, "Неподходящие входные данные");
    }

    // Задача #2
    [Theory]
    [InlineData("Happy Birthday", "hAPPY bIRTHDAY")]
    [InlineData("MANY THANKS", "many thanks")]
    [InlineData("sPoNtAnEoUs", "SpOnTaNeOuS")]
    public void ReverseCase_StringsWithOnlyLetters(string inputString, string expectedResult)
    {
        Assert.Equal(challengeService.ReverseCase(inputString), expectedResult);
    }

    [Theory]
    [InlineData("Hap3py Bi1rthday", "hAP3PY bI1RTHDAY")]
    [InlineData("MANY THANK(S)", "many thank(s)")]
    [InlineData("sP--1oNtAnEoUs", "Sp--1OnTaNeOuS")]
    public void ReverseCase_StringsWithScpecSymbolsAndNumbers(string inputString, string expectedResult)
    {
        Assert.Equal(challengeService.ReverseCase(inputString), expectedResult);
    }

    // Задача #3
    [Theory]
    [InlineData("1", "1")]
    [InlineData(1, 1)]
    public void CheckEquality_EqualObjects(object a, object b)
    {
        Assert.True(challengeService.CheckEquality(a, b));
    }

    [Theory]
    [InlineData("1", "4")]
    [InlineData(1, "1")]
    public void CheckEquality_DifferentObjects(object a, object b)
    {
        Assert.False(challengeService.CheckEquality(a, b));
    }

    // Задача #4
    [Theory]
    [InlineData("eEe", new int[1] { 1 })]
    [InlineData("eDaBiT", new int[3] { 1, 3, 5 })]
    public void IndexOfCapitals_CapitalsPresent(string inputString, int[] expectedArray)
    {
        Assert.Equal(challengeService.IndexOfCapitals(inputString), expectedArray);
    }

    [Theory]
    [InlineData("eee", new int[0])]
    [InlineData("", new int[0])]
    public void IndexOfCapitals_NoCapitals(string inputString, int[] expectedArray)
    {
        Assert.Equal(challengeService.IndexOfCapitals(inputString), expectedArray);
    }


    // Задача #5
    [Theory]
    [InlineData(10, 6)]
    [InlineData(72, 22)]
    public void SolveCollatz_PositiveInput(int inputNum, int result)
    {
        Assert.Equal(challengeService.SolveCollatz(inputNum), result);
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(0)]
    public void SolveCollatz_NonPositiveInput(int inputNum)
    {
        Assert.True(challengeService.SolveCollatz(inputNum) == 0);
    }


    // Задача #6
    [Theory]
    [InlineData(335533)]
    [InlineData(9000009)]
    public void IsPalindrom_Palindrom(int inputNum)
    {
        Assert.True(challengeService.IsPalindrom(inputNum));
    }

    [Theory]
    [InlineData(1234)]
    [InlineData(3002)]
    public void IsPalindrom_NotPalindrom(int inputNum)
    {
        Assert.False(challengeService.IsPalindrom(inputNum));
    }


    // Задача #7
    [Theory]
    [InlineData("Algorism")]
    public void IsIsogram_Isogram(string inputString)
    {
        Assert.True(challengeService.IsIsogram(inputString));
    }

    [Theory]
    [InlineData("PasSword")]
    [InlineData("Consecutive")]
    public void IsIsogram_NotIsogram(string inputString)
    {
        Assert.False(challengeService.IsIsogram(inputString));
    }


    // Задача #8
    [Theory]
    [InlineData("totally", new int[] { 1, 0, 1, 0, 1, 2, 3 })]
    [InlineData("singingintherain", new int[] { 1, 0, 1, 1, 0, 1, 1, 0, 1, 2, 1, 0, 1, 0, 0, 1 })]
    public void CountDistanceToNearestVowel_WithConstonants(string inputString, int[] result)
    {
        Assert.Equal(challengeService.CountDistanceToNearestVowel(inputString), result);
    }

    [Theory]
    [InlineData("aaaaa", new int[] { 0, 0, 0, 0, 0 })]
    public void CountDistanceToNearestVowel_OnlyVowels(string inputString, int[] result)
    {
        Assert.Equal(challengeService.CountDistanceToNearestVowel(inputString), result);
    }


    // Задача #9
    [Theory]
    [InlineData(new double[] { 9, 17, 30, 1.5 }, "$240,00")]
    [InlineData(new double[] { 10.5, 17, 32.25, 1.5 }, "$209,63")]
    public void CountRevenueOverTime_WithoutOverTime(double[] workDayParams, string result)
    {
        Assert.Equal(challengeService.CountRevenueOverTime(workDayParams), result);
    }

    [Theory]
    [InlineData(new double[] { 13, 21, 38.6, 1.8 }, "$432,32")]
    [InlineData(new double[] { 16, 18, 30, 1.8 }, "$84,00")]
    public void CountRevenueOverTime_WithOverTime(double[] workDayParams, string result)
    {
        Assert.Equal(challengeService.CountRevenueOverTime(workDayParams), result);
    }

    [Theory]
    [InlineData(new double[] { 18, 20, 32.5, 2 }, "$130,00")]
    public void CountRevenueOverTime_OnlyOverTime(double[] workDayParams, string result)
    {
        Assert.Equal(challengeService.CountRevenueOverTime(workDayParams), result);
    }


    // Задача #10
    [Theory]
    [InlineData("..<.<.", new int[] { 1, 1 })]
    [InlineData(".<..<...<....<.....<......", new int[] { 3, 4 })]
    [InlineData(">>..", new int[] { -2, 0 })]
    public void TrackRobot_NormalInstructions(string steps, int[] result)
    {
        Assert.Equal(challengeService.TrackRobot(steps), result);
    }

    [Theory]
    [InlineData("..................................................", new int[] { 50, 0 })]
    public void TrackRobot_OnlyWalking(string steps, int[] result)
    {
        Assert.Equal(challengeService.TrackRobot(steps), result);
    }

    [Theory]
    [InlineData("<>>>><><<<><>>>><><<<><>>><>", new int[] { 0, 0 })]
    public void TrackRobot_OnlyRotation(string steps, int[] result)
    {
        Assert.Equal(challengeService.TrackRobot(steps), result);
    }
}