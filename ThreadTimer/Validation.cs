using System;

namespace ThreadTimer
{
    class Validation
    {
        public static string ChooseValidation()
        {
            Console.WriteLine("Me work in for cicly");
            Console.WriteLine("Please input how thread 1 or 2");
            string choose = Console.ReadLine();
            while (choose != "1" && choose != "2")
            {
                Console.WriteLine("input valid number");
            }
            return choose;
        }
    }
}
