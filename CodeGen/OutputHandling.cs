using System;

namespace CodeGen
{
    class OutputHandling
    {
        public static void ShowHelpText()
        {
            Console.WriteLine(
                "PasswordGenerator  \r\n  Options:\r\n  - l = lower case letter\r\n  - L = upper case letter\r\n  - d = digit\r\n  - s = special character (!\"#¤%&/(){}[]\r\nExample: PasswordGenerator 14 lLssdd\r\n         Min. 1 lower case\r\n         Min. 1 upper case\r\n         Min. 2 special characters\r\n         Min. 2 digits");
        }
    }
}
