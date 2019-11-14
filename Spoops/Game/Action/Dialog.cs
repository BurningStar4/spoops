using System;
using System.Collections.Generic;
using System.Text;
using Spoops.Game.Action;

namespace Spoops.Game.Action
{
    public class Dialog : IAction
    {

        private List<string> _dialog;
        private int _dialogIndex;
        private List<string> _options;

        public Dialog(List<string> dialog, List<string> options = null) //options is optional, could be a dialog with no options to select
        {
            _dialog = dialog;
            _dialogIndex = 0;
            _options = options;
            
        }
        
        public IAction SelectOption(int optionNum)
        {
            throw new NotImplementedException();
        }
        public string GetNextDialog()
        {
            return _dialog[_dialogIndex++];
        }

    }
}
