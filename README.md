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
