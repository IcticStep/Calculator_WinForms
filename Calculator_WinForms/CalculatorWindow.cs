using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Calculator_WinForms.Commands;

namespace Calculator_WinForms
{
    public partial class CalculatorWindow : Form
    {
        private readonly InputContainer _input = new InputContainer();
        private readonly Processor _processor = new Processor();
        private readonly Dictionary<string, Action> _commands = new Dictionary<string, Action>();

        private bool _resultJustSet;

        public CalculatorWindow()
        {
            InitializeComponent();
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            _commands.Add(ClearAll, ClearInput);
            _commands.Add(Clear, _input.MakeClearStep);
            _commands.Add(Backspace, _input.RemoveDigit);
            _commands.Add(Result, CalculateResult);
            _commands.Add(Dot, AddDot);
        }

        private void HandleButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            var command = button.Tag as string;
            var viewText = button.Text;

            PerformCommand(command, viewText);
        }

        private void PerformCommand(string command, string viewText)
        {
            if (IsCommandNumeric(command))
            {
                AddDigit(command);
                return;
            }

            if (IsProccessingComand(command))
            {
                SendProcessingComand(command, viewText);
                return;
            }

            if(!_commands.ContainsKey(command))
                throw new NotImplementedException();

            _commands[command].Invoke();
            UpdateView();
        }

        private void ClearInput() => _input.Reset();

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

            _input.Reset();
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
    }
}