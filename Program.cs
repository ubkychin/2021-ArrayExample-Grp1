using System;
using System.Collections.Generic;

namespace ArrayExample_Grp1
{
    class Program
    {
        static void Main(string[] args) {
            
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(40);
            numbers.Add(50);
            numbers.Add(70);
            numbers.Add(10);
            numbers.Add(40);

            int total = 0;

            // int index = 0;
            // while (index < numbers.Count) {
            //     System.Console.WriteLine(index + " | " + numbers[index]);
                
            //     total += numbers[index];

            //     index++;
            // }

            numbers.Sort();


            for (int index = 0; index < numbers.Count; index++) {
                System.Console.WriteLine(index + " | " + numbers[index]);
                
                total += numbers[index];
            }

    
            Console.WriteLine(total);
        }
    }
}
