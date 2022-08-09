using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Expression_trees
{
    class Program
    {
        static void Main(string[] args)
        {

            Expression<Func<int, bool>> lambda = num => num < 8;
            Console.WriteLine(lambda.Compile()(8));







            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Multiply, Expression.Constant(10), Expression.Constant(2));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Divide, Expression.Constant(10), Expression.Constant(5));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, Expression.Constant(10), Expression.Constant(1));
            BinaryExpression b4 = Expression.MakeBinary(ExpressionType.Add, b1, b2);
            BinaryExpression b5 = Expression.MakeBinary(ExpressionType.Subtract, b3, b4);
            int result = Expression.Lambda<Func<int>>(b5).Compile()();
            Console.WriteLine(result);



        }
    }
}
