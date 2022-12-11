// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3       

Console.Clear();
Console.Write("Введите числа через пробел: ");
string numbers = Console.ReadLine();
int[] array = GetArrayFromString(numbers);
Console.WriteLine($"Количество чисел больше ноля: {CountPositiveNumbers(array)}");

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
} 

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) count ++;
    }
    return count;
}