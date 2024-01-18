using System;

class ArrayManipulation
{
    static void Main()
    {
        // 1. Initialize an array (you can choose the size)
        int[] numbers = new int[10];

        // 2. Populate the array with random integer values
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }

        // 3. Display the array
        Console.WriteLine("Original Array:");
        DisplayArray(numbers);

        // 4. Find the Sum
        int sum = CalculateSum(numbers);
        Console.WriteLine($"Sum of the array: {sum}");

        // 5. Find the Average
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Average of the array: {average}");

        // 6. Find the Maximum and Minimum
        FindMinMax(numbers);

        // 7. Search for an Element
        Console.Write("Enter an integer to search in the array: ");
        int searchNumber = Convert.ToInt32(Console.ReadLine());
        SearchElement(numbers, searchNumber);

        // 8. Sort the Array
        Array.Sort(numbers);
        Console.WriteLine("Sorted Array:");
        DisplayArray(numbers);
    }

    // Helper method to display the array
    static void DisplayArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Helper method to calculate the sum of elements in the array
    static int CalculateSum(int[] arr)
    {
        int sum = 0;
        foreach (var num in arr)
        {
            sum += num;
        }
        return sum;
    }

    // Helper method to calculate the average of elements in the array
    static double CalculateAverage(int[] arr)
    {
        int sum = CalculateSum(arr);
        return (double)sum / arr.Length;
    }

    // Helper method to find and display the minimum and maximum values in the array
    static void FindMinMax(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];

        foreach (var num in arr)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"Minimum value in the array: {min}");
        Console.WriteLine($"Maximum value in the array: {max}");
    }

    // Helper method to search for an element in the array
    static void SearchElement(int[] arr, int searchNumber)
    {
        bool found = false;
        foreach (var num in arr)
        {
            if (num == searchNumber)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"{searchNumber} is present in the array.");
        }
        else
        {
            Console.WriteLine($"{searchNumber} is not present in the array.");
        }
    }
}
m /rbs88/ArrayManipulation.git