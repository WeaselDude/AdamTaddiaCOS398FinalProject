using GlobalKeyhook.Hotkeys;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace GlobalKeyhook
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {


            InitializeComponent();
            HotKeyHandler.SystemHookSetup();

            //these create hotkeys which are handled by the hotkey handler. The last paramater in each new Globalhotkey also write the key to the file
            GlobalHotkey spaceKey = new GlobalHotkey(ModifierKeys.None, Key.Space, spaceWritten);
            GlobalHotkey aKey = new GlobalHotkey(ModifierKeys.None, Key.A, aWritten);
            GlobalHotkey bKey = new GlobalHotkey(ModifierKeys.None, Key.B, bWritten);
            GlobalHotkey cKey = new GlobalHotkey(ModifierKeys.None, Key.C, cWritten);
            GlobalHotkey dKey = new GlobalHotkey(ModifierKeys.None, Key.D, dWritten);
            GlobalHotkey eKey = new GlobalHotkey(ModifierKeys.None, Key.E, eWritten);
            GlobalHotkey fKey = new GlobalHotkey(ModifierKeys.None, Key.F, fWritten);
            GlobalHotkey gKey = new GlobalHotkey(ModifierKeys.None, Key.G, gWritten);
            GlobalHotkey hKey = new GlobalHotkey(ModifierKeys.None, Key.H, hWritten);
            GlobalHotkey iKey = new GlobalHotkey(ModifierKeys.None, Key.I, iWritten);
            GlobalHotkey jKey = new GlobalHotkey(ModifierKeys.None, Key.J, jWritten);
            GlobalHotkey kKey = new GlobalHotkey(ModifierKeys.None, Key.K, kWritten);
            GlobalHotkey lKey = new GlobalHotkey(ModifierKeys.None, Key.L, lWritten);
            GlobalHotkey mKey = new GlobalHotkey(ModifierKeys.None, Key.M, mWritten);
            GlobalHotkey nKey = new GlobalHotkey(ModifierKeys.None, Key.N, nWritten);
            GlobalHotkey oKey = new GlobalHotkey(ModifierKeys.None, Key.O, oWritten);
            GlobalHotkey pKey = new GlobalHotkey(ModifierKeys.None, Key.P, pWritten);
            GlobalHotkey qKey = new GlobalHotkey(ModifierKeys.None, Key.Q, qWritten);
            GlobalHotkey rKey = new GlobalHotkey(ModifierKeys.None, Key.R, rWritten);
            GlobalHotkey sKey = new GlobalHotkey(ModifierKeys.None, Key.S, sWritten);
            GlobalHotkey tKey = new GlobalHotkey(ModifierKeys.None, Key.T, tWritten);
            GlobalHotkey uKey = new GlobalHotkey(ModifierKeys.None, Key.U, uWritten);
            GlobalHotkey vKey = new GlobalHotkey(ModifierKeys.None, Key.V, vWritten);
            GlobalHotkey wKey = new GlobalHotkey(ModifierKeys.None, Key.W, wWritten);
            GlobalHotkey xKey = new GlobalHotkey(ModifierKeys.None, Key.X, xWritten);
            GlobalHotkey yKey = new GlobalHotkey(ModifierKeys.None, Key.Y, yWritten);
            GlobalHotkey zKey = new GlobalHotkey(ModifierKeys.None, Key.Z, zWritten);

            GlobalHotkey AKey = new GlobalHotkey(ModifierKeys.Shift, Key.A, AWritten);
            GlobalHotkey BKey = new GlobalHotkey(ModifierKeys.Shift, Key.B, BWritten);
            GlobalHotkey CKey = new GlobalHotkey(ModifierKeys.Shift, Key.C, CWritten);
            GlobalHotkey DKey = new GlobalHotkey(ModifierKeys.Shift, Key.D, DWritten);
            GlobalHotkey EKey = new GlobalHotkey(ModifierKeys.Shift, Key.E, EWritten);
            GlobalHotkey FKey = new GlobalHotkey(ModifierKeys.Shift, Key.F, FWritten);
            GlobalHotkey GKey = new GlobalHotkey(ModifierKeys.Shift, Key.G, GWritten);
            GlobalHotkey HKey = new GlobalHotkey(ModifierKeys.Shift, Key.H, HWritten);
            GlobalHotkey IKey = new GlobalHotkey(ModifierKeys.Shift, Key.I, IWritten);
            GlobalHotkey JKey = new GlobalHotkey(ModifierKeys.Shift, Key.J, JWritten);
            GlobalHotkey KKey = new GlobalHotkey(ModifierKeys.Shift, Key.K, KWritten);
            GlobalHotkey LKey = new GlobalHotkey(ModifierKeys.Shift, Key.L, LWritten);
            GlobalHotkey MKey = new GlobalHotkey(ModifierKeys.Shift, Key.M, MWritten);
            GlobalHotkey NKey = new GlobalHotkey(ModifierKeys.Shift, Key.N, NWritten);
            GlobalHotkey OKey = new GlobalHotkey(ModifierKeys.Shift, Key.O, OWritten);
            GlobalHotkey PKey = new GlobalHotkey(ModifierKeys.Shift, Key.P, PWritten);
            GlobalHotkey QKey = new GlobalHotkey(ModifierKeys.Shift, Key.Q, QWritten);
            GlobalHotkey RKey = new GlobalHotkey(ModifierKeys.Shift, Key.R, RWritten);
            GlobalHotkey SKey = new GlobalHotkey(ModifierKeys.Shift, Key.S, SWritten);
            GlobalHotkey TKey = new GlobalHotkey(ModifierKeys.Shift, Key.T, TWritten);
            GlobalHotkey UKey = new GlobalHotkey(ModifierKeys.Shift, Key.U, UWritten);
            GlobalHotkey VKey = new GlobalHotkey(ModifierKeys.Shift, Key.V, VWritten);
            GlobalHotkey WKey = new GlobalHotkey(ModifierKeys.Shift, Key.W, WWritten);
            GlobalHotkey XKey = new GlobalHotkey(ModifierKeys.Shift, Key.X, XWritten);
            GlobalHotkey YKey = new GlobalHotkey(ModifierKeys.Shift, Key.Y, YWritten);
            GlobalHotkey ZKey = new GlobalHotkey(ModifierKeys.Shift, Key.Z, ZWritten);

            GlobalHotkey oneKey = new GlobalHotkey(ModifierKeys.None, Key.D1, oneWritten);
            GlobalHotkey twoKey = new GlobalHotkey(ModifierKeys.None, Key.D2, twoWritten);
            GlobalHotkey threeKey = new GlobalHotkey(ModifierKeys.None, Key.D3, threeWritten);
            GlobalHotkey fourKey = new GlobalHotkey(ModifierKeys.None, Key.D4, fourWritten);
            GlobalHotkey fiveKey = new GlobalHotkey(ModifierKeys.None, Key.D5, fiveWritten);
            GlobalHotkey sixKey = new GlobalHotkey(ModifierKeys.None, Key.D6, sixWritten);
            GlobalHotkey sevenKey = new GlobalHotkey(ModifierKeys.None, Key.D7, sevenWritten);
            GlobalHotkey eightKey = new GlobalHotkey(ModifierKeys.None, Key.D8, eightWritten);
            GlobalHotkey nineKey = new GlobalHotkey(ModifierKeys.None, Key.D9, nineWritten);
            GlobalHotkey zeroKey = new GlobalHotkey(ModifierKeys.None, Key.D0, zeroWritten);

            HotKeyHandler.AddHotKey(spaceKey);
            HotKeyHandler.AddHotKey(oneKey);
            HotKeyHandler.AddHotKey(twoKey);
            HotKeyHandler.AddHotKey(threeKey);
            HotKeyHandler.AddHotKey(fourKey);
            HotKeyHandler.AddHotKey(fiveKey);
            HotKeyHandler.AddHotKey(sixKey);
            HotKeyHandler.AddHotKey(sevenKey);
            HotKeyHandler.AddHotKey(eightKey);
            HotKeyHandler.AddHotKey(nineKey);
            HotKeyHandler.AddHotKey(zeroKey);


            HotKeyHandler.AddHotKey(aKey);
            HotKeyHandler.AddHotKey(bKey);
            HotKeyHandler.AddHotKey(cKey);
            HotKeyHandler.AddHotKey(dKey);
            HotKeyHandler.AddHotKey(eKey);
            HotKeyHandler.AddHotKey(fKey);
            HotKeyHandler.AddHotKey(gKey);
            HotKeyHandler.AddHotKey(hKey);
            HotKeyHandler.AddHotKey(iKey);
            HotKeyHandler.AddHotKey(jKey);
            HotKeyHandler.AddHotKey(kKey);
            HotKeyHandler.AddHotKey(lKey);
            HotKeyHandler.AddHotKey(mKey);
            HotKeyHandler.AddHotKey(nKey);
            HotKeyHandler.AddHotKey(oKey);
            HotKeyHandler.AddHotKey(pKey);
            HotKeyHandler.AddHotKey(qKey);
            HotKeyHandler.AddHotKey(rKey);
            HotKeyHandler.AddHotKey(sKey);
            HotKeyHandler.AddHotKey(tKey);
            HotKeyHandler.AddHotKey(uKey);
            HotKeyHandler.AddHotKey(vKey);
            HotKeyHandler.AddHotKey(wKey);
            HotKeyHandler.AddHotKey(xKey);
            HotKeyHandler.AddHotKey(yKey);
            HotKeyHandler.AddHotKey(zKey);

            HotKeyHandler.AddHotKey(AKey);
            HotKeyHandler.AddHotKey(BKey);
            HotKeyHandler.AddHotKey(CKey);
            HotKeyHandler.AddHotKey(DKey);
            HotKeyHandler.AddHotKey(EKey);
            HotKeyHandler.AddHotKey(FKey);
            HotKeyHandler.AddHotKey(GKey);
            HotKeyHandler.AddHotKey(HKey);
            HotKeyHandler.AddHotKey(IKey);
            HotKeyHandler.AddHotKey(JKey);
            HotKeyHandler.AddHotKey(KKey);
            HotKeyHandler.AddHotKey(LKey);
            HotKeyHandler.AddHotKey(MKey);
            HotKeyHandler.AddHotKey(NKey);
            HotKeyHandler.AddHotKey(OKey);
            HotKeyHandler.AddHotKey(PKey);
            HotKeyHandler.AddHotKey(QKey);
            HotKeyHandler.AddHotKey(RKey);
            HotKeyHandler.AddHotKey(SKey);
            HotKeyHandler.AddHotKey(TKey);
            HotKeyHandler.AddHotKey(UKey);
            HotKeyHandler.AddHotKey(VKey);
            HotKeyHandler.AddHotKey(WKey);
            HotKeyHandler.AddHotKey(XKey);
            HotKeyHandler.AddHotKey(YKey);
            HotKeyHandler.AddHotKey(ZKey);

            Closing += MainWindow_Closing;


        }



        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            throw new System.NotImplementedException();
        }


        //START OF NUMBER FUNCTIONS

        public void spaceWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed(" ");
            writer.Write(" ");
            writer.Close();
        }
        public void oneWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("1");
            writer.Write("1");
            writer.Close();
        }
        public void twoWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("2");
            writer.Write("2");
            writer.Close();
        }
        public void threeWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("3");
            writer.Write("3");
            writer.Close();
        }
        public void fourWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("4");
            writer.Write("4");
            writer.Close();
        }
        public void fiveWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("5");
            writer.Write("5");
            writer.Close();
        }
        public void sixWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("6");
            writer.Write("6");
            writer.Close();
        }
        public void sevenWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("7");
            writer.Write("7");
            writer.Close();
        }
        public void eightWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("8");
            writer.Write("8");
            writer.Close();
        }
        public void nineWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("9");
            writer.Write("9");
            writer.Close();
        }
        public void zeroWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("0");
            writer.Write("0");
            writer.Close();
        }
        //END OF NUMBER FUNCTION
        //START OF LOWER CASE ALPHABET FUNCTIONS
        public void aWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("a");
            writer.Write("a");
            writer.Close();
        }

        public void bWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("b");
            writer.Write("b");
            writer.Close();
        }

        public void cWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("c");
            writer.Write("c");
            writer.Close();
        }

        public void dWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("d");
            writer.Write("d");
            writer.Close();
        }

        public void eWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("e");
            writer.Write("e");
            writer.Close();
        }

        public void fWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("f");
            writer.Write("f");
            writer.Close();
        }

        public void gWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("g");
            writer.Write("g");
            writer.Close();
        }

        public void hWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("h");
            writer.Write("h");
            writer.Close();
        }

        public void iWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("i");
            writer.Write("i");
            writer.Close();
        }

        public void jWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("j");
            writer.Write("j");
            writer.Close();
        }

        public void kWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("k");
            writer.Write("k");
            writer.Close();
        }

        public void lWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("l");
            writer.Write("l");
            writer.Close();
        }

        public void mWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("m");
            writer.Write("m");
            writer.Close();
        }

        public void nWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("n");
            writer.Write("n");
            writer.Close();
        }

        public void oWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("o");
            writer.Write("o");
            writer.Close();
        }

        public void pWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("p");
            writer.Write("p");
            writer.Close();
        }

        public void qWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("q");
            writer.Write("q");
            writer.Close();
        }

        public void rWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("r");
            writer.Write("r");
            writer.Close();
        }

        public void sWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("s");
            writer.Write("s");
            writer.Close();
        }

        public void tWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("t");
            writer.Write("t");
            writer.Close();
        }

        public void uWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("t");
            writer.Write("t");
            writer.Close();
        }
        public void vWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("v");
            writer.Write("v");
            writer.Close();
        }

        public void wWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("w");
            writer.Write("w");
            writer.Close();
        }

        public void xWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("x");
            writer.Write("x");
            writer.Close();
        }

        public void yWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("y");
            writer.Write("y");
            writer.Close();

        }

        public void zWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("z");
            writer.Write("z");
            writer.Close();
        }


        //END OF LOWER CASE ALPHABET

        //START OF UPPER CASE ALPHABET
        public void AWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("A");
            writer.Write("A");
            writer.Close();
        }

        public void BWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("B");
            writer.Write("B");
            writer.Close();
        }

        public void CWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("C");
            writer.Write("C");
            writer.Close();
        }

        public void DWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("D");
            writer.Write("D");
            writer.Close();
        }

        public void EWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("E");
            writer.Write("E");
            writer.Close();
        }

        public void FWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("F");
            writer.Write("F");
            writer.Close();
        }

        public void GWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("G");
            writer.Write("G");
            writer.Close();
        }

        public void HWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("H");
            writer.Write("H");
            writer.Close();
        }

        public void IWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("I");
            writer.Write("I");
            writer.Close();
        }

        public void JWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("J");
            writer.Write("J");
            writer.Close();
        }

        public void KWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("K");
            writer.Write("K");
            writer.Close();
        }

        public void LWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("L");
            writer.Write("L");
            writer.Close();
        }

        public void MWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("M");
            writer.Write("M");
            writer.Close();
        }

        public void NWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("N");
            writer.Write("N");
            writer.Close();
        }

        public void OWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("O");
            writer.Write("O");
            writer.Close();
        }

        public void PWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("P");
            writer.Write("P");
            writer.Close();
        }

        public void QWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("Q");
            writer.Write("Q");
            writer.Close();
        }

        public void RWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("R");
            writer.Write("R");
            writer.Close();
        }

        public void SWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("S");
            writer.Write("S");
            writer.Close();
        }

        public void TWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("T");
            writer.Write("T");
            writer.Close();
        }

        public void UWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("U");
            writer.Write("U");
            writer.Close();
        }
        public void VWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("V");
            writer.Write("V");
            writer.Close();
        }

        public void WWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("W");
            writer.Write("W");
            writer.Close();
        }

        public void XWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("X");
            writer.Write("X");
            writer.Close();
        }

        public void YWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("Y");
            writer.Write("Y");
            writer.Close();
        }

        public void ZWritten()
        {
            //creates streamwriter used for writing to file
            StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\LogForAdamTaddiasProgram.txt", append: true);
            //CREATING A NEW STREAMWRITER FOR EVERY SINGLE LINE IS SO BAD AND SO MUCH RESOURCE HOGGING, BUT HERE I AM, DOING IT
            MarkAsPressed("Z");
            writer.Write("Z");
            writer.Close();
        }
        //END OF UPPER CASE ALPHABET FUNCTIONS

        public void MarkAsPressed(string text)
        {
            keyPressed.Items.Add(text);
        }
    }
}