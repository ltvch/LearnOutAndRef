sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOutAndRef
{
    public class Program
    {
        private int tmp;

        private int outA, outB;
        public static int testA, testB;
        int a = 1;
        int b = 2;

        /// <summary>
        /// Swap values use 4 parameters where 2 like temp variable
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        /// <param name="c">Mirror for one</param>
        /// <param name="d">Mirror for two</param>
        public static void Swap0(int a, int b, int c, int d)
        {
            c = a;
            d = b;
            a = d;
            b = c;

            ///only for test set local variale value  to "outdoor" variable
            testA = default(int);
            testB = default(int);
            testA = a;
            testB = b;
        }

        /// <summary>
        /// Swap values in 2 inserted parameters
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        public static void Swap1(int a, int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;

            ///only for test set local variale value  to "outdoor" variable
            testA = a;
            testB = b;
        }

        /// <summary>
        /// Swap values use 2 inserted and two out outdoor paremeters 
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        /// <param name="outA">out reverse first so it is second</param>
        /// <param name="outB">out reverse second so it is first</param>
        public static void Swap2(int a, int b, out int outA, out int outB)
        {
            outB = a;
            outA = b;

            ///only for test set local variale value  to "outdoor" variable
            testA = default(int);
            testB = default(int);
            testA = outA;
            testB = outB;
        }

        /// <summary>
        /// Swap values use 2 parameters as outdoor link
        /// </summary>
        /// <param name="outA">First</param>
        /// <param name="outB">Second</param>
        public static void Swap3(ref int outA, ref int outB)
        {
            int tmp;
            tmp = outA;
            outA = outB;
            outB = tmp;

            ///only for test set local variale value  to "outdoor" variable
            testA = default(int);
            testB = default(int);
            testA = outA;
            testB = outB;
        }

        /// <summary>
        /// Swap value use 2 value and one refrence parameters
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        /// <param name="temp">Temp parameter is like a link</param>
        public static void Swap4(int a, int b, ref int temp)
        {
            temp = default(int);
            temp = a;
            a = b;
            b = temp;

            ///only for test set local variale value  to "outdoor" variable
            testA = default(int);
            testB = default(int);
            testA = a;
            testB = b;
        }

        /// <summary>
        /// Swap use 3 refrence parameter
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        /// <param name="temp">Temptachure paremeter</param>
        public static void Swap5(ref int a, ref int b, ref int temp)
        {
            temp = a;
            a = b;
            b = temp;

            ///only for test set local variale value  to "outdoor" variable
            testA = default(int);
            testB = default(int);
            testA = a;
            testB = b;
        }

        /// <summary>
        /// Swap use tuple
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        /// <returns>reverce parameters inside result container</returns>
        public static Tuple<int, int> Swap6(int a, int b) =>
            new Tuple<int, int>(b, a);

        /// <summary>
        /// Swap use special containter like dictionary
        /// </summary>
        /// <param name="a">First</param>
        /// <param name="b">Second</param>
        /// <returns>reverse paremeters inside result container</returns>
        public static KeyValuePair<int, int> Swap7(int a, int b) =>
            new KeyValuePair<int, int>(b, a);

        /// <summary>
        /// Swap use param key for parameter like array of int
        /// </summary>
        /// <param name="array">Container for undefinite count of value -> parameters</param>
        /// <returns></returns>
        public static int[] Swap8(params int[] array)
        {
            int temp;
            temp = array[0];
            array[0] = array[1];
            array[1] = temp;
            return array;
        }
        /// <summary>
        /// return a = a ^ b ^ (b = a);
        /// </summary>
        /// <param name="a"></param>
        public static int Swap9_1(int a)
        {
            //return a = a ^ b ^ (b = a);
            return a;
        }


        static void Main(string[] args)
        {
            int one = 1;
            int two = 2;
            int temp = default(int);
            int o1, o2;

            // Swap4(one, two, ref temp);
            // Swap2(one, two, out o1, out o2);
           //Swap5(ref one, ref two, ref temp);
        }
    }
}
