namespace Zadania
{
public class Parsing
    {
        public static byte ParsowanieByte(string tekstPrzedPodaniem)
        {
            byte wartosc;
            while (true)
            {
                Console.Write(tekstPrzedPodaniem);
                if (byte.TryParse(Console.ReadLine(), out wartosc))
                {

                    return wartosc;
                }
                else
                {
                    Console.Clear();
                    Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
                }
            }
        }
        public static byte ParsowanieByte(string tekstPrzedPodaniem, byte min, byte max)
        {
            byte liczbaOdUzytkownika;
            while (true)
            {
                liczbaOdUzytkownika = ParsowanieByte(tekstPrzedPodaniem);
                if (liczbaOdUzytkownika <= max && liczbaOdUzytkownika >= min)
                    break;

                Console.Clear();
                Console.WriteLine($"Wprowadź liczby z zakresu {min}-{max}"); Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
            }
            return liczbaOdUzytkownika;
        }
        public static int ParsowanieInt(string tekstPrzedPodaniem)
        {
            int wartosc;
            while (true)
            {
                Console.Write(tekstPrzedPodaniem);
                if (int.TryParse(Console.ReadLine(), out wartosc))
                {
                    return wartosc;
                }
                else
                {
                    Console.Clear();
                    Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
                }
            }
        }
        public static int ParsowanieInt(string teksPrzedParsem, int min, int max)
        {
            int liczbaOdUzytkownika;
            while (true)
            {
                liczbaOdUzytkownika = ParsowanieInt(teksPrzedParsem);
                if (liczbaOdUzytkownika <= max && liczbaOdUzytkownika >= min)
                    break;

                Console.Clear();
                Console.WriteLine($"Wprowadź liczby z zakresu {min}-{max}");
            }

            return liczbaOdUzytkownika;
        }
        public static float ParsowanieFloat(string tekstPrzedPodaniem)
        {
            float wartosc;
            while (true)
            {
                Console.Write(tekstPrzedPodaniem);
                if (float.TryParse(Console.ReadLine(), out wartosc))
                {
                    return wartosc;
                }
                else
                {
                    Console.Clear();
                    Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
                }
            }
        }
        public static float ParsowanieFloat(string tekstPrzedPodaniem, int min, int max)
        {
            float wartosc;
                while (true)
                {
                    wartosc = ParsowanieFloat(tekstPrzedPodaniem);
                    if (wartosc <= max && wartosc >= min)
                        break;

                    Console.Clear();
                    Console.WriteLine($"Wprowadź liczby z zakresu {min}-{max}"); Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
                }
            return wartosc; ;
        }
        public static double ParsowanieDouble(string tekstPrzedPodaniem)
        {
            double wartosc;
            while (true)
            {
                Console.Write(tekstPrzedPodaniem);
                if (double.TryParse(Console.ReadLine(), out wartosc))
                {
                    return wartosc;
                }
                else
                {
                    Console.Clear();
                    Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
                }
            }
        }
        public static double ParsowanieDouble(string tekstPrzedPodaniem, double min, double max)
        {
            double liczbaOdUzytkownika;
            while (true)
            {
                liczbaOdUzytkownika = ParsowanieDouble(tekstPrzedPodaniem);
                if (liczbaOdUzytkownika <= max && liczbaOdUzytkownika >= min)
                    break;

                Console.Clear();
                Console.WriteLine($"Wprowadź liczby z zakresu {min}-{max}"); Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
            }
            return liczbaOdUzytkownika;
        }
        public static decimal ParsowanieDecimal(string tekstPrzedPodaniem)
        {
            decimal wartosc;
            while (true)
            {
                Console.Write(tekstPrzedPodaniem);
                if (decimal.TryParse(Console.ReadLine(), out wartosc))
                {
                    
                    return wartosc;
                }
                else
                {
                    Console.Clear();
                    Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
                }
            }
        }
        public static decimal ParsowanieDecimal(string tekstPrzedPodaniem, decimal min, decimal max)
        {
            decimal liczbaOdUzytkownika;
            while (true)
            {
                liczbaOdUzytkownika = ParsowanieDecimal(tekstPrzedPodaniem);
                if (liczbaOdUzytkownika <= max && liczbaOdUzytkownika >= min)
                    break;

                Console.Clear();
                Console.WriteLine($"Wprowadź liczby z zakresu {min}-{max}"); Console.Write($"Wprowadzono niepoprawną wartość, spróbuj ponownie \n");
            }
            return liczbaOdUzytkownika;
        }
        //Metoda odpowiedzilna korzystanie z menu przy pomocy strzałek
        public static int MenuStrzalki(string tekstPrzedMenu, params string[] options)
        {
            const int startX = 1, opcja = 1;
            int wybor = 0;
            ConsoleKey klawisz;

            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                Console.WriteLine(tekstPrzedMenu);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX, i + 1);

                    if (i == wybor)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                klawisz = Console.ReadKey(true).Key;
                switch (klawisz)
                {

                    case ConsoleKey.UpArrow:
                        {
                            if (wybor >= opcja)
                                wybor -= opcja;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (wybor + opcja < options.Length)
                                wybor += opcja;
                            break;
                        }


                }
            } while (klawisz != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return wybor;
        }
        /// <summary>
        /// Wypisuje listę opcji i pobiera liczbę (musi zaczynać się od 1 a kończy się na opcje.Length) ostatnia opcja musi mieć \n na końcu
        /// </summary>
        /// <param name="opcje"></param>
        /// <returns></returns>
        public static byte MenuLiczba(params string[] opcje)
           => ParsowanieByte(string.Join('\n', opcje), 1, (byte)opcje.Length);
    }
}