﻿using System;
using System.Runtime.InteropServices.JavaScript;

namespace HerculesLabors.Items
{
    public class Book : Item
    {
        public delegate string Lexicon(char c);
        
        public Lexicon Lexic { get; private set;}

        public Book(string name, Lexicon lexic, int weight)
        {
            Name = name;
            Weight = weight;
        }

        private static string ZeusOne(char c)
        {
            if (c > 96 && c < 123)
            {
                return "" + (c - 32);
            }
            //string str = c.ToString();
            //return str.ToUpper();
            return "";
        }

        private static string HermesOne(char c)
        {
            if (c % 2 == 0) return 0.ToString();
            return 1.ToString();
            //return ((c % 2) + 48).ToString();
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
            if (('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z'))
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
                Console.Write(Lexic.Invoke);
                //Console.Write(Lexic(data[i].));
            }
            Console.WriteLine("");
        }

        private void UpgradeBooks()
        {
            if (Lexic == Anyone)
            {
                int mod = Name.Length%6;
                if (mod == 0)
                {
                    Name = "Book of Zeus";
                    Lexic = ZeusOne;
                }
                
                else if (mod == 1)
                {
                    Name = "Book of Hermes";
                    Lexic = HermesOne;
                }
                
                else if (mod == 2)
                {
                    Name = "Book of Hades";
                    Lexic = HadesOne;
                }
                
                else if (mod == 3)
                {
                    Name = "Book of Athena";
                    Lexic = AthenaOne;
                }
                
                else if (mod == 4)
                {
                    Name = "Book of Poseidon";
                    Lexic = PoseidonOne;
                }
                
                else if (mod == 5)
                {
                    Name = "Book of Hephaestus";
                    Lexic = HephaestusOne;
                }
            }
        }

        public override Upgrade UpgradeMe()
        {
            return UpgradeBooks;
        }

        public override string ToString()
        {
            return Name + ", " + Weight;
        }
    }
}