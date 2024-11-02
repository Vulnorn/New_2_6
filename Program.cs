namespace New_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandСonvertRubToEur = "1";
            const string CommandСonvertRubToUsd = "2";
            const string CommandСonvertEurToRub = "3";
            const string CommandСonvertEurToUsd = "4";
            const string CommandСonvertUsdToRub = "5";
            const string CommandСonvertUsdToEur = "6";
            const string CommandExite = "7";

            Random random = new Random();

            double ratioRubToEur = 100;
            double ratioRubToUsd = 50;
            double ratioEurToRub = 0.01;
            double ratioEurToUsd = 0.5;
            double ratioUsdToRub = 0.2;
            double ratioUsdToEur = 2;
            int minCurrency = 1000;
            int maxCurrency = 10000;
            bool isWork = true;
            string userInput;

            double userRub = random.Next(minCurrency, maxCurrency);
            double userUsd = random.Next(minCurrency, maxCurrency);
            double userEur = random.Next(minCurrency, maxCurrency);

            while (isWork)
            {
                Console.WriteLine($"На вашем баллансе находится Рублей - {userRub}; Долларов - {userUsd}; Евро - {userEur}\n" +
                    $"{CommandСonvertRubToEur} - Перевести рубли в евро.\n" +
                    $"{CommandСonvertRubToUsd}- Перевести рубли в доллары.\n" +
                    $"{CommandСonvertEurToRub}- Перевести евро в рубли.\n" +
                    $"{CommandСonvertEurToUsd}- Перевести евро в доллары.\n" +
                    $"{CommandСonvertUsdToRub}- Перевести доллары в рубли.\n" +
                    $"{CommandСonvertUsdToEur}- Перевести доллары в евро.\n" +
                    $"{CommandExite}- Выход.\n");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandСonvertRubToEur:
                        userEur += userRub / ratioRubToEur;
                        userRub -= userRub;
                        break;

                    case CommandСonvertRubToUsd:
                        userUsd += userRub / ratioRubToUsd;
                        userRub -= userRub;
                        break;

                    case CommandСonvertEurToRub:
                        userRub += userEur / ratioEurToRub;
                        userEur -= userEur;
                        break;

                    case CommandСonvertEurToUsd:
                        userUsd += userEur / ratioEurToUsd;
                        userEur -= userEur;
                        break;

                    case CommandСonvertUsdToRub:
                        userRub += userUsd / ratioUsdToRub;
                        userUsd -= userUsd;
                        break;

                    case CommandСonvertUsdToEur:
                        userEur += userUsd / ratioUsdToEur;
                        userUsd -= userUsd;
                        break;

                    case CommandExite:
                        isWork = false;
                        Console.WriteLine($"Программа завершена.");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}