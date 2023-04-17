namespace Refactor1
{
    public class GenericMaximum<T> where T : IComparable<T>
    {
        public static T Maximum(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                throw new Exception("Given values are same");
            }
        }
    }
    internal class Refactor1
    {
        static void Main()
        {
            Console.WriteLine("*****Find Maximum value using Generic-Method*****");
            Console.WriteLine("----------------------------------------------------");

            int MaxInt = GenericMaximum<int>.Maximum(21, 78, 93);
            Console.WriteLine($"\nMaximum Int value is: {MaxInt}");

            float MaxFloat = GenericMaximum<float>.Maximum(3.5f, 2.5f, 4.5f);
            Console.WriteLine($"\nMaximum Float value is: {MaxFloat}");

            string MaxString = GenericMaximum<string>.Maximum("Kanna", "Ananya", "Abhi");
            Console.WriteLine($"\nMaximum String value is: {MaxString}");
        }
    }
}
