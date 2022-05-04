using System.Text;

/// <summary>
/// Возвращает отфильтрованный список строк с максимальной длиной <see cref="maxLength"/>.
/// </summary>
/// <param name="array">Исходных массив строк.</param>
/// <param name="maxLength">Ограничение по размеру стркои для фильтрации.</param>
string[] FilterByMaxLength(string[] array, int maxLength = 3)
{
    var filteredArray = new string[] {};

    foreach (var item in array)
    {
        if (item.Length <= maxLength)
        {
            filteredArray = filteredArray.Append(item)
                                         .ToArray();
        }
    }

    return filteredArray;
}

/// <summary>
/// Возвращает строку из элементов массива <paramref name="array"/>.
/// </summary>
string GetStringArray(string[] array)
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join(", ", array)
                 .Trim();
}

var example = new string[] 
//{ "hello", "2", "world", ":-)" };
// { "1234", "1567", "-2", "computer science" };
 { "Russia", "Denmark", "Kazan" };

var inputArrStr = GetStringArray(example);
var filteredArray = FilterByMaxLength(example);
var filteredArrStr = GetStringArray(filteredArray);

Console.WriteLine($"[{inputArrStr}] -> [{filteredArrStr}]");