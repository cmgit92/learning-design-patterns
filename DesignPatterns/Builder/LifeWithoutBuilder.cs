using System;
using System.Text;

namespace Builder
{
    class LifeWithoutBuilder
    {
        //Builder pattern = when piecewise object construction is complicated, provide an api for doing it succintly
        //Having an object with 10 constructor arguments is not productive
        //Opt for piecewise construction

        void LifeWithoutBuilderMethod(string[] args)
        {
            var hello = "Hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            System.Console.WriteLine(sb);

            var words = new[]
            {
                "hello", "world"
            };

            sb.Clear();
            sb.Append("<ul>");
            foreach (var v in words)
            {
                sb.AppendFormat("<li>{0}</li>", v);
            }
            sb.Append("</ul>");
            System.Console.WriteLine(sb);
        }



        static void LifeWithoutBuilderMain(string[] args)
        {
            var hello = "Hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            System.Console.WriteLine(sb);

            Console.WriteLine("Hello World!");
        }
    }
}
