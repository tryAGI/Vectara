#nullable enable
#pragma warning disable CS1591

namespace Vectara;

public readonly partial struct SearchCorporaParameters
{
    public SearchCorporaParametersVariant1? Value1 => SearchCorporaParametersVariant1;

    public SearchParameters? Value2 => SearchParameters;
}

public readonly partial struct KeyedSearchCorpus
{
    public SearchCorpus? Value1 => SearchCorpus;

    public KeyedSearchCorpusVariant2? Value2 => KeyedSearchCorpusVariant2;
}
