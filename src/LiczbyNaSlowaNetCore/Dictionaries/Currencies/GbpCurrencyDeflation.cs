﻿namespace LiczbyNaSlowaNETCore.Dictionaries.Currencies
{
    public class GbpCurrencyDeflation : BaseCurrencyDeflation
    {
        public override Currency CurrencyCode => Currency.GBP;

        public GbpCurrencyDeflation()
            : base(
                 new[,]
                {
                    { "", "", "" },
                    { "funt brytyjski", "funty brytyjskie", "funtów brytyjskich" },
                    { "pens", "pensy", "pensów" }
                })
        {
        }
    }
}
