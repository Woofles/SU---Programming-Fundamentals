using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        //const char Search = 'р';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;
                //
                int length = jump;

                if (i >= text.Length - length)
                {
                    length = text.Length - i - 1;
                }
                //
                string matchedString = text.Substring(i, length +1);
                Console.WriteLine(matchedString);
                i += length;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
