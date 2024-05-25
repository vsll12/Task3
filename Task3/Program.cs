namespace Task3
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string[] questions = new string[]
            {
                "Azerbaycanin paytaxti haradir?",
                "Azerbaycanin ikinci en boyuk seheri hansidir?",
                "Azerbaycanin en böyük golu hansidir?",
                "Azerbaycanin dovlet dili hansidir?",
                "Azerbaycanin en meshur xalcasi hansidir?",
                "Azerbaycanin resmi dini hansidir?",
                "Azerbaycanin en uzun cayi hansidir?",
                "Azerbaycanin milli valyutasi hansidir?",
                "Azerbaycanin müsteqillik gunu ne vaxtdir?",
                "Azerbaycanin en yuksek dagi hansidir?"
            };

            string[,] answers = new string[,]
            {
                { "Baki","Gence","Naxcivan"},
                {"Gence","Sumqayit","Mingecevir" },
                {"Goygol","Ceyranbatan","Xezer denizi" },
                {"Rus dili","Ingilis dili","Azerbaycan dili" },
                {"Qarabag xalcasi","Gence xalcasi","Sirvan xalcasi" },
                {"Islam","Xristianliq","Yehudilik" },
                {"Kur","Araz","Samur" },
                {"Manat","Euro","Dollar" },
                {"18 oktyabr","28 may","20 yanvar"},
                {"Bazarduzu","Sahdag","Qapiciq" }
            };

            int[] correctAnswers = new int[] {0,0,2,2,0,0,0,0,1,0};

            int score = 0;

            Random rand = new Random();

            for (int i = 0; i < questions.Length; i++) 
            {
                Console.Clear();

                Console.WriteLine($"Sual {i + 1} : {questions[i]}");

                int[] order = { 0, 1, 2 };

                for (int j = 0; j < order.Length; j++)
                {
                    int k = rand.Next(j, order.Length);
                    int temp = order[j];
                    order[j] = order[k];
                    order[k] = temp;
                }

                for (int j = 0; j < order.Length; j++)
                {
                    Console.WriteLine($"{(char)('a' + j)}) {answers[i, order[j]]}");
                }


                Console.Write("Cavabınızı seçin (a, b, c): ");

                char choice = Console.ReadKey().KeyChar;

                int selectedAnswer = choice - 'a';

                Console.Clear();

                if (order[selectedAnswer] == correctAnswers[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Düzgün cavab!");

                    score += 10;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Yanlış cavab!");

                    score -= 10;

                    if (score < 0) score = 0;
                }

                Console.ResetColor();

                Thread.Sleep(2000);
            }

            Console.Clear();

            Console.WriteLine($"Score : {score}");

        }
    }
}