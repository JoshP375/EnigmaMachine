using System;
using System.IO;
using EnigmaMachine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class EncryptMenu
    {
        public Boolean exit; 
        
        public void DisplayMenu()
        {
            while (!exit)
            {
                Console.Clear();
                ReadMenu();
                int choice = ReceiveInput();
                PerformAction(choice);
            }
            while(exit)
            {
                Console.Clear();
                MainMenu gotomenu = new MainMenu();
                gotomenu.DisplayMenu();
            }
        }
        public virtual void ReadMenu()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("EncryptScreen.txt");
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
        public int ReceiveInput()
        {
            int choice = -1;
            if (choice < 0 || choice > 2)
            {
                choice = Int32.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
            return choice;
        }
        public virtual void PerformAction(int choice)
        {
            switch (choice)
            {
                case 0:
                    exit = true;
                    Console.WriteLine("Exiting to Main Menu Screen...");
                    break;
                case 1:
                    DisplayDirections();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
        public void DisplayDirections()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("EncryptDirections.txt");
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
    class LetterSetMenu : EncryptMenu
    {
        public override void ReadMenu()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("LettersetScreen.txt");
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
        public override void PerformAction(int choice)
        {
            switch (choice)
            {
                case 0:
                    exit = true;
                    Console.WriteLine("Exiting to Main Menu Screen...");
                    break;
                case 1:
                    DisplayLetterSet();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
        public void DisplayLetterSet()
        {
            string[] lines = File.ReadAllLines("Letterset.txt");
            Console.WriteLine("The Letter Set is {0}", string.Join(", ", lines));
        }
    }
    class RunLetterSetMenu 
    {
        public void RunInheritedClass()
        {
            LetterSetMenu menu = new LetterSetMenu();
            menu.DisplayMenu();
            menu.ReceiveInput();
        }
    }
    class DecryptMenu : EncryptMenu
    {
        public override void ReadMenu()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("DecryptScreen.txt");
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
        public override void PerformAction(int choice)
        {
            switch (choice)
            {
                case 0:
                    exit = true;
                    Console.WriteLine("Exiting to Main Menu Screen...");
                    break;
                case 1:
                    DisplayDecryptDirections();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
        public void DisplayDecryptDirections()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("DecryptDirections.txt");
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
    class RunDecryptMenu
    {
        public void RunInheritedClass()
        {
            DecryptMenu menu = new DecryptMenu();
            menu.DisplayMenu();
            menu.ReceiveInput();
        }
    }
}
