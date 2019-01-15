using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //solution
    public class HtmlElement {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement() { }
        public HtmlElement(string name, string text) {
            Name = name ?? throw new Exception();
            Text= text ?? throw new Exception();

        }
        private string ToStringImpl(int indent) {
            var sb = new StringBuilder();
            var i = new String(' ', indentSize * indent);
                sb.Append($"{i}<{Name}>");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach(var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    public class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        private string rootname;
        public HtmlBuilder (string rootname)
        {
            this.rootname = rootname;
            root.Name = rootname;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            System.Console.WriteLine(builder.ToString());
        }
    }
}
