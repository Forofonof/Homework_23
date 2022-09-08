using System;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9, 9, 9, 9, 9, 9, 11, 12, 13, 14, 15, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        int repeatNumber = 0;
        int repetitionNumber = 0;
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]} ");
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                counter++;
            }
            else if (repetitionNumber < counter)
            {
                repetitionNumber = counter;
                repeatNumber = array[i - 1];
            }
        }
        Console.WriteLine($"Число {repeatNumber} повторяется больше всего раз. Количество повторений: {repetitionNumber}");
    }
}