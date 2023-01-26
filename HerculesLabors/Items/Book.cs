using System;
using System.Runtime.InteropServices.JavaScript;

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
            if (c == ' ') return '-'.ToString();
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
            if ((65 < c && c > 90) || (97 < c && c > 172))
            {
                return c.ToString();
            }

            return "*Cling**Cling*";
        }

        private static string Anyone(char c)
        {
            return c.ToString();
        }

        public static Lexicon GetLexicon(string god)
        {
            int i = 0;
            string str = "";
            while (i < god.Length && ZeusOne(god[i]) == god[i].ToString())
            {
                i++;
                if(i == god.Length) return ZeusOne;
            }

            i = 0;
            while (i < god.Length && HermesOne(god[i]) == god[i].ToString())
            {
                i++;
                if(i == god.Length) return HermesOne;
            }
            
            i = 0;
            while (i < god.Length && HadesOne(god[i]) == god[i].ToString())
            {
                i++;
                if(i == god.Length) return HadesOne;
            }
            
            i = 0;
            while (i < god.Length && AthenaOne(god[i]) == god[i].ToString())
            {
                i++;
                if(i == god.Length) return AthenaOne;
            }
            
            i = 0;
            while (i < god.Length && PoseidonOne(god[i]) == god[i].ToString())
            {
                i++;
                if(i == god.Length) return PoseidonOne;
            }
            
            i = 0;
            while (i < god.Length && HephaestusOne(god[i]) == god[i].ToString())
            {
                i++;
                if(i == god.Length) return HephaestusOne;
            }

            return Anyone;
        }

        public void PrintBook(string data)
        {
            foreach (var i in data)
            {
                Console.Write(Lexic(data[i]));
            }
            Console.WriteLine("");
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