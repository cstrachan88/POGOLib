// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Inventory/PokemonFamilyId.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from Inventory/PokemonFamilyId.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonFamilyIdReflection {

    #region Descriptor
    /// <summary>File descriptor for Inventory/PokemonFamilyId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonFamilyIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9JbnZlbnRvcnkvUG9rZW1vbkZhbWlseUlkLnByb3RvEhRQT0dPUHJvdG9z",
            "LkludmVudG9yeSrdDAoPUG9rZW1vbkZhbWlseUlkEhAKDEZBTUlMWV9VTlNF",
            "VBAAEhQKEEZBTUlMWV9CVUxCQVNBVVIQARIVChFGQU1JTFlfQ0hBUk1BTkRF",
            "UhAEEhMKD0ZBTUlMWV9TUVVJUlRMRRAHEhMKD0ZBTUlMWV9DQVRFUlBJRRAK",
            "EhEKDUZBTUlMWV9XRUVETEUQDRIRCg1GQU1JTFlfUElER0VZEBASEgoORkFN",
            "SUxZX1JBVFRBVEEQExISCg5GQU1JTFlfU1BFQVJPVxAVEhAKDEZBTUlMWV9F",
            "S0FOUxAXEhIKDkZBTUlMWV9QSUtBQ0hVEBkSFAoQRkFNSUxZX1NBTkRTSFJF",
            "VxAbEhIKDkZBTUlMWV9OSURPUkFOEB0SEwoPRkFNSUxZX05JRE9SQU4yECAS",
            "EwoPRkFNSUxZX0NMRUZBSVJZECMSEQoNRkFNSUxZX1ZVTFBJWBAlEhUKEUZB",
            "TUlMWV9KSUdHTFlQVUZGECcSEAoMRkFNSUxZX1pVQkFUECkSEQoNRkFNSUxZ",
            "X09ERElTSBArEhAKDEZBTUlMWV9QQVJBUxAuEhIKDkZBTUlMWV9WRU5PTkFU",
            "EDASEgoORkFNSUxZX0RJR0xFVFQQMhIRCg1GQU1JTFlfTUVPV1RIEDQSEgoO",
            "RkFNSUxZX1BTWURVQ0sQNhIRCg1GQU1JTFlfTUFOS0VZEDgSFAoQRkFNSUxZ",
            "X0dST1dMSVRIRRA6EhIKDkZBTUlMWV9QT0xJV0FHEDwSDwoLRkFNSUxZX0FC",
            "UkEQPxIRCg1GQU1JTFlfTUFDSE9QEEISFQoRRkFNSUxZX0JFTExTUFJPVVQQ",
            "RRIUChBGQU1JTFlfVEVOVEFDT09MEEgSEgoORkFNSUxZX0dFT0RVREUQShIR",
            "Cg1GQU1JTFlfUE9OWVRBEE0SEwoPRkFNSUxZX1NMT1dQT0tFEE8SFAoQRkFN",
            "SUxZX01BR05FTUlURRBREhQKEEZBTUlMWV9GQVJGRVRDSEQQUxIQCgxGQU1J",
            "TFlfRE9EVU8QVBIPCgtGQU1JTFlfU0VFTBBWEhEKDUZBTUlMWV9HUklNRVIQ",
            "WBITCg9GQU1JTFlfU0hFTExERVIQWhIRCg1GQU1JTFlfR0FTVExZEFwSDwoL",
            "RkFNSUxZX09OSVgQXxISCg5GQU1JTFlfRFJPV1pFRRBgEhEKDUZBTUlMWV9L",
            "UkFCQlkQYhISCg5GQU1JTFlfVk9MVE9SQhBkEhQKEEZBTUlMWV9FWEVHR0NV",
            "VEUQZhIRCg1GQU1JTFlfQ1VCT05FEGgSFAoQRkFNSUxZX0hJVE1PTkxFRRBq",
            "EhUKEUZBTUlMWV9ISVRNT05DSEFOEGsSFAoQRkFNSUxZX0xJQ0tJVFVORxBs",
            "EhIKDkZBTUlMWV9LT0ZGSU5HEG0SEgoORkFNSUxZX1JIWUhPUk4QbxISCg5G",
            "QU1JTFlfQ0hBTlNFWRBxEhIKDkZBTUlMWV9UQU5HRUxBEHISFQoRRkFNSUxZ",
            "X0tBTkdBU0tIQU4QcxIRCg1GQU1JTFlfSE9SU0VBEHQSEgoORkFNSUxZX0dP",
            "TERFRU4QdhIRCg1GQU1JTFlfU1RBUllVEHgSEgoORkFNSUxZX01SX01JTUUQ",
            "ehISCg5GQU1JTFlfU0NZVEhFUhB7Eg8KC0ZBTUlMWV9KWU5YEHwSFQoRRkFN",
            "SUxZX0VMRUNUQUJVWloQfRIRCg1GQU1JTFlfTUFHTUFSEH4SEQoNRkFNSUxZ",
            "X1BJTlNJUhB/EhIKDUZBTUlMWV9UQVVST1MQgAESFAoPRkFNSUxZX01BR0lL",
            "QVJQEIEBEhIKDUZBTUlMWV9MQVBSQVMQgwESEQoMRkFNSUxZX0RJVFRPEIQB",
            "EhEKDEZBTUlMWV9FRVZFRRCFARITCg5GQU1JTFlfUE9SWUdPThCJARITCg5G",
            "QU1JTFlfT01BTllURRCKARISCg1GQU1JTFlfS0FCVVRPEIwBEhYKEUZBTUlM",
            "WV9BRVJPREFDVFlMEI4BEhMKDkZBTUlMWV9TTk9STEFYEI8BEhQKD0ZBTUlM",
            "WV9BUlRJQ1VOTxCQARISCg1GQU1JTFlfWkFQRE9TEJEBEhMKDkZBTUlMWV9N",
            "T0xUUkVTEJIBEhMKDkZBTUlMWV9EUkFUSU5JEJMBEhIKDUZBTUlMWV9NRVdU",
            "V08QlgESDwoKRkFNSUxZX01FVxCXAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Inventory.PokemonFamilyId), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonFamilyId {
    [pbr::OriginalName("FAMILY_UNSET")] FamilyUnset = 0,
    [pbr::OriginalName("FAMILY_BULBASAUR")] FamilyBulbasaur = 1,
    [pbr::OriginalName("FAMILY_CHARMANDER")] FamilyCharmander = 4,
    [pbr::OriginalName("FAMILY_SQUIRTLE")] FamilySquirtle = 7,
    [pbr::OriginalName("FAMILY_CATERPIE")] FamilyCaterpie = 10,
    [pbr::OriginalName("FAMILY_WEEDLE")] FamilyWeedle = 13,
    [pbr::OriginalName("FAMILY_PIDGEY")] FamilyPidgey = 16,
    [pbr::OriginalName("FAMILY_RATTATA")] FamilyRattata = 19,
    [pbr::OriginalName("FAMILY_SPEAROW")] FamilySpearow = 21,
    [pbr::OriginalName("FAMILY_EKANS")] FamilyEkans = 23,
    [pbr::OriginalName("FAMILY_PIKACHU")] FamilyPikachu = 25,
    [pbr::OriginalName("FAMILY_SANDSHREW")] FamilySandshrew = 27,
    [pbr::OriginalName("FAMILY_NIDORAN")] FamilyNidoran = 29,
    [pbr::OriginalName("FAMILY_NIDORAN2")] FamilyNidoran2 = 32,
    [pbr::OriginalName("FAMILY_CLEFAIRY")] FamilyClefairy = 35,
    [pbr::OriginalName("FAMILY_VULPIX")] FamilyVulpix = 37,
    [pbr::OriginalName("FAMILY_JIGGLYPUFF")] FamilyJigglypuff = 39,
    [pbr::OriginalName("FAMILY_ZUBAT")] FamilyZubat = 41,
    [pbr::OriginalName("FAMILY_ODDISH")] FamilyOddish = 43,
    [pbr::OriginalName("FAMILY_PARAS")] FamilyParas = 46,
    [pbr::OriginalName("FAMILY_VENONAT")] FamilyVenonat = 48,
    [pbr::OriginalName("FAMILY_DIGLETT")] FamilyDiglett = 50,
    [pbr::OriginalName("FAMILY_MEOWTH")] FamilyMeowth = 52,
    [pbr::OriginalName("FAMILY_PSYDUCK")] FamilyPsyduck = 54,
    [pbr::OriginalName("FAMILY_MANKEY")] FamilyMankey = 56,
    [pbr::OriginalName("FAMILY_GROWLITHE")] FamilyGrowlithe = 58,
    [pbr::OriginalName("FAMILY_POLIWAG")] FamilyPoliwag = 60,
    [pbr::OriginalName("FAMILY_ABRA")] FamilyAbra = 63,
    [pbr::OriginalName("FAMILY_MACHOP")] FamilyMachop = 66,
    [pbr::OriginalName("FAMILY_BELLSPROUT")] FamilyBellsprout = 69,
    [pbr::OriginalName("FAMILY_TENTACOOL")] FamilyTentacool = 72,
    [pbr::OriginalName("FAMILY_GEODUDE")] FamilyGeodude = 74,
    [pbr::OriginalName("FAMILY_PONYTA")] FamilyPonyta = 77,
    [pbr::OriginalName("FAMILY_SLOWPOKE")] FamilySlowpoke = 79,
    [pbr::OriginalName("FAMILY_MAGNEMITE")] FamilyMagnemite = 81,
    [pbr::OriginalName("FAMILY_FARFETCHD")] FamilyFarfetchd = 83,
    [pbr::OriginalName("FAMILY_DODUO")] FamilyDoduo = 84,
    [pbr::OriginalName("FAMILY_SEEL")] FamilySeel = 86,
    [pbr::OriginalName("FAMILY_GRIMER")] FamilyGrimer = 88,
    [pbr::OriginalName("FAMILY_SHELLDER")] FamilyShellder = 90,
    [pbr::OriginalName("FAMILY_GASTLY")] FamilyGastly = 92,
    [pbr::OriginalName("FAMILY_ONIX")] FamilyOnix = 95,
    [pbr::OriginalName("FAMILY_DROWZEE")] FamilyDrowzee = 96,
    [pbr::OriginalName("FAMILY_KRABBY")] FamilyKrabby = 98,
    [pbr::OriginalName("FAMILY_VOLTORB")] FamilyVoltorb = 100,
    [pbr::OriginalName("FAMILY_EXEGGCUTE")] FamilyExeggcute = 102,
    [pbr::OriginalName("FAMILY_CUBONE")] FamilyCubone = 104,
    [pbr::OriginalName("FAMILY_HITMONLEE")] FamilyHitmonlee = 106,
    [pbr::OriginalName("FAMILY_HITMONCHAN")] FamilyHitmonchan = 107,
    [pbr::OriginalName("FAMILY_LICKITUNG")] FamilyLickitung = 108,
    [pbr::OriginalName("FAMILY_KOFFING")] FamilyKoffing = 109,
    [pbr::OriginalName("FAMILY_RHYHORN")] FamilyRhyhorn = 111,
    [pbr::OriginalName("FAMILY_CHANSEY")] FamilyChansey = 113,
    [pbr::OriginalName("FAMILY_TANGELA")] FamilyTangela = 114,
    [pbr::OriginalName("FAMILY_KANGASKHAN")] FamilyKangaskhan = 115,
    [pbr::OriginalName("FAMILY_HORSEA")] FamilyHorsea = 116,
    [pbr::OriginalName("FAMILY_GOLDEEN")] FamilyGoldeen = 118,
    [pbr::OriginalName("FAMILY_STARYU")] FamilyStaryu = 120,
    [pbr::OriginalName("FAMILY_MR_MIME")] FamilyMrMime = 122,
    [pbr::OriginalName("FAMILY_SCYTHER")] FamilyScyther = 123,
    [pbr::OriginalName("FAMILY_JYNX")] FamilyJynx = 124,
    [pbr::OriginalName("FAMILY_ELECTABUZZ")] FamilyElectabuzz = 125,
    [pbr::OriginalName("FAMILY_MAGMAR")] FamilyMagmar = 126,
    [pbr::OriginalName("FAMILY_PINSIR")] FamilyPinsir = 127,
    [pbr::OriginalName("FAMILY_TAUROS")] FamilyTauros = 128,
    [pbr::OriginalName("FAMILY_MAGIKARP")] FamilyMagikarp = 129,
    [pbr::OriginalName("FAMILY_LAPRAS")] FamilyLapras = 131,
    [pbr::OriginalName("FAMILY_DITTO")] FamilyDitto = 132,
    [pbr::OriginalName("FAMILY_EEVEE")] FamilyEevee = 133,
    [pbr::OriginalName("FAMILY_PORYGON")] FamilyPorygon = 137,
    [pbr::OriginalName("FAMILY_OMANYTE")] FamilyOmanyte = 138,
    [pbr::OriginalName("FAMILY_KABUTO")] FamilyKabuto = 140,
    [pbr::OriginalName("FAMILY_AERODACTYL")] FamilyAerodactyl = 142,
    [pbr::OriginalName("FAMILY_SNORLAX")] FamilySnorlax = 143,
    [pbr::OriginalName("FAMILY_ARTICUNO")] FamilyArticuno = 144,
    [pbr::OriginalName("FAMILY_ZAPDOS")] FamilyZapdos = 145,
    [pbr::OriginalName("FAMILY_MOLTRES")] FamilyMoltres = 146,
    [pbr::OriginalName("FAMILY_DRATINI")] FamilyDratini = 147,
    [pbr::OriginalName("FAMILY_MEWTWO")] FamilyMewtwo = 150,
    [pbr::OriginalName("FAMILY_MEW")] FamilyMew = 151,
  }

  #endregion

}

#endregion Designer generated code
