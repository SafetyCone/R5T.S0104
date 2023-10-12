using System;


namespace R5T.S0104
{
    public class Instances :
        L0055.Instances
    {
        public static new IConsoleOperator ConsoleOperator => S0104.ConsoleOperator.Instance;
        public static L0053.ITypeOperator TypeOperator => L0053.TypeOperator.Instance;
    }
}