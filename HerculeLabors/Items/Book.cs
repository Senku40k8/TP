using System;

namespace HerculesLabors.Items
{
    public class Book : Item
    {
        public delegate string Lexicon(char c);
        
        public Lexicon Lexic { get; private set;}

        public Book(string name, Lexicon lexic, int weight)
        {
            throw new NotImplementedException();
        }

        private static string ZeusOne(char c)
        {
            string str = c.ToString();
            return str.ToUpper();
        }

        private static string HermesOne(char c)
        {
            return ((c % 2) + 48).ToString();
        }

        private static string HadesOne(char c)
        {
            if (c == 'a') return "4";
            if (c == 'A') return "4";
            if (c == 'o') return "0";
            if (c == 'O') return "0";
            if (c == 'f') return "f";
            return "f";
        }

        private static string AthenaOne(char c)
        {
            if (c == '') return '-'.ToString();
            if (c == '-') return '_'.ToString();
            return c.ToString();
        }

        private static string PoseidonOne(char c)
        {
            string str = "";
            for (int i = 0; i < c%4; i++)
            {
                str += c;
            }

            return str;
        }

        private static string HephaestusOne(char c)
        {
            throw new NotImplementedException();
        }

        private static string Anyone(char c)
        {
            throw new NotImplementedException();
        }

        public static Lexicon GetLexicon(string god)
        {
            throw new NotImplementedException();
        }

        public void PrintBook(string data)
        {
            throw new NotImplementedException();
        }

        private void UpgradeBooks()
        {
            throw new NotImplementedException();
        }

        public override Upgrade UpgradeMe()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}