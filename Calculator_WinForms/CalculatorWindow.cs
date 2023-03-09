using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculator_WinForms.Commands;

namespace Calculator_WinForms
{
    public partial class CalculatorWindow : Form
    {
        private InputData _input = new InputData();
        private Processor _processor = new Processor();

        private bool _resultJustSet;

        public CalculatorWindow() => InitializeComponent();

        private void HandleRegularButton(object sender, EventArgs e)
        {
            var button = sender as Button;
            var command = button.Tag as string;
            var text = button.Text;

            if (IsCommandNumeric(command))
            {
                AddDigit(command);
                return;
            }

            if (IsProccessingComand(command))
            {
                SendProcessingComand(command, text);
                return;
            }

            if (command == Result)
            {
                CalculateResult();
                return;
            }

            if (command == Dot)
            {
                AddDot();
                return;
            }

            throw new NotImplementedException();
        }

        private void AddDot()
        {
            ClearIfNeeded();
            _input.AddDot();
            UpdateView();
        }

        private void CalculateResult()
        {
            if (string.IsNullOrEmpty(_input.Operation))
                return;

            if (_processor.NeedBothNumbers(_input.Operation) && !_input.HasBothNumbers)
            {
                _input.SaveMainNumberWithReplacement(0);
                UpdateView();
                return;
            }

            var result = _processor.Procceed(_input);
            _input.SetCalculationsResult(result);
            _resultJustSet = true;
            UpdateView();
        }

        private void SendProcessingComand(string command, string text)
        {
            _input.SetOperation(command, text);
            if (_processor.NeedBothNumbers(_input.Operation) && !_input.HasBothNumbers)
            {
                _input.SaveMainNumberWithReplacement(0);
            }
            else if (!_processor.NeedBothNumbers(_input.Operation))
            {
                _input.PrepareToOneArgumentOperation();
                CalculateResult();
            }

            UpdateView();
        }

        private void AddDigit(string command)
        {
            ClearIfNeeded();
            _input.AddDigit(command);
            UpdateView();
        }

        private void ClearIfNeeded()
        {
            if (!_resultJustSet)
                return;

            _resultJustSet = false;
            if (_input.HasAdditionalNumber)
                return;

            _input = new InputData();
            
        }

        private void UpdateView()
        {
            MainNumber.Text = _input.MainNumber;

            if (_input.HasAdditionalNumber)
                AdditionalNumber.Text = $"{_input.AdditionalNumber} {_input.OperationView}";
            else if (IsOneArgumenProcessortOperation())
                AdditionalNumber.Text = $"{_input.OperationView}";
            else
                AdditionalNumber.Text = "";

            bool IsOneArgumenProcessortOperation() =>
                _input.Operation != null
                && IsProccessingComand(_input.Operation)
                && !_processor.NeedBothNumbers(_input.Operation);
        }

        private bool IsCommandNumeric(string command) =>
            command.Length == 1 && char.IsDigit(command[0]);

        private bool IsProccessingComand(string command) =>
            _processor.CanPerform(command);

        private void Clear(object sender, EventArgs e)
        {
            var button = sender as Button;
            var command = button.Tag;

            switch (command)
            {
                case ClearAll:
                    _input = new InputData();
                    break;
                case Commands.Clear:
                    _input.MakeClearStep();
                    break;
                case Backspace:
                    _input.RemoveDigit();
                    break;
            }

            UpdateView();
        }
    }
}