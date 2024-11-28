namespace _28._11_stroki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] phone = { 9, 2, 3, 6, 5, 7, 3, 4, 3, 7 };
            Console.WriteLine(CreatePhoneNumber(phone)); 

            Console.WriteLine(TrimString("Writing code is fun", 14)); 
            Console.WriteLine(TrimString("Hello", 5));
            Console.WriteLine(TrimString("He", 1)); 
            Console.WriteLine(TrimString("Ya yura ya krutoi", 10));

            
            Console.WriteLine(SquareDigits(5678));
            Console.WriteLine(SquareDigits(2));

            Console.WriteLine(Likes(new string[] { })); 
            Console.WriteLine(Likes(new string[] { "Peter" })); 
            Console.WriteLine(Likes(new string[] { "Jacob", "Alex" })); 
            Console.WriteLine(Likes(new string[] { "Max", "John", "Mark" }));
            Console.WriteLine(Likes(new string[] { "Alex", "Jacob", "Mark", "Max" })); 
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10)
            {
                return "Ошибка: Номер телефона должен содержать 10 цифр.";
            }

            string phone = "+7 (" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] + " " + numbers[6] + numbers[7] + "-" + numbers[8] + numbers[9];
            return phone;
        }
        public static string TrimString(string phrase, int len)
        {
            if (len <= 3)
            {
                if (phrase.Length > len)
                {
                    return phrase.Substring(0, len) + "...";
                }
                else
                {
                    return phrase;
                }
            }
            else
            {
                if (phrase.Length > len)
                {
                    return phrase.Substring(0, len - 3) + "...";
                }
                else
                {
                    return phrase;
                }
            }
        }

        
        public static long SquareDigits(long n)
        {
            string result = "";
            string number = n.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                result += (digit * digit).ToString();
            }

            return long.Parse(result);
        }

        
        public static string Likes(string[] names)
        {
            if (names.Length == 0)
            {
                return "no one likes this";
            }
            else if (names.Length == 1)
            {
                return names[0] + " likes this";
            }
            else if (names.Length == 2)
            {
                return names[0] + " and " + names[1] + " like this";
            }
            else if (names.Length == 3)
            {
                return names[0] + ", " + names[1] + " and " + names[2] + " like this";
            }
            else
            {
                return names[0] + ", " + names[1] + " and " + (names.Length - 2) + " others like this";
            }
        }

    }

}
