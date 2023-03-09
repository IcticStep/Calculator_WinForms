using System.Reflection;
using System;

namespace Calculator_WinForms
{
    internal static class CommandsSettings
    {
        public static readonly Command Result = new Command("result","=");
        public static readonly Command Dot = new Command("dot", ".");
        public static readonly Command Sign = new Command("sign", "±");
        public static readonly Command Divide = new Command("divide", "÷");
        public static readonly Command Multiply = new Command("multiply", "*");
        public static readonly Command Substract = new Command("substract", "-");
        public static readonly Command Add = new Command("add", "+");
        public static readonly Command Sqrt = new Command("sqrt", "√");
        public static readonly Command Remainder = new Command("remainder", "%");
        public static readonly Command Reflect = new Command("reflect", "1/x");
        public static readonly Command Backspace = new Command("backspace", "←");
        public static readonly Command ClearAll = new Command("clearAll", "CE");
        public static readonly Command Clear = new Command("clear", "C");

        public static string GetView(string key)
        {
            var fields = typeof(CommandsSettings).GetFields();
            foreach (var field in fields)
            {
                var value = field.GetValue(null) as Command;
                if (value.Key == key)
                    return value.View;
            }

            throw new ArgumentException();
        }
    }

    internal class Command
    {
        public Command(string key, string view) =>
            (Key, View) = (key, view);

        public readonly string Key;
        public readonly string View;
    }
}
