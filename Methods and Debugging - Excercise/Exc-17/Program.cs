﻿using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] inputArray = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();
        long[] array = inputArray.Take(sizeOfArray).ToArray(); // reducing the input to sizeOfArray number of elements
        //
        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(stringParams[0]);
                args[1] = int.Parse(stringParams[1]);

                PerformAction(array, command, args);
            }

            PerformAction(array, command, args);

            PrintArray(array);

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
            array[pos] *= value;
            break;
            case "add":
            array[pos] += value;
            break;
            case "subtract":
            array[pos] -= value;
            break;
            case "lshift":
            ArrayShiftLeft(array);
            break;
            case "rshift":
            ArrayShiftRight(array);
            break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
    }

    private static void ArrayShiftLeft(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
