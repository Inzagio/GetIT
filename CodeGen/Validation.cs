using static CodeGen.Checks;

namespace CodeGen
{
    class Validation
    {
        public static bool IsValid(string[] args)
        {
            return args.Length == 2 && CheckNumber(args[0]) && CheckOptions(args[1]);

        }


        public static bool CheckOptions(string s)
        {
            foreach (var c in s)
            {
                switch (c)
                {
                    case 'l':
                        break;
                    case 'L':
                        break;
                    case 's':
                        break;
                    case 'd':
                        break;
                    default: return false;
                }
            }

            return true;
        }
    }
}
