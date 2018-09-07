using static CodeGen.Checks;

namespace CodeGen
{
    class Validation
    {   //Runs validation for two command line arguments
        public static bool IsValid(string[] args)
        {
            return args.Length == 2 && CheckNumber(args[0]) && CheckOptions(args[1]);

        }
    }
}
