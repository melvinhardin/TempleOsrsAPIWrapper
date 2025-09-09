using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Groups.GroupMemberStatsResponse
{
    /// <summary>
    /// Kills for all bosses, total EHB for a group member.
    /// </summary>
    public class GroupMemberBosses
    {
        [JsonPropertyName("Clue_all")]
        public int ClueAll { get; set; }
        [JsonPropertyName("Clue_beginner")]

        public int ClueBeginner { get; set; }
        [JsonPropertyName("Clue_easy")]

        public int ClueEasy { get; set; }
        [JsonPropertyName("Clue_medium")]

        public int ClueMedium { get; set; }
        [JsonPropertyName("Clue_hard")]

        public int ClueHard { get; set; }
        [JsonPropertyName("Clue_elite")]

        public int ClueElite { get; set; }
        [JsonPropertyName("Clue_master")]

        public int ClueMaster { get; set; }
        public int LMS { get; set; }
        [JsonPropertyName("Abyssal Sire")]

        public int AbyssalSire { get; set; }

        [JsonPropertyName("Alchemical Hydra")]

        public int AlchemicalHydra { get; set; }

        [JsonPropertyName("Barrows Chests")]

        public int BarrowsChests { get; set; }
        public int Bryophyta { get; set; }
        public int Callisto { get; set; }

        public int Cerberus { get; set; }

        [JsonPropertyName("Chambers of Xeric")]

        public int ChambersOfXeric { get; set; }

        [JsonPropertyName("Chambers of Xeric Challenge Mode")]

        public int ChambersOfXericChallengeMode { get; set; }

        [JsonPropertyName("Chaos Elemental")]

        public int ChaosElemental { get; set; }

        [JsonPropertyName("Chaos Fanatic")]

        public int ChaosFanatic { get; set; }

        [JsonPropertyName("Commander Zilyana")]

        public int CommanderZilyana { get; set; }

        [JsonPropertyName("Corporeal Beast")]

        public int CorporealBeast { get; set; }

        [JsonPropertyName("Crazy Archaeologist")]

        public int CrazyArchaeologist { get; set; }
        [JsonPropertyName("Dagannoth Prime")]

        public int DagannothPrime { get; set; }

        [JsonPropertyName("Dagannoth Rex")]

        public int DagannothRex { get; set; }

        [JsonPropertyName("Dagannoth Supreme")]

        public int DagannothSupreme { get; set; }

        [JsonPropertyName("Deranged Archaeologist")]

        public int DerangedArchaeologist { get; set; }
        [JsonPropertyName("General Graardor")]

        public int GeneralGraardor { get; set; }

        [JsonPropertyName("Giant Mole")]

        public int GiantMole { get; set; }

        [JsonPropertyName("Grotesque Guardians")]

        public int GrotesqueGuardians { get; set; }

        public int Hespori { get; set; }
        [JsonPropertyName("Kalphite Queen")]

        public int KalphiteQueen { get; set; }

        [JsonPropertyName("King Black Dragon")]

        public int KingBlackDragon { get; set; }


        public int Kraken { get; set; }


        public int KreeArra { get; set; }

        [JsonPropertyName("Kril Tsutsaroth")]

        public int KrilTsutsaroth { get; set; }

        public int Mimic { get; set; }
        public int Obor { get; set; }
        public int Sarachnis { get; set; }

        public int Scorpia { get; set; }

        public int Skotizo { get; set; }

        [JsonPropertyName("The Gauntlet")]

        public int TheGauntlet { get; set; }

        [JsonPropertyName("The Corrupted Gauntlet")]

        public int TheCorruptedGauntlet { get; set; }

        [JsonPropertyName("Theatre of Blood")]

        public int TheatreOfBlood { get; set; }

        [JsonPropertyName("Thermonuclear Smoke Devil")]

        public int ThermonuclearSmokeDevil { get; set; }

        [JsonPropertyName("TzKal-Zuk")]

        public int TzKalZuk { get; set; }

        [JsonPropertyName("TzTok-Jad")]

        public int TzTokJad { get; set; }

        public int Venenatis { get; set; }

        public int Vetion { get; set; }

        public int Vorkath { get; set; }

        public int Wintertodt { get; set; }
        public int Zalcano { get; set; }
        public int Zulrah { get; set; }

        [JsonPropertyName("The Nightmare")]

        public int TheNightmare { get; set; }

        [JsonPropertyName("Soul Wars Zeal")]

        public int SoulWarsZeal { get; set; }
        public int Tempoross { get; set; }
        [JsonPropertyName("Theatre of Blood Challenge Mode")]

        public int TheatreOfBloodChallengeMode { get; set; }

        [JsonPropertyName("Bounty Hunter Hunter")]

        public int BountyHunterHunter { get; set; }
        [JsonPropertyName("Bounty Hunter Rogue")]

        public int BountyHunterRogue { get; set; }
        [JsonPropertyName("Phosanis Nightmare")]

        public int PhosanisNightmare { get; set; }

        public int Nex { get; set; }

        public int Rift { get; set; }
        [JsonPropertyName("PvP Arena")]

        public int PvPArena { get; set; }
        [JsonPropertyName("Tombs of Amascut")]

        public int TombsofAmascut { get; set; }

        [JsonPropertyName("Tombs of Amascut Expert")]

        public int TombsofAmascutExpert { get; set; }

        [JsonPropertyName("Phantom Muspah")]

        public int PhantomMuspah { get; set; }

        public int Artio { get; set; }

        public int Calvarion { get; set; }

        public int Spindel { get; set; }

        [JsonPropertyName("Duke Sucellus")]

        public int DukeSucellus { get; set; }

        [JsonPropertyName("The Leviathan")]

        public int TheLeviathan { get; set; }

        [JsonPropertyName("The Whisperer")]

        public int TheWhisperer { get; set; }

        public int Vardorvis { get; set; }

        public int Scurrius { get; set; }

        [JsonPropertyName("Colosseum Glory")]

        public int ColosseumGlory { get; set; }
        [JsonPropertyName("Lunar Chests")]

        public int LunarChests { get; set; }

        [JsonPropertyName("Sol Heredit")]

        public int SolHeredit { get; set; }


        public int Araxxor { get; set; }

        public int Hueycoatl { get; set; }

        public int Amoxliatl { get; set; }

        public int Collections { get; set; }
        [JsonPropertyName("The Royal Titans")]

        public int TheRoyalTitans { get; set; }

        public int Yama { get; set; }

        [JsonPropertyName("Doom of Mokhaiotl")]

        public int DoomofMokhaiotl { get; set; }

        public float Ehb { get; set; }
        [JsonPropertyName("Ehb_im")]

        public float ImEhb { get; set; }
        [JsonPropertyName("Ehb_uim")]

        public float UimEhb { get; set; }
        [JsonPropertyName("Ehb_1def")]

        public float OneDefEhb { get; set; }
    }
}
