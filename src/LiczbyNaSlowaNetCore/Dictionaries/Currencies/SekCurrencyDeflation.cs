﻿using System.Collections.Generic;

namespace LiczbyNaSlowaNETCore.Dictionaries.Currencies
{
    public class SekCurrencyDeflation : BaseCurrencyDeflation, ICurrencyNotMaleDeflectionBeforeComma
    {
        public override Currency CurrencyCode => Currency.SEK;

        public SekCurrencyDeflation()
            : base(
                  new[ , ]
                    {
                        {"", "", ""},
                        {"korona szwedzka", "korony szwedzkie", "koron szwedzkich"},
                        {"øre", "øre", "øre"} 
                    },
                  new[ , ]
                    {
                        {"", "", ""},
                        {"korona szwedzka", "korony szwedzkie", "koron szwedzkich"},
                        {"øre", "øre", "øre"}
                    } )
        {

        }

        public List<string> GetBeforeCommaUnity( bool withStems )
        {
            if( withStems )
            {
                return new List<string>
                {
                    "","jedna","dwie" , "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć","zero"
                };
            }
            else
            {
                return new List<string>
                {
                    "","jedna","dwie" , "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec","zero"
                };
            }
        }
    }
}