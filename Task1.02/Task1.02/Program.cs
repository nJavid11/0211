using System;
using System.Linq;
using System.Text;

namespace Task1._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr= {1,2,3,4};   //task1           
            //Console.WriteLine("Sum of the array = "+SumOfAll(arr));

            //task2

            //int[] arr = { 1, 2, 3, 4 };     //task3
            //Console.WriteLine("The result is " + isEqual(arr,12));

            //************** Picture 2 *****************

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };      //task2
            //Array.Reverse(arr);
            //Console.WriteLine("*** Elements of reversed array ***");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[] arr1 = { 3, 5, 1, 4, 2 };     //task3
            //int[] arr2 = { 7, 6, 10, 9, 8 };

            //int[] arr = CopyIt(arr1, arr2);
            //Console.WriteLine("*** The United Array ***");
            //foreach (var elem in arr)
            //{
            //    Console.WriteLine(elem);
            //}

            //int[] arr = { 1, 2, 3, 4, 5 };      //task4
            //Console.WriteLine("Maximum element of the given array = " + arr.Max());
            //Console.WriteLine("Maximum element of the given array = " + arr.Min());

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };      //task5

            //int[] arrEven = EvenArr(arr);
            //Console.WriteLine("*** Elements of the even array ***");
            //foreach (var item in arrEven)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("__________________________________\n");
            //int[] arrOdd = OddArr(arr);
            //Console.WriteLine("*** Elements of the odd array ***");
            //foreach (var item in arrOdd)
            //{
            //    Console.WriteLine(item);
            //}

            //************** Picture 3 *****************
            //string input = "Rasim is a masculine given name of Arabic origin meaning \"planner\", \"architect\".";      //task
            //Console.WriteLine(input.Substring(0, 50)+"...");

            //************** Picture 4 *****************

            //string input = "Hello p121!";       //task1
            //Console.WriteLine("The string you entered is : "+input);

            //string input = "Hello p121!";     //task2
            //Console.WriteLine("Length of the string is : " + CountStr(input));

            //string input = "Hello p121!";       //task3
            //Console.WriteLine("Original string - " + input);
            //Console.WriteLine("Reversed string - " + RevStr(input));

            //string str = "This  is  Code   Academy";        //task4
            //Console.WriteLine("Total number of words in the string is : " + CountWords(str));


        }

        public static int SumOfAll(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //2

        public static bool isEqual(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return true;
            }
            return false;
        }

        //************** Picture 2 *****************
        public static int[] CopyIt(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, arr, arr1.Length);
            Array.Copy(arr2, 0, arr, arr1.Length, arr2.Length);
            Array.Sort(arr);

            return arr;
        }

        public static int[] EvenArr(int[] arr)
        {
            int[] arrEven = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Array.Resize(ref arrEven, arrEven.Length + 1);
                    arrEven[arrEven.Length - 1] = arr[i];
                }

            }
            return arrEven;
        }

        public static int[] OddArr(int[] arr)
        {

            int[] arrOdd = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    Array.Resize(ref arrOdd, arrOdd.Length + 1);
                    arrOdd[arrOdd.Length - 1] = arr[i];
                }
            }
            return arrOdd;
        }

        //************** Picture 3 *****************

        public static int CountStr(string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                count++;
            }
            return count;
        }
        public static string RevStr(string str)
        {
            string reversed = "";
            char[] ch = str.ToCharArray();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed = reversed + ch[i];
            }
            return reversed;
        }

        public static int CountWords(string str)
        {
            int count = 1;
            char[] ch = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (ch[i] == ' ' && ch[i + 1] != ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
