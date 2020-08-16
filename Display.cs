using System;

namespace university_project
{
    class Display
    {
        private static string _autumn1a="", _autumn1b="", _autumn1c="", _autumn1d ="";
        private static string _autumn2a="", _autumn2b="", _autumn2c="", _autumn2d="";
        private static string _autumn3a="", _autumn3b="", _autumn3c="", _autumn3d="";
        private static string _spring1a="", _spring1b="", _spring1c="", _spring1d="";
        private static string _spring2a="", _spring2b="", _spring2c="", _spring2d="";
        private static string _spring3a="", _spring3b="", _spring3c="", _spring3d="";
        
        public static void DisplayTimetable ()
        {
            Console.WriteLine("Your time table : ");
            Console.Write("Autumn 2020 : ");
            Console.WriteLine(_autumn1a + " , " + _autumn1b + " , " + _autumn1c + " , " + _autumn1d);
            Console.Write("Spring 2020 : ");
            Console.WriteLine(_spring1a + " , " + _spring1b + " , " + _spring1c + " , " + _spring1d);
            Console.Write("Autumn 2021 : ");
            Console.WriteLine(_autumn2a + " , " + _autumn2b + " , " + _autumn2c + " , " + _autumn2d);
            Console.Write("Spring 2021 : ");
            Console.WriteLine(_spring2a + " , " + _spring2b + " , " + _spring2c + " , " + _spring2d);
            Console.Write("Autumn 2022 : ");
            Console.WriteLine(_autumn3a + " , " + _autumn3b + " , " + _autumn3c + " , " + _autumn3d);
            Console.Write("Spring 2022 : ");
            Console.WriteLine(_spring3a + " , " + _spring3b + " , " + _spring3c + " , " + _spring3d);
        }

    }
}
