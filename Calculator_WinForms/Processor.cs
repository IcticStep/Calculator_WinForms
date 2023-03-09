using System;
using System.Collections.Generic;
using System.Globalization;
using static Calculator_WinForms.CommandsSettings;

namespace Calculator_WinForms
{
    internal class Processor
    {
        public Processor() => InitCommands();

        private readonly Dictionary<string, Operation> _commands
            = new Dictionary<string, Operation>();

        public double Procceed(in InputContainer inputData)
        {
            var additional = inputData.HasAdditionalNumber 
                ? double.Parse(inputData.AdditionalNumber, CultureInfo.InvariantCulture)
                : default;
            var main = double.Parse(inputData.MainNumber, CultureInfo.InvariantCulture);

            return _commands[inputData.Operation].Perform(additional, main);
        }

        public bool CanPerform(string operation) => _commands.ContainsKey(operation);

        public bool NeedBothNumbers(string operation)
        {
            if (!CanPerform(operation))
                throw new ArgumentException();

            return _commands[operation].NeedsBothNubmers;
        }

        private void InitCommands()
        {
            InitOperation(Sign.Key, (num1, num2) => -num2, needBothNumbers: false);
            InitOperation(Divide.Key, (num1, num2) => num1 == 0 ? double.NaN : num1 / num2);
            InitOperation(Multiply.Key, (num1, num2) => num1 * num2);
            InitOperation(Substract.Key, (num1, num2) => num1 - num2);
            InitOperation(Add.Key, (num1, num2) => num1 + num2);
            InitOperation(Sqrt.Key, (num1, num2) => Math.Sqrt(num2), needBothNumbers: false);
            InitOperation(Remainder.Key, (num1, num2) => num1 % num2);
            InitOperation(Reflect.Key, (num1, num2) => 1 / num2, needBothNumbers: false);
        }

        private void InitOperation(string name, Func<double, double, double> function, bool needBothNumbers = true) =>
            _commands.Add(name, new Operation(function, needBothNumbers));

        struct Operation
        {
            internal Operation(Func<double, double, double> function, bool needsBothNubmers) =>
                (_function, NeedsBothNubmers) = (function, needsBothNubmers);

            private readonly Func<double, double, double> _function;
            public readonly bool NeedsBothNubmers;

            public double Perform(double additinal, double main) => _function.Invoke(additinal, main);
        }
    }
}