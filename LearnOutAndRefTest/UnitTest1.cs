using LearnOutAndRef;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

/// <summary>
/// Used MS Test's
/// </summary>
namespace LearnOutAndRefTest
{
    [TestClass]
    public class UnitTestSwap
    {

        [TestMethod]
        public void TestSwap1()
        {
            //arrange
            int a = 1;
            int b = 2;

            //act
            Program.Swap1(a, b);

            // assert
            Assert.AreEqual(a, Program.testB, "After swap b changed to 1");
            Assert.AreEqual(b, Program.testA, "After swap a changed to 2");

            Assert.AreNotEqual(a, Program.testA, "After swap a not changed and is 1");
            Assert.AreNotEqual(b, Program.testB, "After swap b not changed and is 2");
        }

        [TestMethod]
        public void TestSwap2()
        {
            //arrange
            int a = 1;
            int b = 2;
            int outA,
                outB;

        //act
        Program.Swap2(a, b, out outA, out outB);

            // assert
            Assert.AreEqual(a, outB, "After swap b changed to 1");
            Assert.AreEqual(b, outA, "After swap a changed to 2");

            Assert.AreNotEqual(a, outA, "After swap a not changed and is 1");
            Assert.AreNotEqual(b, outB, "After swap b not changed and is 2");
        }

        [TestMethod]
        public void TestSwap3()
        {
            //arrange
            int a = 1;
            int b = 2;

            int valueA = a;
            int valueB = b;

            //act
            Program.Swap3(ref a, ref b);

            //assert
            Assert.AreEqual(valueA, Program.testB, "After swap b changed to 1");
            Assert.AreEqual(valueB, Program.testA, "After swap a changed to 2");

            Assert.AreNotEqual(valueA, Program.testA, "After swap a not changed and is 1");
            Assert.AreNotEqual(valueB, Program.testB, "After swap b not changed and is 2");
        }

        [TestMethod]
        public void TestSwap4()
        {
            //arrange
            int a = 1;
            int b = 2;
            int temp = default(int);

            //act
            Program.Swap4(a, b, ref temp);

            //assert
            Assert.AreEqual(a, Program.testB, "After swap b changed to 1");
            Assert.AreEqual(b, Program.testA, "After swap a changed to 2");

            Assert.AreNotEqual(a, Program.testA, "After swap a not changed and is 1");
            Assert.AreNotEqual(b, Program.testB, "After swap b not changed and is 2");
        }

        [TestMethod]
        public void TestSwap5()
        {
            //arrange
            int a = 1;
            int b = 2;
            int temp = default(int);

            //act
            Program.Swap5(ref a, ref b, ref temp);

            //assert
            //reverse test becase change on reverce link on paremeter inside function
            Assert.AreEqual(a, Program.testA, $"In method is {Program.testA}");
            Assert.AreEqual(b, Program.testB, $"In method is {Program.testB}");

            Assert.AreNotEqual(a, Program.testB, $"In method is { Program.testB}");
            Assert.AreNotEqual(b, Program.testA, $"In method is { Program.testA}");
        }

        [TestMethod]
        public void TestSwap6()
        {
            //arrange
            int a = 1;
            int b = 2;
            Tuple<int, int> tuple;

            //act
            tuple = Program.Swap6(a, b);

            //assert
            Assert.AreEqual(a, tuple.Item2, $"1 In method is {tuple.Item2}");
            Assert.AreEqual(b, tuple.Item1, $"2 In method is {tuple.Item1}");

            Assert.AreNotEqual(a, tuple.Item1, $"3 In method is {tuple.Item1}");
            Assert.AreNotEqual(b, tuple.Item2, $"4 In method is {tuple.Item2}");
        }

        [TestMethod]
        public void TestSwap7()
        {
            //arrange
            int a = 1;
            int b = 2;
            KeyValuePair<int, int> keyValuePair;

            //act
            keyValuePair = Program.Swap7(a, b);

            //assert
            Assert.AreEqual(a, keyValuePair.Value, $"1 In method is {keyValuePair.Value}");
            Assert.AreEqual(b, keyValuePair.Key, $"2 In method is {keyValuePair.Key}");

            Assert.AreNotEqual(a, keyValuePair.Key, $"3 In method is {keyValuePair.Key}");
            Assert.AreNotEqual(b, keyValuePair.Value, $"4 In method is {keyValuePair.Value}");
        }

        [TestMethod]
        public void TestSwap8()
        {
            //arrange
            int a = 1;
            int b = 2;

            //act
           int[] array = Program.Swap8(a, b);

            //assert
            Assert.AreEqual(a, array[1], $"In method is {array[1]}");
            Assert.AreEqual(b, array[0], $"In method is {array[0]}");

            Assert.AreNotEqual(a, array[0], $"In method is {array[0]}");
            Assert.AreNotEqual(b, array[1], $"In method is {array[1]}");
        }
    }
}
