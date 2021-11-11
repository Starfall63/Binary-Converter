using System;
using System.Text.RegularExpressions;
namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string binary = "";
            
            while (binary == "")
            {
                binary = Console.ReadLine();
                string pattern = "[0-1]+$" ;
                if (Regex.IsMatch(binary, pattern) == false)
                {
                    Console.Write("Please enter a valid binary number: ");
                    binary = "";
                }
            }
            
            
            int start = 1;
            int decimalnumber = 0;
            for (int i = binary.Length-1; i >= 0; i--)
            {
                if(binary[i] == '1')
                {
                    decimalnumber += start;
                }
                start*=2;
            }
            Console.WriteLine("Decimal number: {0}", decimalnumber);
            start = 1;
            string hex = "";
            int temp = 0;
            int pos = binary.Length - 1;
            while (pos>=0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if(pos < 0)
                    {
                        break;
                    }
                    else if(binary[pos] == '1')
                    {
                        temp += start;
                    }
                    start *= 2;
                    pos--;
                }
                
                switch (temp)
                {
                    case 10:
                        hex = ("A" + hex);
                        break;
                    case 11:
                        hex = ("B" + hex);
                        break;
                    case 12:
                        hex = ("C" + hex);
                        break;
                    case 13:
                        hex = ("D" + hex);
                        break;
                    case 14:
                        hex = ("E" + hex);
                        break;
                    case 15:
                        hex = ("F" + hex);
                        break;
                    default:
                        string temp2 = temp.ToString();
                        hex = (temp2 + hex);
                        break;
                        
                }
                start = 1;
                temp = 0;
            }
            Console.Write("Hex: {0}", hex);




        }
    }
}
