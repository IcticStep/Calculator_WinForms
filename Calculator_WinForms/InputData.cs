using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_WinForms
{
    internal class InputData
    {
        public InputData() : this(null, "0", "") { }

        public InputData(string additionalNumber, string mainNumber, string operation) =>
            (AdditionalNumber, MainNumber, Operation) = (additionalNumber, mainNumber, operation);

        public const int DigitsLimit = 16;
        private readonly string ClearNumber = default(double).ToString(CultureInfo.InvariantCulture);

        public string AdditionalNumber { get; private set; }
        public string MainNumber { get; private set; } 
        public string Operation { get; private set; }
        public string OperationView { get; private set; }

        public bool HasAdditionalNumber => !string.IsNullOrEmpty(AdditionalNumber);
        public bool HasMainNumber => !string.IsNullOrEmpty(MainNumber);
        public bool HasBothNumbers => HasAdditionalNumber && HasMainNumber;

        public void AddDigit(char digit)
        {
            if (DigitsLimitReached(MainNumber))
                return;

            if (ContainsZeroOnly(MainNumber))
            {
                MainNumber = digit.ToString();
                return;
            }

            MainNumber += digit;
        }

        public void AddDot()
        {
            if (!HasMainNumber)
                ClearMainNumber();

            if (MainNumber.Contains('.'))
                return;

            MainNumber += '.';
        }

        public void AddDigit(string digit) => 
            AddDigit(digit[0]);

        public void SetOperation(string operation, string operationView = null)
        {
            if (operationView is null) operationView = operation;

            Operation = operation;
            OperationView = operationView;
        }

        public void ClearMainNumber() => MainNumber = ClearNumber;

        public void MakeClearStep()
        {
            if (HasBothNumbers && MainNumber != ClearNumber)
            {
                ClearMainNumber();
                return;
            }

            MainNumber = ClearNumber;
            AdditionalNumber = default;
            Operation = default;
        }

        public void SaveMainNumberWithReplacement(double value)
        {
            AdditionalNumber = MainNumber;
            MainNumber = value.ToString(CultureInfo.InvariantCulture);
        }

        public void SetCalculationsResult(double value)
        {
            SaveMainNumberWithReplacement(value);
            AdditionalNumber = default;
            Operation = default;
        }

        public void PrepareToOneArgumentOperation()
        {
            if(!HasAdditionalNumber) return;

            MainNumber = AdditionalNumber;
            AdditionalNumber = default;
        }

        private bool DigitsLimitReached(string value) =>
            value.Length >= DigitsLimit;

        private bool ContainsZeroOnly(string value) => value.Length == 1 && value[0] == '0';

        internal void RemoveDigit()
        {
            if (!HasMainNumber || MainNumber.Length == 1)
            {
                ClearMainNumber();
                return;
            }

            MainNumber = MainNumber.Substring(0, MainNumber.Length - 1);
        }
    }
}
