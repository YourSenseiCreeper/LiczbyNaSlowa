﻿using LiczbyNaSlowaNETCore;

namespace LiczbyNaSlowaNetCore.Interfaces
{
    public enum DeflationPhraseType { BeforeComma = 1, AfterComma };

    /// <summary>
    ///     Interface for classes that define deflation table for specific currency.
    /// </summary>
    public interface ICurrencyDeflation
    {
        /// <summary>
        ///     Current currency code as stands in ISO 4217
        /// </summary>
        Currency CurrencyCode { get; }

        string GetDeflationPhrase(DeflationPhraseType phraseType, int grammarForm, bool withStems);
    }
}