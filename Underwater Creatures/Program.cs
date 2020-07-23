using System;
using static System.Console;

/*
 * Underwater Zoo by Hope Pham
 * PROG 101 (01) July 13, 2020
 * [Assisted by Professor Janell Baxter]
 * Title Text created with ASCII Text Generator at: https://www.coolgenerator.com/ascii-text-generator 
 */

namespace Underwater_Creatures
{
    class Program
    {
        static void Main()
        {

            SetWindowSize(LargestWindowWidth - 82, LargestWindowHeight - 10);

            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.Yellow;
            Clear();
            string TitleText = "Underwater Zoo by Hope Pham";
            TitleText = @"

 __    __      __      _   ______      _____   ______     ___       ___     ____     ________    _____   ______         ______      ____       ____    
 ) )  ( (     /  \    / ) (_  __ \    / ___/  (   __ \   (  (       )  )   (    )   (___  ___)  / ___/  (   __ \       (____  )    / __ \     / __ \   
( (    ) )   / /\ \  / /    ) ) \ \  ( (__     ) (__) )   \  \  _  /  /    / /\ \       ) )    ( (__     ) (__) )          / /    / /  \ \   / /  \ \  
 ) )  ( (    ) ) ) ) ) )   ( (   ) )  ) __)   (    __/     \  \/ \/  /    ( (__) )     ( (      ) __)   (    __/       ___/ /_   ( ()  () ) ( ()  () ) 
( (    ) )  ( ( ( ( ( (     ) )  ) ) ( (       ) \ \  _     )   _   (      )    (       ) )    ( (       ) \ \  _     /__  ___)  ( ()  () ) ( ()  () ) 
 ) \__/ (   / /  \ \/ /    / /__/ /   \ \___  ( ( \ \_))    \  ( )  /     /  /\  \     ( (      \ \___  ( ( \ \_))      / /____   \ \__/ /   \ \__/ /  
 \______/  (_/    \__/    (______/     \____\  )_) \__/      \_/ \_/     /__(  )__\    /__\      \____\  )_) \__/      (_______)   \____/     \____/   

                                                                       By Hope Pham 
                                                                  Assisted by professor 
                                                                      Janell Baxter
                                                                  (press enter to discover)                                                                                                                                                       
";

            Title = "Underwater Zoo by Hope Pham";
            Write(TitleText);

            ReadKey();
            Clear();

            new Water();
        }
    }
}
