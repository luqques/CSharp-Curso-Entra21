namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "lucas";
            cookies["email"] = "lucas@gmail.com";
            cookies["phone"] = "479856461";

            cookies.Remove("phone");

            Console.WriteLine(cookies["user"]);

            if (cookies.ContainsKey("user"))
            {
                Console.WriteLine(cookies["email"]);
            }

            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }

}