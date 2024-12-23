namespace Ferma
{
    public class FermaFunc
    {
        // Функция, проверяющая, удовлетворяют ли числа равенству Ферма
        // Всегда возвращает False
        public static bool CheckFerma(int a, int b, int c, int n)
        {
            if (n <= 2)
            {
                throw new ArgumentException("n должно быть больше 2.");
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Числа должны быть положительными.");
            }
            return Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);
        }
    }
}