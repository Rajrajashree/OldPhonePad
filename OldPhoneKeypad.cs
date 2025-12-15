using System;
using System.Collections.Generic;
using System.Text;
using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Test cases from the challenge
//         Console.WriteLine(OldPhoneKeypad.OldPhonePad("33#"));               
//         Console.WriteLine(OldPhoneKeypad.OldPhonePad("227*#"));             
//         Console.WriteLine(OldPhoneKeypad.OldPhonePad("4433555 555666#"));   
//         Console.WriteLine(OldPhoneKeypad.OldPhonePad("8 88777444666*664#"));

//         Console.ReadLine(); // keeps console open
//     }
// }


public class OldPhoneKeypad
{
    private static readonly Dictionary<char, string> Keypad = new Dictionary<char, string>
    {
        {'2', "ABC"},
        {'3', "DEF"},
        {'4', "GHI"},
        {'5', "JKL"},
        {'6', "MNO"},
        {'7', "PQRS"},
        {'8', "TUV"},
        {'9', "WXYZ"}
    };

    public static string OldPhonePad(string input)
    {
        StringBuilder result = new StringBuilder();
        char lastChar = '\0';
        int count = 0;

        foreach (char c in input)
        {
            if (c == '#')
            {
                AppendCharacter(result, lastChar, count);
                break;
            }

            if (c == '*')
            {
                if (result.Length > 0)
                    result.Remove(result.Length - 1, 1);
                lastChar = '\0';
                count = 0;
            }
            else if (c == ' ')
            {
                AppendCharacter(result, lastChar, count);
                lastChar = '\0';
                count = 0;
            }
            else
            {
                if (c == lastChar)
                {
                    count++;
                }
                else
                {
                    AppendCharacter(result, lastChar, count);
                    lastChar = c;
                    count = 1;
                }
            }
        }

        return result.ToString();
    }

    private static void AppendCharacter(StringBuilder result, char digit, int count)
    {
        if (Keypad.ContainsKey(digit) && count > 0)
        {
            string letters = Keypad[digit];
            int index = (count - 1) % letters.Length;
            result.Append(letters[index]);
        }
    }
}

