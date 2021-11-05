using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_12_1_5
{
    class Program
    {
		static void Main(string[] args)
		{
			Dictionary<string, User> users = new Dictionary<string, User>
			{
				{ "regular",new User { Login = "regular", Name = "Regular Name", IsPremium = false } },
				{ "premium", new User { Login = "premium", Name = "Premium Name", IsPremium = true } },
			};
            Console.WriteLine("Вот список пользователей");
			foreach (KeyValuePair<string, User> pair in users)
            {
                Console.WriteLine(pair.Value.ToString());
            }
            Console.WriteLine("\nВведите логин одного из пользователей:");
			string login = Console.ReadLine();
			if (users.ContainsKey(login))
            {
                Console.WriteLine($"Привет, {users[login].Name}");
                if (!users[login].IsPremium)
                {
					ShowAds();
                }
            }
        }

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			Thread.Sleep(3000);
		}
	}
}
