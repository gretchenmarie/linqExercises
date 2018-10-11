using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> FruitsL =
            from fruit in fruits
            where fruit.StartsWith("L")
            select fruit;
            foreach (var fruit in fruits)
            { //$"{}" (string) for when you are adding a message otherwise it is just () fruit
                Console.WriteLine($" These are the fruits that start with L {fruit}");


                // Which of the following numbers are multiples of 4 or 6
                List<int> numbers = new List<int>()
                {
                     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                 };

                IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
                foreach (var number in fourSixMultiples)
                {
                    Console.WriteLine(number);
                }


                // Order these student names alphabetically, in descending order (Z to A)
                List<string> names = new List<string>()
               {
               "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
               "Francisco", "Tre"
                 };

                var orderNames =
                from letter in names
                orderby letter
                select letter;
                foreach (var letter in names)
                {
                  Console.WriteLine(letter);
                }


                List<int> numbers2 = new List<int>()
               {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
               };
               var orderNumbers =
                from num in numbers2
                orderby num ascending
                select num;
                foreach (var num in numbers2)
                {
                  Console.WriteLine(num);
                }

                /*
              Store each number in the following List until a perfect square
               is detected.

             Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
              */
             List<int> wheresSquaredo = new List<int>()
             {
               66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
             };
                 var sqrNo = from int Number in wheresSquaredo
                    let SqrNo = Number * Number
                    where SqrNo
                    select new { Number, SqrNo };

    foreach (var sqNo in wheresSquaredo )
    {
        Console.WriteLine();

    }

            }
        }
    }
}
