using System;
using System.Collections;
namespace _0_0_Fizz_Bang
{
    public class Words
    {
        private string _word;
        private int _divider;

        public string Word
        {
            get { return _word; }
            set { _word = value; }
        }

        public int Divider
        {
            get { return _divider; }
            set { _divider = value; }
        }
    }
    public class Counter
    {
        private static int _current;
        private static int _max;
        private static ArrayList _wordvalues;

        public static int Current
        {
            get { return _current; }
            set { _current = value; }
        }

        public static int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public static ArrayList WordValues
        {
            get { return _wordvalues; }
            set { _wordvalues = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter.WordValues = new ArrayList();
            GetMax();
        }

        static void GetMax()
        {
            Console.Write("Up to where should the system count? ");
            try
            {
                Counter.Max = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please make sure you enter a valid integer value only.");
                GetMax();
            }
            finally
            {
                GetWordDivider();
            }
        }

        static void GetWordDivider()
        {
            Words toAdd = new Words();
            Console.Write("Divider: ");
            toAdd.Divider = int.Parse(Console.ReadLine());
            Console.Write("Word to substitute: ");
            toAdd.Word = Console.ReadLine();
            Counter.WordValues.Add(toAdd);
            Console.Write("Do you want to add another value? (y/n) ");
            if (Console.ReadKey().KeyChar.Equals('y'))
            {
                Console.Clear();
                GetWordDivider();
            }
            else
                StartGame();
        }

        static string Substitute()
        {
            string ReturnValue = null;

            foreach (Words item in Counter.WordValues)
            {
                if (Counter.Current % item.Divider == 0)
                    ReturnValue += !string.IsNullOrEmpty(ReturnValue) ? string.Format(" {0}", item.Word) : item.Word;
            }
            return ReturnValue;
        }

        static void StartGame()
        {
            Console.Clear();
            for (int i = 1; i < Counter.Max + 1; i++)
            {
                Counter.Current = i;
                string WordToPrint = "";
                if (!string.IsNullOrEmpty(WordToPrint = Substitute()))
                    Console.Write(WordToPrint);
                else
                    Console.Write(i.ToString());
                Console.Write(i < Counter.Max ? ", " : "");
            }
            Console.ReadLine();
        }
    }
}
