using System;

namespace AdvanceCSharpTopics
{
    class Program
    {
        // First Delegiate without any Parameters 
        public delegate void FirstDelegateWithoutParameters();
        static void Main(string[] args)
        {
            FirstDelegateWithoutParameters first = new FirstDelegateWithoutParameters(FirstFunctionWithTheSameDataTypeWithDelegate);
            first.Invoke();
            first();
        }
        public static void FirstFunctionWithTheSameDataTypeWithDelegate()
        {
            Console.WriteLine("Hello 1st Delegate Printing Hello");
            Console.WriteLine("Hello");
        }
    }
}
