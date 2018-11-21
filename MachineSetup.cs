using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
    class MachineSetup
    {
        
    }
    public class LetterSet
    {
        private static char[] letterset;
        static string[] lines;
        static string linesString = lines.ToString();
        
        public static string[] Lines
        {
            get { return lines; }
            set
            {
                lines = File.ReadAllLines("Letterset.txt");
            }
        }
        public static char[] Letter_Set
        {
            get { return letterset; }
            set { letterset = linesString.ToCharArray(); ; }
        }
    }
    class Rotor
    {
        private static char[] letterset = LetterSet.Letter_Set;
        private static int Base = letterset.Length;

        private int inputRotor { get; }
        private int Key { get; }
        private int Offset { get; set; }
        

        public Rotor()
        {
            inputRotor = (Key / Base);
            Offset = Key - (Base * inputRotor);
            Key = 67;
            Base = 7;
            Offset = 67 - (7 * 9);
        }
    }
    static class Plugboard
    {
        private static char[] letterset = LetterSet.Letter_Set;
        private static int Base = letterset.Length;
        private static int Offset { get; set; }
        private static int Index { get; set; }
        private static int NewIndex { get; set; }

        public static void ScramblePlug()
        {
            int value = Base - (Offset + Index);
            if (value > 0)
                NewIndex = Base - value;
            else
                NewIndex = value * -1;
        }
        public static void PlugboardConfig()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("Plugboard.txt");
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
}
