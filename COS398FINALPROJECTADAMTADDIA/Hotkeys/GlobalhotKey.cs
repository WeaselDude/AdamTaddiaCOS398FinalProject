using System.Windows.Input;

namespace GlobalKeyhook.Hotkeys
{
    public  class GlobalHotkey
    {


        public Key key
        { 
            get; 
            set;
        }

        public ModifierKeys modKey
        {
            get;
            set;
        }

        public Action callback //action is used, because this method does not use any parameters or return a value 
        { 
            get; 
            set;
        }

        public bool canExecute//establishes if the process can run 
        {
            get; 
            set;
        }

        public GlobalHotkey(ModifierKeys modifier, Key Key, Action callBack, bool CanExecute = true)
        {
            modKey = modifier;
            key = Key;
            callback = callBack ;
            canExecute = CanExecute;
        }

        
    }
}
