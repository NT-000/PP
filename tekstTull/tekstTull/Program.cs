//1) Reverser stringen!

//    Lag et program hvor du kan skrive inn en tekst, og når du sender teksten inn vil du få tilbake teksten reversert. Gjør dette uten å bruke innebygde reverse metoder
//Bygg videre ved å legge til flere ting man kan gjøre med stringen, eksempel:
//Alternativer for hva man vil gjøre, trykk 1,2 eller 3 for å reversere, konvertere til uppercase eller lowercase

namespace tekstTull
{
    internal class Program
    {

        static void Main(string[] args)
        {
            do
            {
                
                Console.WriteLine("1. for reversering av tekst.");
                Console.WriteLine("2. store bokstaver");
                Console.WriteLine("3. for små bokstaver");
                Console.WriteLine("4. for å reverse teksten og gjøre om til store bokstaver");
                Console.WriteLine("5. for å reversere og gjøre om til små bokstaver");
                Console.WriteLine("6. for å reversere på en funky måte");
                Console.WriteLine("7. Random test");
                var input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        Console.WriteLine("Skriv noe...");
                        var inputReverse = Console.ReadLine();
                        Console.WriteLine($"{ReverseString(inputReverse)}");
                        break;

                    case "2":
                        Console.WriteLine("Ord til store bokstaver");

                        var input2 = Console.ReadLine();
                        var uppercase = input2.ToUpper();
                        Console.WriteLine($"Ord til store bokstaver:{uppercase}");
                        break;
                    case "3":
                        Console.WriteLine("Små bokstaver");
                        var input3 = Console.ReadLine();
                        var lowerCase = input3.ToLower();
                        Console.WriteLine($"Ord til småbokstaver:{lowerCase}");
                        break;
                        case "4":
                        Console.WriteLine("Reverser teksten med store bokstaver");
                            var input4 = Console.ReadLine();
                            var inputUpperCase = input4.ToUpper();
                            Console.WriteLine($"{ReverseStringUpper(inputUpperCase)}");
                            break;
                        case "5":
                        Console.WriteLine("Reverser teksten med små bokstaver");
                            var input5 = Console.ReadLine();
                            var inputLowercase = input5.ToLower();
                            Console.WriteLine($"{ReverseStringLower(inputLowercase)}");
                        break;
                    case "6":
                        Console.WriteLine("Reverser teksten på en funky måte");
                        var input6 = Console.ReadLine();
                        Console.WriteLine($"{ReverseString6(input6)}");
                        break;
                    case "7":
                        Console.WriteLine("Reverser teksten på en funky måte");
                        var input7 = Console.ReadLine();
                        Console.WriteLine($"{RandomString(input7)}");
                        break;

                }

                Console.WriteLine("Prøve på nytt? (ja/nei)");
                string answer = Console.ReadLine();
                if (answer != "ja")
                {
                    Console.WriteLine("Du valgte å slutte");
                    break;
                }
            } while (true);
        }

        static string ReverseStringLower(string inputLowerCase)
        {
            string newTextLower = "";
            for (var i = inputLowerCase.Length - 1; i >= 0; i--)
            {
                newTextLower += inputLowerCase[i];
            }
            return newTextLower;
        }
        static string ReverseStringUpper(string inputUpperCase)
        {
            string newTextUpper = "";
            for (var i = inputUpperCase.Length - 1; i >= 0; i--)
            {
                newTextUpper += inputUpperCase[i];
            }
            return newTextUpper;
        }
        static string ReverseString(string inputReverse)
        {
            string newtext = "";
            for (var i = inputReverse.Length - 1; i >= 0; i--)
            {
                newtext += inputReverse[i];
            }
            return newtext;
        }

        static string ReverseString6(string input6)
        {
            string test = "";
            for (var i = 0; i < input6.Length; i++)
            {
                test = input6[i] + test;
            }

            return test;
        }
        static string RandomString(string input7)
        {
            string randomTest = "";
            for (var i = 0; i < input7.Length; i++)
            {
                Random num = new();
                int randomNum = num.Next(2);
                    if(randomNum== 0)
                {
                    randomTest += input7.ToUpper();
                }
                    else if(randomNum == 1)
                {
                    randomTest += input7.ToLower();
                }
            }

            return randomTest;
        }
    }
}
