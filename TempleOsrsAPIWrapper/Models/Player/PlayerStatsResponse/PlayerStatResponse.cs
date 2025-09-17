using System.Text.Json.Serialization;

namespace TempleOsrsAPIWrapper.Models.Player.PlayerStatsResponse
{
    public class PlayerStatResponse
    {
        public InfoResponse? info { get; set; }
        public string? Date { get; set; }
        public long Overall { get; set; }
        [JsonPropertyName("Overall_rank")]
        public int OverallRank { get; set; }
        [JsonPropertyName("Overall_level")]

        public short OverallLevel { get; set; }
        [JsonPropertyName("Overall_ehp")]

        public float OverallEhp { get; set; }
        public int Attack { get; set; }
        [JsonPropertyName("Attack_rank")]

        public int AttackRank { get; set; }
        [JsonPropertyName("Attack_level")]
        public byte AttackLevel { get; set; }
        [JsonPropertyName("Attack_ehp")]
        public float AttackEhp { get; set; }
        public int Defence { get; set; }
        [JsonPropertyName("Defence_rank")]
        public int DefenceRank { get; set; }
        [JsonPropertyName("Defence_level")]
        public byte DefenceLevel { get; set; }
        [JsonPropertyName("Defence_ehp")]
        public float DefenceEhp { get; set; }
        public int Strength { get; set; }
        [JsonPropertyName("Strength_rank")]
        public int StrengthRank { get; set; }
        [JsonPropertyName("Strength_level")]
        public byte StrengthLevel { get; set; }
        [JsonPropertyName("Strength_ehp")]
        public float StrengthEhp { get; set; }
        public int Hitpoints { get; set; }
        [JsonPropertyName("Hitpoints_rank")]
        public int HitpointsRank { get; set; }
        [JsonPropertyName("Hitpoints_level")]
        public byte HitpointsLevel { get; set; }
        [JsonPropertyName("Hitpoints_ehp")]
        public float HitpointsEhp { get; set; }
        public int Ranged { get; set; }
        [JsonPropertyName("Ranged_rank")]
        public int RangedRank { get; set; }
        [JsonPropertyName("Ranged_level")]

        public byte RangedLevel { get; set; }
        [JsonPropertyName("Ranged_ehp")]

        public float RangedEhp { get; set; }
        public int Prayer { get; set; }
        [JsonPropertyName("Prayer_rank")]

        public int PrayerRank { get; set; }
        [JsonPropertyName("Prayer_level")]
        public byte PrayerLevel { get; set; }
        [JsonPropertyName("Prayer_ehp")]
        public float PrayerEhp { get; set; }
        public int Magic { get; set; }
        [JsonPropertyName("Magic_rank")]
        public int MagicRank { get; set; }
        [JsonPropertyName("Magic_level")]
        public byte MagicLevel { get; set; }
        [JsonPropertyName("Magic_ehp")]
        public float MagicEhp { get; set; }
        public int Cooking { get; set; }
        [JsonPropertyName("Cooking_rank")]
        public int CookingRank { get; set; }
        [JsonPropertyName("Cooking_level")]
        public byte CookingLevel { get; set; }
        [JsonPropertyName("Cooking_ehp")]
        public float CookingEhp { get; set; }
        public int Woodcutting { get; set; }
        [JsonPropertyName("Woodcutting_rank")]

        public int WoodcuttingRank { get; set; }
        [JsonPropertyName("Woodcutting_level")]

        public byte WoodcuttingLevel { get; set; }
        [JsonPropertyName("Woodcutting_ehp")]

        public float WoodcuttingEhp { get; set; }
        public int Fletching { get; set; }
        [JsonPropertyName("Fletching_rank")]

        public int FletchingRank { get; set; }
        [JsonPropertyName("Fletching_level")]

        public byte FletchingLevel { get; set; }
        [JsonPropertyName("Fletching_ehp")]

        public float FletchingEhp { get; set; }
        public int Fishing { get; set; }
        [JsonPropertyName("Fishing_rank")]

        public int FishingRank { get; set; }
        [JsonPropertyName("Fishing_level")]

        public byte FishingLevel { get; set; }
        [JsonPropertyName("Fishing_ehp")]

        public float FishingEhp { get; set; }
        public int Firemaking { get; set; }
        [JsonPropertyName("Firemaking_rank")]

        public int FiremakingRank { get; set; }
        [JsonPropertyName("Firemaking_level")]

        public byte FiremakingLevel { get; set; }
        [JsonPropertyName("Firemaking_ehp")]

        public float FiremakingEhp { get; set; }
        public int Crafting { get; set; }
        [JsonPropertyName("Crafting_rank")]

        public int CraftingRank { get; set; }
        [JsonPropertyName("Crafting_level")]

        public byte CraftingLevel { get; set; }
        [JsonPropertyName("Crafting_ehp")]

        public float CraftingEhp { get; set; }
        public int Smithing { get; set; }
        [JsonPropertyName("Smithing_rank")]

        public int SmithingRank { get; set; }
        [JsonPropertyName("Smithing_level")]

        public byte SmithingLevel { get; set; }
        [JsonPropertyName("Smithing_ehp")]

        public float SmithingEhp { get; set; }
        public int Mining { get; set; }
        [JsonPropertyName("Mining_rank")]

        public int MiningRank { get; set; }
        [JsonPropertyName("Mining_level")]

        public byte MiningLevel { get; set; }
        [JsonPropertyName("Mining_ehp")]

        public float MiningEhp { get; set; }
        public int Herblore { get; set; }
        [JsonPropertyName("Herblore_rank")]

        public int HerbloreRank { get; set; }
        [JsonPropertyName("Herblore_level")]

        public byte HerbloreLevel { get; set; }
        [JsonPropertyName("Herblore_ehp")]

        public float HerbloreEhp { get; set; }
        public int Agility { get; set; }
        [JsonPropertyName("Agility_rank")]

        public int AgilityRank { get; set; }
        [JsonPropertyName("Agility_level")]

        public byte AgilityLevel { get; set; }
        [JsonPropertyName("Agility_ehp")]

        public float AgilityEhp { get; set; }
        public int Thieving { get; set; }
        [JsonPropertyName("Thieving_rank")]

        public int ThievingRank { get; set; }
        [JsonPropertyName("Thieving_level")]

        public byte ThievingLevel { get; set; }
        [JsonPropertyName("Thieving_ehp")]

        public float ThievingEhp { get; set; }
        public int Slayer { get; set; }
        [JsonPropertyName("Slayer_rank")]

        public int SlayerRank { get; set; }
        [JsonPropertyName("Slayer_level")]

        public byte SlayerLevel { get; set; }
        [JsonPropertyName("Slayer_ehp")]

        public float SlayerEhp { get; set; }
        public int Farming { get; set; }
        [JsonPropertyName("Farming_rank")]

        public int FarmingRank { get; set; }
        [JsonPropertyName("Farming_level")]

        public byte FarmingLevel { get; set; }
        [JsonPropertyName("Farming_ehp")]

        public float FarmingEhp { get; set; }
        public int Runecraft { get; set; }
        [JsonPropertyName("Runecraft_rank")]

        public int RunecraftRank { get; set; }
        [JsonPropertyName("Runecraft_level")]

        public byte RunecraftLevel { get; set; }
        [JsonPropertyName("Runecraft_ehp")]

        public float RunecraftEhp { get; set; }
        public int Hunter { get; set; }
        [JsonPropertyName("Hunter_rank")]

        public int HunterRank { get; set; }
        [JsonPropertyName("Hunter_level")]

        public byte HunterLevel { get; set; }
        [JsonPropertyName("Hunter_ehp")]

        public float HunterEhp { get; set; }
        public int Construction { get; set; }
        [JsonPropertyName("Construction_rank")]

        public int ConstructionRank { get; set; }
        [JsonPropertyName("Construction_level")]

        public byte ConstructionLevel { get; set; }
        [JsonPropertyName("Construction_ehp")]

        public float ConstructionEhp { get; set; }
        public float Ehp { get; set; }
        [JsonPropertyName("Ehp_rank")]

        public int EhpRank { get; set; }
        [JsonPropertyName("Im_ehp")]

        public float ImEhp { get; set; }
        [JsonPropertyName("Lvl3_ehp")]

        public float Lvl3Ehp { get; set; }
        [JsonPropertyName("F2p_ehp")]

        public float F2pEhp { get; set; }
        [JsonPropertyName("Uim_ehp")]

        public float UimEhp { get; set; }
        [JsonPropertyName("1def_ehp")]

        public float OneDefEhp { get; set; }
        [JsonPropertyName("Gim_ehp")]

        public float GimEhp { get; set; }
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
        [JsonPropertyName("Abyssal Sire_ehb")]

        public float AbyssalSireEhb { get; set; }
        [JsonPropertyName("Alchemical Hydra")]

        public int AlchemicalHydra { get; set; }
        [JsonPropertyName("Alchemical Hydra_ehb")]

        public float AlchemicalHydraEhb { get; set; }
        [JsonPropertyName("Barrows Chests")]

        public int BarrowsChests { get; set; }
        public int Bryophyta { get; set; }
        public int Callisto { get; set; }
        [JsonPropertyName("Callisto_ehb")]

        public float CallistoEhb { get; set; }
        public int Cerberus { get; set; }
        [JsonPropertyName("Cerberus_ehb")]

        public float CerberusEhb { get; set; }
        [JsonPropertyName("Chambers of Xeric")]

        public int ChambersOfXeric { get; set; }
        [JsonPropertyName("Chambers of Xeric_ehb")]

        public float ChambersOfXericEhb { get; set; }
        [JsonPropertyName("Chambers of Xeric Challenge Mode")]

        public int ChambersOfXericChallengeMode { get; set; }
        [JsonPropertyName("Chambers of Xeric Challenge Mode_ehb")]

        public float ChambersOfXericChallengeModeEhb { get; set; }
        [JsonPropertyName("Chaos Elemental")]

        public int ChaosElemental { get; set; }
        [JsonPropertyName("Chaos Elemental_ehb")]

        public float ChaosElementalEhb { get; set; }
        [JsonPropertyName("Chaos Fanatic")]

        public int ChaosFanatic { get; set; }
        [JsonPropertyName("Chaos Fanatic_ehb")]

        public float ChaosFanaticEhb { get; set; }
        [JsonPropertyName("Commander Zilyana")]

        public int CommanderZilyana { get; set; }
        [JsonPropertyName("Commander Zilyana_ehb")]

        public float CommanderZilyanaEhb { get; set; }
        [JsonPropertyName("Corporeal Beast")]

        public int CorporealBeast { get; set; }
        [JsonPropertyName("Corporeal Beast_ehb")]

        public float CorporealBeastEhb { get; set; }
        [JsonPropertyName("Crazy Archaeologist")]

        public int CrazyArchaeologist { get; set; }
        [JsonPropertyName("Dagannoth Prime")]

        public int DagannothPrime { get; set; }
        [JsonPropertyName("Dagannoth Prime_ehb")]

        public float DagannothPrimeEhb { get; set; }
        [JsonPropertyName("Dagannoth Rex")]

        public int DagannothRex { get; set; }
        [JsonPropertyName("Dagannoth Rex_ehb")]

        public float DagannothRexEhb { get; set; }
        [JsonPropertyName("Dagannoth Supreme")]

        public int DagannothSupreme { get; set; }
        [JsonPropertyName("Dagannoth Supreme_ehb")]

        public float DagannothSupremeEhb { get; set; }
        [JsonPropertyName("Deranged Archaeologist")]

        public int DerangedArchaeologist { get; set; }
        [JsonPropertyName("General Graardor")]

        public int GeneralGraardor { get; set; }
        [JsonPropertyName("General Graardor_ehb")]

        public float GeneralGraardorEhb { get; set; }
        [JsonPropertyName("Giant Mole")]

        public int GiantMole { get; set; }
        [JsonPropertyName("Giant Mole_ehb")]

        public float GiantMoleEhb { get; set; }
        [JsonPropertyName("Grotesque Guardians")]

        public int GrotesqueGuardians { get; set; }
        [JsonPropertyName("Grotesque Guardians_ehb")]

        public float GrotesqueGuardiansEhb { get; set; }
        public int Hespori { get; set; }
        [JsonPropertyName("Kalphite Queen")]

        public int KalphiteQueen { get; set; }
        [JsonPropertyName("Kalphite Queen_ehb")]

        public float KalphiteQueenEhb { get; set; }
        [JsonPropertyName("King Black Dragon")]

        public int KingBlackDragon { get; set; }
        [JsonPropertyName("King Black Dragon_ehb")]

        public float KingBlackDragonEhb { get; set; }

        public int Kraken { get; set; }
        [JsonPropertyName("Kraken_ehb")]

        public float KrakenEhb { get; set; }

        public int KreeArra { get; set; }
        [JsonPropertyName("KreeArra_ehb")]

        public float KreeArraEhb { get; set; }
        [JsonPropertyName("Kril Tsutsaroth")]

        public int KrilTsutsaroth { get; set; }
        [JsonPropertyName("Kril Tsutsaroth_ehb")]

        public float KrilTsutsarothEhb { get; set; }
        public int Mimic { get; set; }
        public int Obor { get; set; }
        public int Sarachnis { get; set; }
        [JsonPropertyName("Sarachnis_ehb")]

        public float SarachnisEhb { get; set; }
        public int Scorpia { get; set; }
        [JsonPropertyName("Scorpia_ehb")]

        public float ScorpiaEhb { get; set; }
        public int Skotizo { get; set; }
        [JsonPropertyName("Skotizo_ehb")]

        public float SkotizoEhb { get; set; }
        [JsonPropertyName("The Gauntlet")]

        public int TheGauntlet { get; set; }
        [JsonPropertyName("The Gauntlet_ehb")]

        public float TheGauntletEhb { get; set; }
        [JsonPropertyName("The Corrupted Gauntlet")]

        public int TheCorruptedGauntlet { get; set; }
        [JsonPropertyName("The Corrupted Gauntlet_ehb")]

        public float TheCorruptedGauntletEhb { get; set; }
        [JsonPropertyName("Theatre of Blood")]

        public int TheatreOfBlood { get; set; }
        [JsonPropertyName("Theatre of Blood_ehb")]

        public float TheatreofBloodEhb { get; set; }
        [JsonPropertyName("Thermonuclear Smoke Devil")]

        public int ThermonuclearSmokeDevil { get; set; }
        [JsonPropertyName("Thermonuclear Smoke Devil_ehb")]

        public float ThermonuclearSmokeDevilEhb { get; set; }
        [JsonPropertyName("TzKal-Zuk")]

        public int TzKalZuk { get; set; }
        [JsonPropertyName("TzKal-Zuk_ehb")]

        public float TzKalZukEhb { get; set; }
        [JsonPropertyName("TzTok-Jad")]

        public int TzTokJad { get; set; }
        [JsonPropertyName("TzTok-Jad_ehb")]

        public float TzTokJadEhb { get; set; }
        public int Venenatis { get; set; }
        [JsonPropertyName("Venenatis_ehb")]

        public float VenenatisEhb { get; set; }
        public int Vetion { get; set; }
        [JsonPropertyName("Vetion_ehb")]

        public float VetionEhb { get; set; }
        public int Vorkath { get; set; }
        [JsonPropertyName("Vorkath_ehb")]

        public float VorkathEhb { get; set; }
        public int Wintertodt { get; set; }
        public int Zalcano { get; set; }
        public int Zulrah { get; set; }
        [JsonPropertyName("Zulrah_ehb")]

        public float ZulrahEhb { get; set; }
        [JsonPropertyName("The Nightmare")]

        public int TheNightmare { get; set; }
        [JsonPropertyName("The Nightmare_ehb")]

        public float TheNightmareEhb { get; set; }
        [JsonPropertyName("Soul Wars Zeal")]

        public int SoulWarsZeal { get; set; }
        public int Tempoross { get; set; }
        [JsonPropertyName("Theatre of Blood Challenge Mode")]

        public int TheatreOfBloodChallengeMode { get; set; }
        [JsonPropertyName("Theatre of Blood Challenge Mode_ehb")]

        public float TheatreOfBloodChallengeModeEhb { get; set; }
        [JsonPropertyName("Bounty Hunter Hunter")]

        public int BountyHunterHunter { get; set; }
        [JsonPropertyName("Bounty Hunter Rogue")]

        public int BountyHunterRogue { get; set; }
        [JsonPropertyName("Phosanis Nightmare")]

        public int PhosanisNightmare { get; set; }
        [JsonPropertyName("Phosanis Nightmare_ehb")]

        public float PhosanisNightmareEhb { get; set; }
        public int Nex { get; set; }
        [JsonPropertyName("Nex_ehb")]

        public float NexEhb { get; set; }
        public int Rift { get; set; }
        [JsonPropertyName("PvP Arena")]

        public int PvPArena { get; set; }
        [JsonPropertyName("Tombs of Amascut")]

        public int TombsofAmascut { get; set; }
        [JsonPropertyName("Tombs of Amascut_ehb")]

        public float TombsofAmascutEhb { get; set; }
        [JsonPropertyName("Tombs of Amascut Expert")]

        public int TombsofAmascutExpert { get; set; }
        [JsonPropertyName("Tombs of Amascut Expert_ehb")]

        public float TombsofAmascutExpertEhb { get; set; }
        [JsonPropertyName("Phantom Muspah")]

        public int PhantomMuspah { get; set; }
        [JsonPropertyName("Phantom Muspah_ehb")]

        public float PhantomMuspahEhb { get; set; }
        public int Artio { get; set; }
        [JsonPropertyName("Artio_ehb")]

        public float ArtioEhb { get; set; }
        public int Calvarion { get; set; }
        [JsonPropertyName("Calvarion_ehb")]

        public float CalvarionEhb { get; set; }
        public int Spindel { get; set; }
        [JsonPropertyName("Spindel_ehb")]

        public float SpindelEhb { get; set; }
        [JsonPropertyName("Duke Sucellus")]

        public int DukeSucellus { get; set; }
        [JsonPropertyName("Duke Sucellus_ehb")]

        public float DukeSucellusEhb { get; set; }
        [JsonPropertyName("The Leviathan")]

        public int TheLeviathan { get; set; }
        [JsonPropertyName("The Leviathan_ehb")]

        public float TheLeviathanEhb { get; set; }
        [JsonPropertyName("The Whisperer")]

        public int TheWhisperer { get; set; }
        [JsonPropertyName("The Whisperer_ehb")]

        public float TheWhispererEhb { get; set; }
        public int Vardorvis { get; set; }
        [JsonPropertyName("Vardorvis_ehb")]

        public float VardorvisEhb { get; set; }
        public int Scurrius { get; set; }
        [JsonPropertyName("Scurrius_ehb")]

        public float ScurriusEhb { get; set; }
        [JsonPropertyName("Colosseum Glory")]

        public int ColosseumGlory { get; set; }
        [JsonPropertyName("Lunar Chests")]

        public int LunarChests { get; set; }
        [JsonPropertyName("Lunar Chests_ehb")]

        public float LunarChestsEhb { get; set; }
        [JsonPropertyName("Sol Heredit")]

        public int SolHeredit { get; set; }
        [JsonPropertyName("Sol Heredit_ehb")]

        public float SolHereditEhb { get; set; }

        public int Araxxor { get; set; }
        [JsonPropertyName("Araxxor_ehb")]

        public float AraxxorEhb { get; set; }
        public int Hueycoatl { get; set; }
        [JsonPropertyName("Hueycoatl_ehb")]

        public float HueycoatlEhb { get; set; }
        public int Amoxliatl { get; set; }
        [JsonPropertyName("Amoxliatl_ehb")]

        public float AmoxliatlEhb { get; set; }
        public int Collections { get; set; }
        [JsonPropertyName("The Royal Titans")]

        public int TheRoyalTitans { get; set; }
        [JsonPropertyName("The Royal Titans_ehb")]

        public float TheRoyalTitansEhb { get; set; }
        public int Yama { get; set; }
        [JsonPropertyName("Yama_ehb")]

        public float YamaEhb { get; set; }
        [JsonPropertyName("Doom of Mokhaiotl")]

        public int DoomofMokhaiotl { get; set; }
        [JsonPropertyName("Doom of Mokhaiotl_ehb")]

        public float DoomofMokhaiotlEhb { get; set; }
        public float Ehb { get; set; }
        [JsonPropertyName("Im_ehb")]

        public float ImEhb { get; set; }
        [JsonPropertyName("Uim_ehb")]

        public float UimEhb { get; set; }
        [JsonPropertyName("1def_ehb")]

        public float OneDefEhb { get; set; }

        public Dictionary<string, int?> ReturnBossData()
        {
            return new Dictionary<string, int?>
            {
                { "abyssal_sire", AbyssalSire },
                { "alchemical_hydra", AlchemicalHydra },
                { "barrows_chests", BarrowsChests },
                { "bryophyta", Bryophyta },
                { "callisto", Callisto },
                { "cerberus", Cerberus },
                { "chambers_of_xeric", ChambersOfXeric },
                { "chambers_of_xeric_challenge_mode", ChambersOfXericChallengeMode },
                { "chaos_elemental", ChaosElemental },
                { "chaos_fanatic", ChaosFanatic },
                { "commander_zilyana", CommanderZilyana },
                { "corporeal_beast", CorporealBeast },
                { "crazy_archaeologist", CrazyArchaeologist },
                { "dagannoth_prime", DagannothPrime },
                { "dagannoth_rex", DagannothRex },
                { "dagannoth_supreme", DagannothSupreme },
                { "deranged_archaeologist", DerangedArchaeologist },
                { "general_graardor", GeneralGraardor },
                { "giant_mole", GiantMole },
                { "grotesque_guardians", GrotesqueGuardians },
                { "hespori", Hespori },
                { "kalphite_queen", KalphiteQueen },
                { "king_black_dragon", KingBlackDragon },
                { "kraken", Kraken },
                { "kreearra", KreeArra },
                { "kril_tsutsaroth", KrilTsutsaroth },
                { "mimic", Mimic },
                { "obor", Obor },
                { "sarachnis", Sarachnis },
                { "scorpia", Scorpia },
                { "skotizo", Skotizo },
                { "the_gauntlet", TheGauntlet },
                { "the_corrupted_gauntlet", TheCorruptedGauntlet },
                { "theatre_of_blood", TheatreOfBlood },
                { "thermonuclear_smoke_devil", ThermonuclearSmokeDevil },
                { "tzkal_zuk", TzKalZuk },
                { "tztok_jad", TzTokJad },
                { "venenatis", Venenatis },
                { "vetion", Vetion },
                { "vorkath", Vorkath },
                { "wintertodt", Wintertodt },
                { "zalcano", Zalcano },
                { "zulrah", Zulrah },
                { "nightmare", TheNightmare },
                { "soul_wars_zeal", SoulWarsZeal },
                { "tempoross", Tempoross },
                { "theatre_of_blood_challenge_mode", TheatreOfBloodChallengeMode },
                { "bounty_hunter_hunter", BountyHunterHunter },
                { "bounty_hunter_rogue", BountyHunterRogue },
                { "phosanis_nightmare", PhosanisNightmare },
                { "nex", Nex },
                { "rift", Rift },
                { "pvp_arena", PvPArena },
                { "tombs_of_amascut", TombsofAmascut },
                { "tombs_of_amascut_expert", TombsofAmascutExpert },
                { "phantom_muspah", PhantomMuspah },
                { "artio", Artio },
                { "calvarion", Calvarion },
                { "spindel", Spindel },
                { "duke_sucellus", DukeSucellus },
                { "the_leviathan", TheLeviathan },
                { "the_whisperer", TheWhisperer },
                { "vardorvis", Vardorvis },
                { "scurrius", Scurrius },
                { "colosseum_glory", ColosseumGlory },
                { "lunar_chests", LunarChests },
                { "sol_heredit", SolHeredit },
                { "araxxor", Araxxor },
                { "hueycoatl", Hueycoatl },
                { "amoxliatl", Amoxliatl },
                { "the_royal_titans", TheRoyalTitans },
                { "yama", Yama },
                { "doom_of_mokhaiotl", DoomofMokhaiotl }
            };
        }

    }
}

