using System;

namespace university_project
{
    class ListOfUnit
    {
        //Mandatory 0 / Optional 1, Name of Unit, Season Available, Have Pre-req or not, Prereq code
        private static string[] _unit = new string[] {"_300580", "_100483", "_300585", "_300700", "_300565", "_300581", "_300104", "_300985"};
        private static string[] _300580 = new string[] {0,"Programming Fundamentals", "Autumn",0};
        private static string[] _100483 = new string[] {0,"Principles of Professional Communication 1", "Autumn",0};
        private static string[] _300585 = new string[] {0,"System Analysis and Design", "Autumn",0};
        private static string[] _300700 = new string[] {0,"Statistical Decision Making", "Autumn",0};

        private static string[] _300565 = new string[] {0,"Computer Networking", "Spring",0};
        private static string[] _300581 = new string[] {0,"Programming Technique", "Spring",1, "_300580"};
        private static string[] _300104 = new string[] {0,"Database Design and Development", "Spring", 0};
        private static string[] _300985 = new string[] {0,"Social Web Analytics", "Spring", 1, _300700};

        private static string[] _mandatory = new string[] {};
        private static string[] _optional = new string[] {};
        private static string[] _autumn2020 = new string[4];
        private static string[] _spring2020 = new string[4];

        private static void bingung() {
            for ( int i = 0 ; i < _unit.Length ; i++) {
                
            }
        }
        private static void Edit()
        {
            for ( int i = 0 ; i < _autumn2020.Length ; i++ ) {
                _autumn2020[i] = "a";
            }

        }
    }
}
