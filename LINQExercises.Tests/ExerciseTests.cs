using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercises.Tests
{
    [TestClass]
    public class ExerciseTests
    {
        [TestMethod]
        public void TestIncrementAll()
        {
            var expected = new List<int> { 2, 3, 4 };
            var results = Program.IncrementAll(new List<int> { 1, 2, 3 });
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestGetWhereDivisibleBy()
        {
            var expected = new int[] { 2, 4, 6 };
            var results = Program.GetWhereDivisibleBy(new List<int> { 2, 3, 4, 5, 6 }, 2);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAnyCapitals()
        {
            var expected = true;
            var results = Program.AnyCapitals("Hello");
            Assert.AreEqual(expected, results);

            expected = false;
            results = Program.AnyCapitals("hello");
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAllCapitals()
        {
            var expected = true;
            var results = Program.AllCapitals("HELLO");
            Assert.AreEqual(expected, results);

            expected = false;
            results = Program.AllCapitals("HelLo");
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestNumPairs()
        {
            var expected = 3;
            var dict = new Dictionary<int, string>();
            dict.Add(1, "a");
            dict.Add(2, "b");
            dict.Add(3, "c");
            var results = Program.NumPairs(dict);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestNumPairsWithKeyValue()
        {
            var expected = 1;
            var dict = new Dictionary<int, string>();
            dict.Add(5, "e");
            dict.Add(1, "absolute");
            int x = 3;
            int y = 5;
            var results = Program.NumPairsWithKeyValue(dict, x, y);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestGetDistinctWithValue()
        {
            var expected = new List<double> { 1.5, 2.5 };
            var results = Program.GetDistinctWithValue(new List<double> { 1.5, 1.5, 2.5, 3.5 }, 3);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestFindFirstArrayWithLength()
        {
            var expected = new int[] { 1, 2, 3};
            var intArray = new int[] { 1 };
            var intArray2 = new int[] { 1, 2, 3 };
            var numsList = new List<int[]>();
            numsList.Add(intArray);
            numsList.Add(intArray2);
            var results = Program.FindFirstArrayWithLength(numsList, 2);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestGetLastOddElement()
        {
            var expected = 5;
            var results = Program.GetLastOddElement(new int[] { 2, 4, 6, 7, 5 });
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestGetMaxStringLength()
        {
            var expected = 5;
            var list = new List<string>();
            list.Add("hello");
            list.Add("e");
            list.Add("wah");
            var results = Program.GetMaxStringLength(list);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestGetMinListListValue()
        {
            var expected = 3;
            var inner = new List<int>();
            inner.Add(4);
            inner.Add(5);
            inner.Add(3);
            var inner2 = new List<int>();
            inner2.Add(7);
            inner2.Add(4);
            var list = new List<List<int>>();
            list.Add(inner);
            list.Add(inner2);
            var results = Program.GetMinListListValue(list);
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestGetIntElements()
        {
            var expected = new List<int> { 1, 2, 3 };
            var results = Program.GetIntElements(new List<object> { 1, "s", 'v', 2, 3 });
            CollectionAssert.AreEqual(expected, results);
            
        }

        [TestMethod]
        public void TestSortUsersByAge()
        {
            var user = new User("John", "Doe", 22);
            var user2 = new User("Jane", "Austen", 22);
            var user3 = new User("Hello", "World", 2);
            var expected = new List<User> { user2, user, user3 };
            var results = Program.SortUsersByAge(new List<User> { user, user2, user3 });
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestDoubleReverse()
        {
            var expected = new string[] { "dlrow", "olleh" };
            var results = Program.DoubleReverse(new List<string> { "hello", "world" });
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestSum()
        {
            var expected = 5;
            var results = Program.Sum(new List<int> { 1, 3, -1, 1, -2 });
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAveage()
        {
            var expected = 3.5;
            var results = Program.Average(new List<string> { "hi", "hello" });
            Assert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestTakeSkip()
        {
            var expected = 3;
            var results = Program.TakeSkip(new List<int> { 1, 2, 3, 4, 5 }, 3);
            Assert.AreEqual(expected, results.Count);
            expected = 2;
            results = Program.TakeSkip(new List<int> { 1, 2, 3, 4, 5 }, skip:3);
            Assert.AreEqual(expected, results.Count);
        }
    }
}
