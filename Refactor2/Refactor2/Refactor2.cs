namespace Refactor2
{
    public class GenericMaximum<T> where T : IComparable<T>
    {
        private T firstValue;
        private T secondValue;
        private T thirdValue;
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
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
    internal class Refactor2
    {
        static void Main()
        {
            Console.WriteLine("*****Find Maximum value using Generic-Method*****");
            Console.WriteLine("----------------------------------------------------");

            int MaxInt = GenericMaximum<int>.Maximum(57, 83, 19);
            Console.WriteLine($"\nMaximum Int value is: {MaxInt}");

            float MaxFloat = GenericMaximum<float>.Maximum(46.9f, 11.7f, 21.3f);
            Console.WriteLine($"\nMaximum Float value is: {MaxFloat}");

            string MaxString = GenericMaximum<string>.Maximum("Keerthi", "Bhargavi", "Bharath");
            Console.WriteLine($"\nMaximum String value is: {MaxString}");
        }
    }
}