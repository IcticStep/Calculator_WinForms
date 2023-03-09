using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    internal class KeyDownHandler
    {
        public KeyDownHandler() => InitKeyCommands();

        private void InitKeyCommands()
        {
            _keyCommands.Add(Keys.D1, "1");
            _keyCommands.Add(Keys.D2, "2");
            _keyCommands.Add(Keys.D3, "3");
            _keyCommands.Add(Keys.D4, "4");
            _keyCommands.Add(Keys.D5, "5");
            _keyCommands.Add(Keys.D6, "6");
            _keyCommands.Add(Keys.D7, "7");
            _keyCommands.Add(Keys.D8, "8");
            _keyCommands.Add(Keys.D9, "9");
            _keyCommands.Add(Keys.D0, "0");
            _keyCommands.Add(Keys.Back, CommandsSettings.Backspace.Key);
            _keyCommands.Add(Keys.Separator, CommandsSettings.Dot.Key);
            _keyCommands.Add(Keys.Divide, CommandsSettings.Divide.Key);
            _keyCommands.Add(Keys.Subtract, CommandsSettings.Substract.Key);
            _keyCommands.Add(Keys.Multiply, CommandsSettings.Multiply.Key);
            _keyCommands.Add(Keys.Add, CommandsSettings.Add.Key);
            _keyCommands.Add(Keys.Escape, CommandsSettings.Clear.Key);
            _keyCommands.Add(Keys.Enter, CommandsSettings.Result.Key);
        }

        public bool HasBind(Keys key) => _keyCommands.ContainsKey(key);

        public string GetBindedCommand(Keys key)
        {
            if(!HasBind(key))
                throw new ArgumentException("No bind to key!");
            return _keyCommands[key];
        }

        private readonly Dictionary<Keys, string> _keyCommands = new Dictionary<Keys, string>();
    }
}
