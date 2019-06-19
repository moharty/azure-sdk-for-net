// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StemmerTokenFilterLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StemmerTokenFilterLanguage
    {
        [EnumMember(Value = "arabic")]
        Arabic,
        [EnumMember(Value = "armenian")]
        Armenian,
        [EnumMember(Value = "basque")]
        Basque,
        [EnumMember(Value = "brazilian")]
        Brazilian,
        [EnumMember(Value = "bulgarian")]
        Bulgarian,
        [EnumMember(Value = "catalan")]
        Catalan,
        [EnumMember(Value = "czech")]
        Czech,
        [EnumMember(Value = "danish")]
        Danish,
        [EnumMember(Value = "dutch")]
        Dutch,
        [EnumMember(Value = "dutchKp")]
        DutchKp,
        [EnumMember(Value = "english")]
        English,
        [EnumMember(Value = "lightEnglish")]
        LightEnglish,
        [EnumMember(Value = "minimalEnglish")]
        MinimalEnglish,
        [EnumMember(Value = "possessiveEnglish")]
        PossessiveEnglish,
        [EnumMember(Value = "porter2")]
        Porter2,
        [EnumMember(Value = "lovins")]
        Lovins,
        [EnumMember(Value = "finnish")]
        Finnish,
        [EnumMember(Value = "lightFinnish")]
        LightFinnish,
        [EnumMember(Value = "french")]
        French,
        [EnumMember(Value = "lightFrench")]
        LightFrench,
        [EnumMember(Value = "minimalFrench")]
        MinimalFrench,
        [EnumMember(Value = "galician")]
        Galician,
        [EnumMember(Value = "minimalGalician")]
        MinimalGalician,
        [EnumMember(Value = "german")]
        German,
        [EnumMember(Value = "german2")]
        German2,
        [EnumMember(Value = "lightGerman")]
        LightGerman,
        [EnumMember(Value = "minimalGerman")]
        MinimalGerman,
        [EnumMember(Value = "greek")]
        Greek,
        [EnumMember(Value = "hindi")]
        Hindi,
        [EnumMember(Value = "hungarian")]
        Hungarian,
        [EnumMember(Value = "lightHungarian")]
        LightHungarian,
        [EnumMember(Value = "indonesian")]
        Indonesian,
        [EnumMember(Value = "irish")]
        Irish,
        [EnumMember(Value = "italian")]
        Italian,
        [EnumMember(Value = "lightItalian")]
        LightItalian,
        [EnumMember(Value = "sorani")]
        Sorani,
        [EnumMember(Value = "latvian")]
        Latvian,
        [EnumMember(Value = "norwegian")]
        Norwegian,
        [EnumMember(Value = "lightNorwegian")]
        LightNorwegian,
        [EnumMember(Value = "minimalNorwegian")]
        MinimalNorwegian,
        [EnumMember(Value = "lightNynorsk")]
        LightNynorsk,
        [EnumMember(Value = "minimalNynorsk")]
        MinimalNynorsk,
        [EnumMember(Value = "portuguese")]
        Portuguese,
        [EnumMember(Value = "lightPortuguese")]
        LightPortuguese,
        [EnumMember(Value = "minimalPortuguese")]
        MinimalPortuguese,
        [EnumMember(Value = "portugueseRslp")]
        PortugueseRslp,
        [EnumMember(Value = "romanian")]
        Romanian,
        [EnumMember(Value = "russian")]
        Russian,
        [EnumMember(Value = "lightRussian")]
        LightRussian,
        [EnumMember(Value = "spanish")]
        Spanish,
        [EnumMember(Value = "lightSpanish")]
        LightSpanish,
        [EnumMember(Value = "swedish")]
        Swedish,
        [EnumMember(Value = "lightSwedish")]
        LightSwedish,
        [EnumMember(Value = "turkish")]
        Turkish
    }
    internal static class StemmerTokenFilterLanguageEnumExtension
    {
        internal static string ToSerializedValue(this StemmerTokenFilterLanguage? value)
        {
            return value == null ? null : ((StemmerTokenFilterLanguage)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StemmerTokenFilterLanguage value)
        {
            switch( value )
            {
                case StemmerTokenFilterLanguage.Arabic:
                    return "arabic";
                case StemmerTokenFilterLanguage.Armenian:
                    return "armenian";
                case StemmerTokenFilterLanguage.Basque:
                    return "basque";
                case StemmerTokenFilterLanguage.Brazilian:
                    return "brazilian";
                case StemmerTokenFilterLanguage.Bulgarian:
                    return "bulgarian";
                case StemmerTokenFilterLanguage.Catalan:
                    return "catalan";
                case StemmerTokenFilterLanguage.Czech:
                    return "czech";
                case StemmerTokenFilterLanguage.Danish:
                    return "danish";
                case StemmerTokenFilterLanguage.Dutch:
                    return "dutch";
                case StemmerTokenFilterLanguage.DutchKp:
                    return "dutchKp";
                case StemmerTokenFilterLanguage.English:
                    return "english";
                case StemmerTokenFilterLanguage.LightEnglish:
                    return "lightEnglish";
                case StemmerTokenFilterLanguage.MinimalEnglish:
                    return "minimalEnglish";
                case StemmerTokenFilterLanguage.PossessiveEnglish:
                    return "possessiveEnglish";
                case StemmerTokenFilterLanguage.Porter2:
                    return "porter2";
                case StemmerTokenFilterLanguage.Lovins:
                    return "lovins";
                case StemmerTokenFilterLanguage.Finnish:
                    return "finnish";
                case StemmerTokenFilterLanguage.LightFinnish:
                    return "lightFinnish";
                case StemmerTokenFilterLanguage.French:
                    return "french";
                case StemmerTokenFilterLanguage.LightFrench:
                    return "lightFrench";
                case StemmerTokenFilterLanguage.MinimalFrench:
                    return "minimalFrench";
                case StemmerTokenFilterLanguage.Galician:
                    return "galician";
                case StemmerTokenFilterLanguage.MinimalGalician:
                    return "minimalGalician";
                case StemmerTokenFilterLanguage.German:
                    return "german";
                case StemmerTokenFilterLanguage.German2:
                    return "german2";
                case StemmerTokenFilterLanguage.LightGerman:
                    return "lightGerman";
                case StemmerTokenFilterLanguage.MinimalGerman:
                    return "minimalGerman";
                case StemmerTokenFilterLanguage.Greek:
                    return "greek";
                case StemmerTokenFilterLanguage.Hindi:
                    return "hindi";
                case StemmerTokenFilterLanguage.Hungarian:
                    return "hungarian";
                case StemmerTokenFilterLanguage.LightHungarian:
                    return "lightHungarian";
                case StemmerTokenFilterLanguage.Indonesian:
                    return "indonesian";
                case StemmerTokenFilterLanguage.Irish:
                    return "irish";
                case StemmerTokenFilterLanguage.Italian:
                    return "italian";
                case StemmerTokenFilterLanguage.LightItalian:
                    return "lightItalian";
                case StemmerTokenFilterLanguage.Sorani:
                    return "sorani";
                case StemmerTokenFilterLanguage.Latvian:
                    return "latvian";
                case StemmerTokenFilterLanguage.Norwegian:
                    return "norwegian";
                case StemmerTokenFilterLanguage.LightNorwegian:
                    return "lightNorwegian";
                case StemmerTokenFilterLanguage.MinimalNorwegian:
                    return "minimalNorwegian";
                case StemmerTokenFilterLanguage.LightNynorsk:
                    return "lightNynorsk";
                case StemmerTokenFilterLanguage.MinimalNynorsk:
                    return "minimalNynorsk";
                case StemmerTokenFilterLanguage.Portuguese:
                    return "portuguese";
                case StemmerTokenFilterLanguage.LightPortuguese:
                    return "lightPortuguese";
                case StemmerTokenFilterLanguage.MinimalPortuguese:
                    return "minimalPortuguese";
                case StemmerTokenFilterLanguage.PortugueseRslp:
                    return "portugueseRslp";
                case StemmerTokenFilterLanguage.Romanian:
                    return "romanian";
                case StemmerTokenFilterLanguage.Russian:
                    return "russian";
                case StemmerTokenFilterLanguage.LightRussian:
                    return "lightRussian";
                case StemmerTokenFilterLanguage.Spanish:
                    return "spanish";
                case StemmerTokenFilterLanguage.LightSpanish:
                    return "lightSpanish";
                case StemmerTokenFilterLanguage.Swedish:
                    return "swedish";
                case StemmerTokenFilterLanguage.LightSwedish:
                    return "lightSwedish";
                case StemmerTokenFilterLanguage.Turkish:
                    return "turkish";
            }
            return null;
        }

        internal static StemmerTokenFilterLanguage? ParseStemmerTokenFilterLanguage(this string value)
        {
            switch( value )
            {
                case "arabic":
                    return StemmerTokenFilterLanguage.Arabic;
                case "armenian":
                    return StemmerTokenFilterLanguage.Armenian;
                case "basque":
                    return StemmerTokenFilterLanguage.Basque;
                case "brazilian":
                    return StemmerTokenFilterLanguage.Brazilian;
                case "bulgarian":
                    return StemmerTokenFilterLanguage.Bulgarian;
                case "catalan":
                    return StemmerTokenFilterLanguage.Catalan;
                case "czech":
                    return StemmerTokenFilterLanguage.Czech;
                case "danish":
                    return StemmerTokenFilterLanguage.Danish;
                case "dutch":
                    return StemmerTokenFilterLanguage.Dutch;
                case "dutchKp":
                    return StemmerTokenFilterLanguage.DutchKp;
                case "english":
                    return StemmerTokenFilterLanguage.English;
                case "lightEnglish":
                    return StemmerTokenFilterLanguage.LightEnglish;
                case "minimalEnglish":
                    return StemmerTokenFilterLanguage.MinimalEnglish;
                case "possessiveEnglish":
                    return StemmerTokenFilterLanguage.PossessiveEnglish;
                case "porter2":
                    return StemmerTokenFilterLanguage.Porter2;
                case "lovins":
                    return StemmerTokenFilterLanguage.Lovins;
                case "finnish":
                    return StemmerTokenFilterLanguage.Finnish;
                case "lightFinnish":
                    return StemmerTokenFilterLanguage.LightFinnish;
                case "french":
                    return StemmerTokenFilterLanguage.French;
                case "lightFrench":
                    return StemmerTokenFilterLanguage.LightFrench;
                case "minimalFrench":
                    return StemmerTokenFilterLanguage.MinimalFrench;
                case "galician":
                    return StemmerTokenFilterLanguage.Galician;
                case "minimalGalician":
                    return StemmerTokenFilterLanguage.MinimalGalician;
                case "german":
                    return StemmerTokenFilterLanguage.German;
                case "german2":
                    return StemmerTokenFilterLanguage.German2;
                case "lightGerman":
                    return StemmerTokenFilterLanguage.LightGerman;
                case "minimalGerman":
                    return StemmerTokenFilterLanguage.MinimalGerman;
                case "greek":
                    return StemmerTokenFilterLanguage.Greek;
                case "hindi":
                    return StemmerTokenFilterLanguage.Hindi;
                case "hungarian":
                    return StemmerTokenFilterLanguage.Hungarian;
                case "lightHungarian":
                    return StemmerTokenFilterLanguage.LightHungarian;
                case "indonesian":
                    return StemmerTokenFilterLanguage.Indonesian;
                case "irish":
                    return StemmerTokenFilterLanguage.Irish;
                case "italian":
                    return StemmerTokenFilterLanguage.Italian;
                case "lightItalian":
                    return StemmerTokenFilterLanguage.LightItalian;
                case "sorani":
                    return StemmerTokenFilterLanguage.Sorani;
                case "latvian":
                    return StemmerTokenFilterLanguage.Latvian;
                case "norwegian":
                    return StemmerTokenFilterLanguage.Norwegian;
                case "lightNorwegian":
                    return StemmerTokenFilterLanguage.LightNorwegian;
                case "minimalNorwegian":
                    return StemmerTokenFilterLanguage.MinimalNorwegian;
                case "lightNynorsk":
                    return StemmerTokenFilterLanguage.LightNynorsk;
                case "minimalNynorsk":
                    return StemmerTokenFilterLanguage.MinimalNynorsk;
                case "portuguese":
                    return StemmerTokenFilterLanguage.Portuguese;
                case "lightPortuguese":
                    return StemmerTokenFilterLanguage.LightPortuguese;
                case "minimalPortuguese":
                    return StemmerTokenFilterLanguage.MinimalPortuguese;
                case "portugueseRslp":
                    return StemmerTokenFilterLanguage.PortugueseRslp;
                case "romanian":
                    return StemmerTokenFilterLanguage.Romanian;
                case "russian":
                    return StemmerTokenFilterLanguage.Russian;
                case "lightRussian":
                    return StemmerTokenFilterLanguage.LightRussian;
                case "spanish":
                    return StemmerTokenFilterLanguage.Spanish;
                case "lightSpanish":
                    return StemmerTokenFilterLanguage.LightSpanish;
                case "swedish":
                    return StemmerTokenFilterLanguage.Swedish;
                case "lightSwedish":
                    return StemmerTokenFilterLanguage.LightSwedish;
                case "turkish":
                    return StemmerTokenFilterLanguage.Turkish;
            }
            return null;
        }
    }
}