namespace Cours_6
{
    public class FizzBuzz
    {
        public string KataFb(int n)
        {
            string result = string.Empty;
            for(int i = 1; i <= n; i++)
            {
                bool check = false;
                result += GetMultiple5et3(i, out check);
                if(!check)
                    result += GetMultiple5(i, out check);
                if (!check)
                    result += GetMultiple3(i, out check);
                if (!check)
                    result += i.ToString();
            }
            return result;
        }

        private string GetMultiple5et3(int n, out bool isOk)
        {
            isOk = n % 5 == 0 && n%3 == 0;
            if (isOk)
                return "FizzBuzz";
            return string.Empty;
        }

        private string GetMultiple3(int n, out bool isOk)
        {
            isOk = n % 3 == 0;
            if (isOk)
                return "Fizz";
            return string.Empty;
        }

        private string GetMultiple5(int n, out bool isOk)
        {
            isOk = n % 5 == 0;
            if (isOk)
                return "Buzz";
            return string.Empty;
        }
    }
}
