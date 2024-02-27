using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Interpreter_Pattern
{
    public class InterpreterMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Provide Roman Number string = ");
            string roman = Console.ReadLine();
            Context context = new Context { Input = roman};

            List<AExpression> expressions = new List<AExpression> { 
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (AExpression expression in expressions)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");

            Console.ReadLine();
        }
    }
}
