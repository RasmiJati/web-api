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

public class Languages
{
    public string afr { get; set; }
    public string eng { get; set; }
    public string nbl { get; set; }
    public string nso { get; set; }
    public string sot { get; set; }
    public string ssw { get; set; }
    public string tsn { get; set; }
    public string tso { get; set; }
    public string ven { get; set; }
    public string xho { get; set; }
    public string zul { get; set; }
    public string nor { get; set; }
    public string smo { get; set; }
    public string fra { get; set; }
    public string nld { get; set; }
    public string pap { get; set; }
    public string por { get; set; }
    public string pov { get; set; }
    public string kor { get; set; }
    public string grn { get; set; }
    public string spa { get; set; }
    public string kon { get; set; }
    public string lin { get; set; }
    public string ara { get; set; }
    public string som { get; set; }
    public string cal { get; set; }
    public string cha { get; set; }
    public string zho { get; set; }
    public string msa { get; set; }
    public string tam { get; set; }
    public string pih { get; set; }
    public string aym { get; set; }
    public string que { get; set; }
    public string bos { get; set; }
    public string hrv { get; set; }
    public string srp { get; set; }
    public string rus { get; set; }
    public string uzb { get; set; }
    public string nya { get; set; }
    public string bwg { get; set; }
    public string kck { get; set; }
    public string khi { get; set; }
    public string ndc { get; set; }
    public string nde { get; set; }
    public string sna { get; set; }
    public string toi { get; set; }
    public string zib { get; set; }
    public string swa { get; set; }
    public string urd { get; set; }
    public string fij { get; set; }
    public string hif { get; set; }
    public string nrf { get; set; }
    public string sin { get; set; }
    public string bel { get; set; }
    public string lua { get; set; }
    public string tur { get; set; }
    public string tvl { get; set; }
    public string aze { get; set; }
    public string kin { get; set; }
    public string hin { get; set; }
    public string isl { get; set; }
    public string bul { get; set; }
    public string sqi { get; set; }
    public string zdj { get; set; }
    public string nau { get; set; }
    public string ron { get; set; }
    public string mah { get; set; }
    public string nep { get; set; }
    public string dan { get; set; }
    public string fao { get; set; }
    public string gil { get; set; }
    public string bis { get; set; }
    public string hun { get; set; }
    public string crs { get; set; }
    public string ell { get; set; }
    public string heb { get; set; }
    public string vie { get; set; }
    public string slv { get; set; }
    public string fas { get; set; }
    public string deu { get; set; }
    public string her { get; set; }
    public string hgm { get; set; }
    public string kwn { get; set; }
    public string loz { get; set; }
    public string ndo { get; set; }
    public string mon { get; set; }
    public string swe { get; set; }
    public string kat { get; set; }
    public string tgk { get; set; }
    public string tuk { get; set; }
    public string ukr { get; set; }
    public string slk { get; set; }
    public string ita { get; set; }
    public string cnr { get; set; }
    public string est { get; set; }
    public string mfe { get; set; }
    public string tha { get; set; }
    public string nfr { get; set; }
    public string tir { get; set; }
    public string kaz { get; set; }
    public string ber { get; set; }
    public string mya { get; set; }
    public string pau { get; set; }
    public string ces { get; set; }
    public string jam { get; set; }
    public string kir { get; set; }
    public string ltz { get; set; }
    public string pol { get; set; }
    public string jpn { get; set; }
    public string glv { get; set; }
    public string run { get; set; }
    public string hmo { get; set; }
    public string tpi { get; set; }
    public string prs { get; set; }
    public string pus { get; set; }
    public string sag { get; set; }
    public string lat { get; set; }
    public string tet { get; set; }
    public string de { get; set; }
    public string kal { get; set; }
    public string lao { get; set; }
    public string gsw { get; set; }
    public string roh { get; set; }
    public string gle { get; set; }
    public string ben { get; set; }
    public string hat { get; set; }
    public string fil { get; set; }
    public string nno { get; set; }
    public string nob { get; set; }
    public string smi { get; set; }
    public string rar { get; set; }
    public string cat { get; set; }
    public string tkl { get; set; }
    public string ton { get; set; }
    public string mlg { get; set; }
    public string hye { get; set; }
    public string bjz { get; set; }
    public string lit { get; set; }
    public string mlt { get; set; }
    public string lav { get; set; }
    public string fin { get; set; }
    public string mri { get; set; }
    public string nzs { get; set; }
    public string ind { get; set; }
    public string div { get; set; }
    public string mey { get; set; }
    public string khm { get; set; }
    public string arc { get; set; }
    public string ckb { get; set; }
    public string dzo { get; set; }
    public string niu { get; set; }
    public string mkd { get; set; }
    public string amh { get; set; }
}

public class Translations
{
    public Ara1 ara { get; set; }
    public Bre bre { get; set; }
    public Ces1 ces { get; set; }
    public Cym cym { get; set; }
    public Deu1 deu { get; set; }
    public Est1 est { get; set; }
    public Fin1 fin { get; set; }
    public Fra1 fra { get; set; }
    public Hrv1 hrv { get; set; }
    public Hun1 hun { get; set; }
    public Ita1 ita { get; set; }
    public Jpn1 jpn { get; set; }
    public Kor1 kor { get; set; }
    public Nld1 nld { get; set; }
    public Per per { get; set; }
    public Pol1 pol { get; set; }
    public Por1 por { get; set; }
    public Rus1 rus { get; set; }
    public Slk1 slk { get; set; }
    public Spa1 spa { get; set; }
    public Srp1 srp { get; set; }
    public Swe1 swe { get; set; }
    public Tur1 tur { get; set; }
    public Urd1 urd { get; set; }
    public Zho1 zho { get; set; }
}

public class Ara1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Bre
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Ces1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Cym
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Deu1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Est1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Fin1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Fra1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Hrv1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Hun1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Ita1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Jpn1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Kor1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Nld1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Per
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Pol1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Por1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Rus1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Slk1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Spa1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Srp1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Swe1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Tur1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Urd1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Zho1
{
    public string official { get; set; }
    public string common { get; set; }
}

public class Demonyms
{
    public Eng1 eng { get; set; }
    public Fra2 fra { get; set; }
}

public class Eng1
{
    public string f { get; set; }
    public string m { get; set; }
}

public class Fra2
{
    public string f { get; set; }
    public string m { get; set; }
}

public class Maps
{
    public string googleMaps { get; set; }
    public string openStreetMaps { get; set; }
}

public class Gini
{
    public float _2014 { get; set; }
    public float _2013 { get; set; }
    public float _2015 { get; set; }
    public float _2010 { get; set; }
    public float _2019 { get; set; }
    public float _2011 { get; set; }
    public float _2017 { get; set; }
    public float _2018 { get; set; }
    public float _2003 { get; set; }
    public float _2016 { get; set; }
    public float _2012 { get; set; }
    public float _2005 { get; set; }
    public float _1999 { get; set; }
    public float _1992 { get; set; }
    public float _2006 { get; set; }
    public float _1998 { get; set; }
    public float _2004 { get; set; }
    public float _2009 { get; set; }
    public float _2008 { get; set; }
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

public class Postalcode
{
    public string format { get; set; }
    public string regex { get; set; }
}