using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class Driver
    {
        static void Main(string[] args) 
        {
            MainMenu menu = new MainMenu();
            menu.DisplayMenu();
        }
    }
    class MainMenu
    {
        Boolean exit;

        public void DisplayMenu()
        {
            while(!exit)
            {
                Console.Clear();
                ReadMenu();
                int choice = ReceiveInput();
                PerformAction(choice);
            }
            while(exit)
            {
                Console.Clear();
                break;
            }
        }
        public void ReadMenu()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("MainScreen.txt");
                line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        private int ReceiveInput()
        {
            int choice = -1;
            if(choice < 0 || choice > 5)
            {
                choice = Int32.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
            return choice;
        }
        private void PerformAction(int choice)
        {
            switch(choice)
            {
                case 0:
                    exit = true;
                    Console.WriteLine("Thank you for using the Enigma Machine.");
                    Environment.Exit(0);
                    break;
                case 1:
                    RunEncryptor();
                    break;
                case 2:
                    RunDecryptor();
                    break;
                case 3:
                    RunLetterSet();
                    break;
                case 4:
                    Console.WriteLine("HTML Screen: Work In Progress");
                    break;
                case 5:
                    DisplayCredits();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
        public void RunEncryptor()
        {
            EncryptMenu encryptmenu = new EncryptMenu();
            encryptmenu.DisplayMenu();
        }
        public void RunDecryptor()
        {
            RunDecryptMenu decryptmenu = new RunDecryptMenu();
            decryptmenu.RunInheritedClass();
        }
        public void RunLetterSet()
        {
            RunLetterSetMenu lettersetmenu = new RunLetterSetMenu();
            lettersetmenu.RunInheritedClass();
        }
        public void DisplayCredits()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("Credits.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
    class Interpreter
    {
        
        
    }
}
