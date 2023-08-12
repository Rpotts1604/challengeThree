using System;

namespace challenge3{
    class Program{
        static void FindMinMax(int[] num){
            Array.Sort(num);
            foreach(var item in num) {
                Console.Write(item.ToString() + " "); 
            }
        }

        static void Main(string[] args){
            int[] num = new int[] { 3, 1, 2};
            FindMinMax(num);
            Console.WriteLine("TEST GITHUB");
            Console.WriteLine("TEST 2");
        }
    }
}