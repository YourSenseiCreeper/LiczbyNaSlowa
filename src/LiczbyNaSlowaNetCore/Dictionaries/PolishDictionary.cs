﻿
// Copyright (c) 2014 Przemek Walkowski

namespace LiczbyNaSlowaNETCore.Dictionaries
{
    using System.Collections.Generic;

    public class PolishDictionary : ICurrencyDictionary
    {
        public List<string> Unity { get; }
        public List<string> OthersTens { get; }
        public List<string> Tens { get; }
        public List<string> Hundreds { get; }
        public string[,] Endings { get; }
        public List<string> Sign { get; }
        public string[,] Current { get; }
        public bool HasStems { get; } = false;
        public PolishDictionary()
        {
            Unity = new List<string>
                {
                    "", "jeden", "dwa", "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec","zero"
                };

            OthersTens = new List<string>
                {
                    "", "jedenascie", "dwanascie", "trzynascie", "czternascie", "pietnascie", "szesnascie", "siedemnascie", "osiemnascie", "dziewietnascie"
                };

            Tens = new List<string>
                {
                    "", "dziesiec", "dwadziescia", "trzydziesci", "czterdziesci", "piecdziesiat", "szescdziesiat", "siedemdziesiat", "osiemdziesiat", "dziewiecdziesiat"
                };

            Hundreds = new List<string>
                {
                    "", "sto", "dwiescie", "trzysta", "czterysta", "piecset", "szescset", "siedemset", "osiemset", "dziewiecset"
                };

            Endings = new[,]
            {
                {"","",""},
                {"tysiac","tysiace","tysiecy"},
                {"milion","miliony","milionow"},
                {"miliard","miliardy","miliardow"},
                {"bilion","biliony","bilionow"},
                {"biliard","biliardy","biliardow"}
            };

            Sign = new List<string>
            {
                "plus", "minus"
            };

            Current = new[,]
            {
                {"","",""},
                {"zloty","zlote","zlotych"},
                {"grosz","grosze","groszy"}
            };
        }

    }
}