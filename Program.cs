using System;
using JsonUtil;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string lname, fname;

            Console.WriteLine("Hello please enter your first name!");
            fname = Console.ReadLine();
            Console.WriteLine("Hello please enter your last name!");
            lname = Console.ReadLine();

            Console.WriteLine("What month in number form was you born!");
            int month = 0;
            while (true)
            {
                String digits = Console.ReadLine();
                if (digits.Length <= 2 && Int32.TryParse(digits, out month))
                {
                    if (month <= 12)
                    {
                        break;
                    }
                }
                Console.WriteLine("Error invalid number entry");
            }

            Console.WriteLine("Your Pirate Name:");
            Generator gen = new Generator();

            Console.WriteLine(gen.PirateName(fname, lname, month));
        }
    }

    class Generator
    {
        protected char fChar, lChar;

        protected JsonUtil.Item item;
        public string PirateName(string first, string last, int month)
        {
            // JsonUtil.Item item = new JsonUtil.Item{};
            var jsonUt = new JsonUtil.Util();
            item = jsonUt.LoadJson();

            fChar = first[0];
            lChar = last[0];

            int fIndex = char.ToUpper(fChar) - 64;
            int lIndex = char.ToUpper(lChar) - 64;

            string str1 = item.FirstName[fIndex - 1].ToString();
            string str2 = item.LastName[lIndex - 1].ToString();
            string str3 = item.Month[month - 1].ToString();

            return str1 + " " + str2 + " " + str3;
        }
    }
}
