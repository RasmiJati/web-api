﻿
public class Rootobject
{
    public Country[] Property1 { get; set; }
}

public class Country
{
    public Name name { get; set; }
    public string[] tld { get; set; }
    public string cca2 { get; set; }
    public string ccn3 { get; set; }
    public string cca3 { get; set; }
    public string cioc { get; set; }
    public bool independent { get; set; }
    public string status { get; set; }
    public bool unMember { get; set; }
    public Currencies currencies { get; set; }
    public Idd idd { get; set; }
    public string[] capital { get; set; }
    public string[] altSpellings { get; set; }
    public string region { get; set; }
    public string subregion { get; set; }
    public Languages languages { get; set; }
    public Translations translations { get; set; }
    public float[] latlng { get; set; }
    public bool landlocked { get; set; }
    public string[] borders { get; set; }
    public float area { get; set; }
    public Demonyms demonyms { get; set; }
    public string flag { get; set; }
    public Maps maps { get; set; }
    public int population { get; set; }
    public Gini gini { get; set; }
    public string fifa { get; set; }
    public Car car { get; set; }
    public string[] timezones { get; set; }
    public string[] continents { get; set; }
    public Flags flags { get; set; }
    public Coatofarms coatOfArms { get; set; }
    public string startOfWeek { get; set; }
    public Capitalinfo capitalInfo { get; set; }
    public Postalcode postalCode { get; set; }
}
public class Name : GenericName<string, string, NativeName>
{
    public string common { get; set; }
    public string official { get; set; }
    public NativeName native { get; set; }
}
public class NativeName : GenericNativeName<string>
{
    public string common { get; set; }
    public string official { get; set; }
}

public class Currencies : GenericNativeName<CurrencyName>
{
    public CurrencyName currency { get; set; }
}

public class CurrencyName : GenericNativeName<string>
{
    public string name { get; set; }
    public string symbol { get; set; }
}
public class Idd
{
    public string root { get; set; }
    public string[] suffixes { get; set; }
}

public class Languages : GenericNativeName<string>
{
    public string languageName { get; set; }
}


public class Translations : GenericNativeName<Translation>
{
    public Translation translation { get; set; }
}

public class Translation : GenericNativeName<string>
{
    public string official { get; set; }
    public string common { get; set; }
}
public class Demonyms : GenericNativeName<DemonymsSub>
{
    public DemonymsSub demonyms { get; set; }
}

public class DemonymsSub: GenericNativeName<string>
{
    public string f { get; set; }
    public string m { get; set; }
}


public class Maps : GenericNativeName<string>
{
    public string maps { get; set; }
}

public class Gini : GenericNativeName<float>
{
    public float year { get; set; }
}

public class Car
{
    public string[] signs { get; set; }
    public string side { get; set; }
}

public class Flags
{
    public string png { get; set; }
    public string svg { get; set; }
    public string alt { get; set; }
}

public class Coatofarms
{
    public string png { get; set; }
    public string svg { get; set; }
}

public class Capitalinfo
{
    public float[] latlng { get; set; }
}

public class Postalcode : GenericNativeName<string>
{
    public string postalCode { get; set; }
}