using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<int> IncrementAll(List<int> nums)
        {
            return nums.Select(x => x + 1)
                .ToList();
        }

        public static int[] GetWhereDivisibleBy(List<int> nums, int x)
        {
            return nums.Where(y => y % x == 0)
                .ToArray();
        }

        public static bool AnyCapitals(string s)
        {
            return s.Any(c => char.IsUpper(c));
        }

        public static bool AllCapitals(string s)
        {
            return s.All(c => char.IsUpper(c));
        }

        public static int NumPairs(Dictionary<int, string> dict)
        {
            return dict.Count();
        }

        public static int NumPairsWithKeyValue(Dictionary<int, string> dict, int x, int y)
        {
            return dict.Count(z => z.Key > x && z.Value.Length < y);
        }

        public static List<double> GetDistinctWithValue(List<double> nums, int x)
        {
            return nums.Where(num => num < x).Distinct().ToList();
        }

        public static int[] FindFirstArrayWithLength(List<int[]> numsLists, int x)
        {
            return numsLists.FirstOrDefault(nums => nums.Length > x);
        }

        public static int GetLastOddElement(int[] nums)
        {
            return nums.LastOrDefault(x => x % 2 != 0);
        }

        public static int GetMaxStringLength(List<string> strings)
        {
            return strings.Max(s => s.Length);
        }

        public static int GetMinListListValue(List<List<int>> list)
        {
            return list.Min(l => l.Min());
        }

        public static List<int> GetIntElements(List<object> objects)
        {
            return objects.OfType<Int32>().ToList();
        }

        public static List<User> SortUsersByAge(List<User> users)
        {
            return users.OrderByDescending(u => u.Age)
                .ThenBy(u => u.LastName)
                .ToList();
        }

        public static string[] DoubleReverse(List<string> strings)
        {
            return strings.Select(c => new string(c.Reverse().ToArray()))
                .Reverse()
                .ToArray();
        }

        public static int Sum(List<int> nums)
        {
            return nums.Where(x => x > 0).Sum();
        }

        public static double Average(List<string> strings)
        {
            return strings.Average(s => s.Length);
        }

        public static List<int> TakeSkip(List<int> nums, int take=0, int skip=0)
        {
            return nums.Take(take != 0 ? take : nums.Count - skip)
                .ToList();
        }

        //public static List<int> DoAllTheThings(List<int> nums, int max=0, bool sort=true, int top=0)
        //{
        //    var (l = max != 0) ? nums.Select(x => x <= max) : nums;
        //}
    }
}

