int[] digits = {1, 2, 5, 4, 4, 5, 2, 3, 6, 5};

var result = digits
    .GroupBy(p => p)
    .Select(g => new {name = String.Format("{0}-hello", g.Key), count = g.Count()}).ToDictionary(x => x.name, x => x.count);

foreach (var row in result){
    Console.WriteLine(row);
}