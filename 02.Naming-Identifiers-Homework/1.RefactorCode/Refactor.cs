using System;
using System.Linq;

namespace RefactorCode
{
    class SampleClass
    {
        const int MAX_COUNT = 6;

        class NestedClass
        {
            public void MethodInNestedClass(bool booleanVariable)
            {
                string stringVariable = booleanVariable.ToString();
                Console.WriteLine(stringVariable);
            }
        }

        public static void MethodForInput()
        {
            SampleClass.NestedClass instanceOfNestedClass = new SampleClass.NestedClass();
            instanceOfNestedClass.MethodInNestedClass(true);
        }
    }
}
