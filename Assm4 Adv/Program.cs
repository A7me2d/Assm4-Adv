namespace Assm4_Adv
{
    #region Delegates

    public delegate int StringFuncDelegate(string name);
    public delegate bool CheckNum(int A);

    #endregion

    internal class Program
    {
        #region Delegate Use Generics

        //static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list != null)
        //    {
        //        for(int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] %2 !=0)
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //static List<int> FindNumbers(List<int> list, CheckNum reference)
        //{
        //    List<int> Result = new List<int>();
        //    if (list is not null)
        //    {
        //        for(int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        #endregion

        #region Ex03

        static void Main(string[] args)
        {
            //    StringFuncDelegate X = StringsFunction.GetCountUpperChar;
            //    X += StringsFunction.GetCountLowerChar;
            //    int Result = X.Invoke(name: "HEllo");

            //    int[] arr = { 5, 7, 9, 12, 0 };
            //    ConditionFancDelegate RefAsc = SortingFunctions.Gtr;
            //    ConditionFancDelegate RefDes = SortingFunctions.Less;
            //    SortingAlgorithms.BubbleSort(arr, RefDes);

            //    foreach (int i in arr)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine("\n=====================================");
            //    string[] Names = { "Ahmed", "hany", "Omar", "Mariam", "Aya" };
            //    SortingAlgorithms.BubbleSort(Names, SortingFunctions.Gtr);

            //    foreach (string i in Names)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine("\n=====================================");

            //    List<int> list = Enumerable.Range(start: 1, count: 100).ToList();
            //    List<int> OddNumbers = FindNumbers(list, ConditionsFunctions.CheckOdd);
            //    foreach (int i in OddNumbers)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine("\n=====================================");

            //    Predicate<int> predicate = ConditionsFunctions.CheckEven;
            //    Func<int, bool> func = ConditionsFunctions.CheckOdd;
        }

        #endregion
    }

    #region Built-in Delegate

    class StringsFunction
    {
        public static int GetCountUpperChar(string Word)
        {
            //    int Count = 0;
            //    if(!string.IsNullOrEmpty(Word))
            //    {
            //        for(int i = 0; i < Word.Length; i++)
            //        {
            //            if (Char.IsUpper(Word[i]))
            //            {
            //                Count++;
            //            }
            //        }
            //    }
            //    return Count;
            //}

            //public static int GetCountLowerChar(string Word)
            //{
            //    int Count = 0;
            //    if(!string.IsNullOrEmpty(Word))
            //    {
            //        for(int i = 0; i < Word.Length; i++)
            //        {
            //            if (Char.IsLower(Word[i]))
            //            {
            //                Count++;
            //            }
            //        }
            //    }
            //    return Count;
            //}
        }

        #endregion

        #region Anonymous Method

        class ConditionsFunctions
        {
            //public static bool CheckOdd(int x) { return x % 2 != 0; }
            //public static bool CheckEven(int x) { return x % 2 == 0; }
            //public static bool CheckDivBy4(int x) { return x % 4 == 0; }
        }

        #endregion
    }
}