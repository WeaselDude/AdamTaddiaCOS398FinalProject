using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Input;

//CREATED BY ADAM TADDIA AS THE FINAL PROJECT FOR COS398, DUE 12/15/2023

namespace GlobalKeyhook.Hotkeys
{

    public static class HotKeyHandler
    {

        private delegate IntPtr KeyboardProc(int nCode, IntPtr wParam, IntPtr lParam); //a part of the windows API for low level key stroke hooks
        private static KeyboardProc LowLevelProc = HookCallback;
        private static List<GlobalHotkey> Hotkeys //contains all of this applications hotkeys
        {
            get; 
            set;
        }

        private static IntPtr HookId = IntPtr.Zero;//sets hookId to zero - this changes

        public static bool isHookSetup //boolean with setters and getters for finding if keystroke hook is setup
        {
            get;
            set; 
        }

        static HotKeyHandler()
        {
            Hotkeys = new List<GlobalHotkey>();
        }
        
        
    

        public static void SystemHookClose()//stops the system hook from running
        {
            if (isHookSetup == true)
            {
                UnHookWindowsHookEx(HookId);
                isHookSetup = false;
            }
        }

        public static void SystemHookSetup()//this method needs to be used at the start of MainWindow.xaml.cs
                                            //to, as the name suggest, setup the hook used to detect keystrokes
        {
            if (isHookSetup == false)
            {
                HookId = SetHook(LowLevelProc);
                isHookSetup = true;
            }

        }

        public static void AddHotKey(GlobalHotkey hotKey)//a method for adding hotkeys to the list
        {
            Hotkeys.Add(hotKey);
        }

        

        //sets up hook with the specified callback
        private static IntPtr SetHook(KeyboardProc proc)
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule currentModule = currentProcess.MainModule)
                {
                    return SetWindowsHookEx(13, proc, GetModuleHandle(currentModule.ModuleName), 0);//13 is the number WinAPI uses for the hook ID
                                                                                                    
                }
            }
        }

        
        private static IntPtr HookCallback(int val, IntPtr wParam, IntPtr lParam)
        {
            if (val >= 0) 
            {
                foreach (GlobalHotkey hotkey in Hotkeys)
                {
                    if (Keyboard.Modifiers == hotkey.modKey && Keyboard.IsKeyDown(hotkey.key))
                    {
                        if (hotkey.canExecute)
                        {
                             if (!(hotkey.callback == null)) 
                            {
                                hotkey.callback.Invoke();
                            }
                        }
                    }   
                }
            }
            return CallNextHookEx(HookId, val, wParam, lParam);
        }


        //START OF COPY AND PASTE
        //dll = dynamic link library.
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]//

        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr UnHookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        //END OF COPY AND PASTE
        
    }


}
