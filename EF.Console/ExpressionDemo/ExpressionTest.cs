using EF.Console.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console.ExpressionDemo
{
    public class ExpressionTest
    {

        private static StringBuilder sqlBuilder = new StringBuilder();
        public static void Run()
        {
            /*
            //常量表达式+无返回值的静态方法
            ConstantExpression constantExpression = Expression.Constant("test string", typeof(string));
            MethodCallExpression methodCallExpression = Expression.Call(typeof(System.Console).GetMethod("WriteLine", new Type[] { typeof(string) }), constantExpression);
            Expression<Action> expression = Expression.Lambda<Action>(methodCallExpression);
            expression.Compile()();


            //参数表达式+无返回值有参数的静态方法
            ParameterExpression parameterExpression = Expression.Parameter(typeof(string), "Name");
            MethodCallExpression methodCallExpression1 = Expression.Call(typeof(System.Console).GetMethod("WriteLine", new Type[] { typeof(string) }), parameterExpression);
            Expression<Action<string>> expression1 = Expression.Lambda<Action<string>>(methodCallExpression1, parameterExpression);
            expression1.Compile()("Jack");


            //参数表达式+含有返回值有参数的静态方法
            ParameterExpression parameterExpression1 = Expression.Parameter(typeof(object), "left");
            MethodCallExpression methodCallExpression2 = Expression.Call(typeof(ExpressionTest).GetMethod("ConsStr", new Type[] { typeof(object) }), parameterExpression1);
            Expression<Func<object, string>> expression2 = Expression.Lambda<Func<object, string>>(methodCallExpression2, parameterExpression1);
            System.Console.WriteLine(expression2.Compile()("Tom"));
            */

            ResolveExpression();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public static void ResolveExpression()
        {

            Expression<Func<User_info, bool>> expression = (user) => user.UserLevelEndTime > Convert.ToDateTime("2019-11-1") ;

            User_info user_Info = new User_info { Email = "test" };

;
            Person p = new Person { Age = 16, Name = "John" };


            Expression<Func<Person, object>> expression1 = x => x.Age;
            // expression1.Body = UnaryExpression;

            Expression<Func<Person, object>> expression2 = x => x.Name;
            // expression2.Body = MemberExpression;

            GetExpression(expression2.Body);
            System.Console.WriteLine(sqlBuilder.ToString());
        }

        public static Expression GetExpression(Expression expression)
        {
            if (expression is BinaryExpression)
            {
                BinaryExpression binaryExpression = expression as BinaryExpression;
                var left = GetExpression(binaryExpression.Left);
                var nodeType = binaryExpression.NodeType;
                sqlBuilder.Append(NodeTypeToString(nodeType));
                var right = GetExpression(binaryExpression.Right);
            }
            else if (expression is MemberExpression)
            {
                MemberExpression memberExpression = expression as MemberExpression;
                sqlBuilder.Append($" {memberExpression.Member.Name} ");
            }
            else if (expression is UnaryExpression)
            {
                UnaryExpression unaryExpression = expression as UnaryExpression;
                sqlBuilder.Append($" {unaryExpression.NodeType} ");
                if (unaryExpression.NodeType== ExpressionType.Convert)
                {
                    GetValue(unaryExpression);
                }
            }
            else if (expression is ConstantExpression)
            {
                ConstantExpression constantExpression = expression as ConstantExpression;
                sqlBuilder.Append($" {constantExpression.Value.ToString()} ");
            }
            else if (expression is MethodCallExpression)
            {
                MethodCallExpression methodCallExpression = expression as MethodCallExpression;

                string methodName = methodCallExpression.Method.Name;
                GetExpression(methodCallExpression.Object);
                if (methodName == "Contains")
                {
                    sqlBuilder.Append($" LIKE ");
                }

                foreach (var argument in methodCallExpression.Arguments)
                {
                    GetExpression(argument);
                }
            }

            return null;
        }
        private static object GetValue(Expression member)
        {
            // source: http://stackoverflow.com/a/2616980/291955
            var objectMember = Expression.Convert(member, typeof(object));
            var getterLambda = Expression.Lambda<Func<object>>(objectMember);
            var getter = getterLambda.Compile();
            return getter();
        }

        private static string NodeTypeToString(ExpressionType nodeType)
        {
            switch (nodeType)
            {
                case ExpressionType.Add:
                    return "+";
                case ExpressionType.And:
                    return "&";
                case ExpressionType.AndAlso:
                    return "AND";
                case ExpressionType.Divide:
                    return "/";
                case ExpressionType.Equal:
                    return "=";
                case ExpressionType.ExclusiveOr:
                    return "^";
                case ExpressionType.GreaterThan:
                    return ">";
                case ExpressionType.GreaterThanOrEqual:
                    return ">=";
                case ExpressionType.LessThan:
                    return "<";
                case ExpressionType.LessThanOrEqual:
                    return "<=";
                case ExpressionType.Modulo:
                    return "%";
                case ExpressionType.Multiply:
                    return "*";
                case ExpressionType.Negate:
                    return "-";
                case ExpressionType.Not:
                    return "NOT";
                case ExpressionType.NotEqual:
                    return "<>";
                case ExpressionType.Or:
                    return "|";
                case ExpressionType.OrElse:
                    return "OR";
                case ExpressionType.Subtract:
                    return "-";
            }
            throw new Exception($"Unsupported node type: {nodeType}");
        }

    }


}
