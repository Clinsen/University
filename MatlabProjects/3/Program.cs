using Microsoft.Speech.Synthesis;
using System;
//using System.Speech.Synthesis;

class Program
{
    static void Main()
    {
        
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        // Встановлення голосу
        //   synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
        synthesizer.SetOutputToDefaultAudioDevice();
        
        string[] phrases = {
            "Press",
            "any key",
            "to exit",
            "hello",
            "good luck",
            "I like",
            "NLTU",
            "Forest"
        };
        Console.WriteLine("Виберіть слово для відтворення: \n" +
               "1.Press\n 2.any key\n 3.to exit\n 4.hello\n 5.good luck\n 6.I like\n 7.NLTU\n 8.Forest \n 9. All");
        int choice;
        do
        {
           

            if (int.TryParse(Console.ReadLine(), out choice )  )
            {
                if (choice >= 1 && choice <= 8)
                synthesizer.Speak(phrases[choice-1]);
                if (choice == 9 )
                {
                    foreach (string phrase in phrases)
                    {
                        Console.WriteLine(phrase);
                        synthesizer.Speak(phrase);
                    }
                }

                /* switch (choice)
                 {
                     case 1:
                         Console.WriteLine("Ви обрали пункт 1");
                         break;
                     case 2:
                         Console.WriteLine("Ви обрали пункт 2");
                         break;
                     case 3:
                         Console.WriteLine("Ви обрали пункт 3");
                         break;
                     case 4:
                         Console.WriteLine("Ви обрали пункт 4");
                         break;
                     case 5:
                         Console.WriteLine("Ви обрали пункт 5");
                         break;
                     case 6:
                         Console.WriteLine("Ви обрали пункт 6");
                         break;
                     case 7:
                         Console.WriteLine("Ви обрали пункт 7");
                         break;
                     case 8:
                         Console.WriteLine("Ви обрали пункт 8");
                         break;
                     case 0:
                         Console.WriteLine("Програма завершена.");
                         break;
                     default:
                         Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                         break;
                 }*/
            }
            else
            {
                Console.WriteLine("Невірний ввід. Введіть число від 0 до 9.");
            }

        } while (choice != 0);



        /*foreach (string phrase in phrases)
        {
            Console.WriteLine(phrase);
            synthesizer.Speak(phrase);
        }

        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
*/
    }
}
