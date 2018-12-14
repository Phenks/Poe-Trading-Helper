using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using PoeTradingHelper.Backend.Helper;
using PoeTradingHelper.Backend.Models;
using PoeTradingHelper.Backend.Models.ItemMapping;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace PoeTradingHelper.Backend.DAL.Initializer
{

    public static class CurrencyId
    {
        public static int Chaos_Orb = 1;
        public static int Splinter_of_Uul_Netol = 59;
        public static int Splinter_of_Esh = 58;
        public static int Splinter_of_Tul = 57;
        public static int Splinter_of_Xoph = 56;
        public static int Shaper_Set = 55;
        public static int Pale_Court_Set = 54;
        public static int Mortal_Set = 53;
        public static int Splinter_of_Chayula = 60;
        public static int Sacrifice_Set = 52;
        public static int Journeyman_Cartographers_Seal = 50;
        public static int Apprentice_Cartographers_Seal = 49;
        public static int Master_Cartographers_Sextant = 48;
        public static int Journeyman_Cartographers_Sextant = 47;
        public static int Apprentice_Cartographers_Sextant = 46;
        public static int Stacked_Deck = 45;
        public static int Offering_to_the_Goddess = 44;
        public static int Master_Cartographers_Seal = 51;
        public static int Blessing_of_Xoph = 61;
        public static int Blessing_of_Tul = 62;
        public static int Blessing_of_Esh = 63;
        public static int Exalted_Shard = 80;
        public static int Annulment_Shard = 79;
        public static int Ancient_Orb = 78;
        public static int Engineers_Orb = 77;
        public static int Harbingers_Orb = 76;
        public static int Orb_of_Horizons = 75;
        public static int Orb_of_Binding = 74;
        public static int Orb_of_Annulment = 73;
        public static int Divine_Vessel = 72;
        public static int Ancient_Reliquary_Key = 71;
        public static int Chayulas_Breachstone = 70;
        public static int Uul_Netols_Breachstone = 69;
        public static int Eshs_Breachstone = 68;
        public static int Tuls_Breachstone = 67;
        public static int Xophs_Breachstone = 66;
        public static int Blessing_of_Chayula = 65;
        public static int Blessing_of_Uul_Netol = 64;
        public static int Fragment_of_the_Chimera = 43;
        public static int Fragment_of_the_Minotaur = 42;
        public static int Fragment_of_the_Phoenix = 41;
        public static int Fragment_of_the_Hydra = 40;
        public static int Blessed_Orb = 18;
        public static int Chromatic_Orb = 17;
        public static int Orb_of_Chance = 16;
        public static int Gemcutters_Prism = 15;
        public static int Orb_of_Scouring = 14;
        public static int Perandus_Coin = 13;
        public static int Silver_Coin = 12;
        public static int Jewellers_Orb = 11;
        public static int Cartographers_Chisel = 10;
        public static int Orb_of_Regret = 9;
        public static int Vaal_Orb = 8;
        public static int Regal_Orb = 7;
        public static int Orb_of_Alteration = 6;
        public static int Orb_of_Fusing = 5;
        public static int Orb_of_Alchemy = 4;
        public static int Divine_Orb = 3;
        public static int Exalted_Orb = 2;
        public static int Glassblowers_Bauble = 19;
        public static int Mirror_Shard = 81;
        public static int Orb_of_Augmentation = 20;
        public static int Mirror_of_Kalandra = 22;
        public static int Volkuurs_Key = 39;
        public static int Inyas_Key = 38;
        public static int Yriels_Key = 37;
        public static int Ebers_Key = 36;
        public static int Mortal_Hope = 35;
        public static int Mortal_Ignorance = 34;
        public static int Mortal_Rage = 33;
        public static int Mortal_Grief = 32;
        public static int Sacrifice_at_Noon = 31;
        public static int Sacrifice_at_Dawn = 30;
        public static int Sacrifice_at_Midnight = 29;
        public static int Sacrifice_at_Dusk = 28;
        public static int Eternal_Orb = 27;
        public static int Armourers_Scrap = 26;
        public static int Blacksmiths_Whetstone = 25;
        public static int Portal_Scroll = 24;
        public static int Scroll_of_Wisdom = 23;
        public static int Orb_of_Transmutation = 21;
        public static int Timeworn_Reliquary_Key = 82;

    }

    public class SkillGemNames
    {
        public static string Empower = "Empower Support";


        public static string Enlighten = "Enlighten Support";
        public static string Enhance = "Enhance Support";
    }

    public class ItemIds
    {


        public static int Missing_Item = -1;

        public static class UniqueMaps
        {
            public static int The_Perandus_Manor = 1566;
            public static int The_Cowards_Trial = 1466;
            public static int Olmecs_Sanctum = 883;
            public static int Maelström_of_Chaos = 773;
            public static int Death_and_Taxes = 390;
            public static int Actons_Nightmare = 25;
            public static int Hallowed_Ground = 606;
            public static int Hall_of_Grandmasters = 605;
            public static int Caer_Blaidd, _Wolfpacks_Den = 215;
            public static int Obas_Cursed_Trove = 879;
            public static int Vaults_of_Atziri = 1768;
            public static int Poorjoys_Asylum = 960;
            public static int The_Twilight_Temple = 2285;
            public static int Mao_Kun = 786;
            public static int The_Beachhead_T5 = 2247;
            public static int The_Vinktar_Square = 1656;
            public static int The_Beachhead_T10 = 2246;
            public static int The_Putrid_Cloister = 1578;
            public static int The_Beachhead_T15 = 2245;
            public static int Doryanis_Machinarium = 7538;
            public static int Pillars_of_Arun = 2264;
            public static int Whakawairua_Tuahu = 1866;

        }

        public static class Prophecies
        {
            public static int The_Queens_Sacrifice = 4973;
            public static int Echoes_of_Witchcraft = 472;
            public static int Lightning_Falls = 751;
            public static int Deadly_Rivalry_III = 365;
            public static int Mysterious_Invaders = 855;
            public static int Overflowing_Riches = 902;
            public static int The_Bishops_Legacy = 7371;
            public static int The_Forgotten_Garrison = 1501;
            public static int Unbearable_Whispers_IV = 1732;
            public static int A_Regal_Death = 8;
            public static int From_The_Void = 552;
            public static int The_Silverwood = 1609;
            public static int The_Feral_Lord_III = 1493;
            public static int The_Fall_of_an_Empire = 4909;
            public static int Storm_on_the_Horizon = 1371;
            public static int The_Wealthy_Exile = 1670;
            public static int A_Whispered_Prayer = 10;
            public static int Day_of_Sacrifice_II = 359;
            public static int From_Death_Springs_Life = 551;
            public static int Gilded_Within = 570;
            public static int Golden_Touch = 574;
            public static int Kalandras_Craft = 700;
            public static int Lasting_Impressions = 738;
            public static int Notched_Flesh = 868;
            public static int Possessed_Foe = 962;
            public static int The_Ambitious_Bandit_I = 1415;
            public static int Risen_Blood = 1064;
            public static int Hunters_Lesson = 647;
            public static int The_Last_Watch = 1543;
            public static int The_Sword_Kings_Passion = 1627;
            public static int Strong_as_a_Bull = 1378;
            public static int End_of_the_Light = 4895;
            public static int A_Firm_Foothold = 2;
            public static int Beyond_Sight_I = 156;
            public static int Deadly_Rivalry_IV = 366;
            public static int The_Stockkeeper = 1618;
            public static int The_Twins = 1641;
            public static int The_Warmongers_III = 1666;
            public static int The_Nest = 1556;
            public static int Fears_Wide_Reach = 519;
            public static int Holding_the_Bridge = 632;
            public static int Winters_Mournful_Melodies = 1892;
            public static int Baptism_by_Death = 136;
            public static int The_Unbreathing_Queen_IV = 1646;
            public static int Blood_of_the_Betrayed = 173;
            public static int Faith_Exhumed = 7408;
            public static int Erased_from_Memory = 491;
            public static int Hidden_Reinforcements = 625;
            public static int The_Singular_Spirit = 1610;
            public static int The_Brothers_of_Necromancy = 1447;
            public static int The_Lost_Undying = 1548;
            public static int A_Prodigious_Hand = 7;
            public static int Greeds_Folly = 4849;
            public static int Cold_Blooded_Fury = 4863;
            public static int Thaumaturgical_History_I = 1408;
            public static int The_Eagles_Cry = 1483;
            public static int The_Feral_Lord_II = 1492;
            public static int Forceful_Exorcism = 538;
            public static int Heavy_Blows = 613;
            public static int Mouth_of_Horrors = 832;
            public static int Pleasure_and_Pain = 954;
            public static int Roths_Legacy = 1069;
            public static int The_Alchemist = 1414;
            public static int The_Beginning_and_the_End = 1430;
            public static int The_Bloody_Flowers_Redux = 1438;
            public static int The_Child_of_Lunaris = 1459;
            public static int The_Cursed_Choir = 1467;
            public static int The_Feral_Lord_I = 1491;
            public static int Dying_Cry = 466;
            public static int The_Invader = 1532;
            public static int The_Snuffed_Flame = 1613;
            public static int The_Soulless_Beast = 1616;
            public static int The_Unbreathing_Queen_I = 1643;
            public static int The_Unbreathing_Queen_II = 1644;
            public static int The_Undead_Brutes = 1648;
            public static int The_Vanguard = 1652;
            public static int Unbearable_Whispers_I = 1729;
            public static int Agony_at_Dusk = 4850;
            public static int Black_Devotion = 4891;
            public static int The_Wards_Ward = 1662;
            public static int Blood_in_the_Eyes = 171;
            public static int The_Plaguemaw_I = 1569;
            public static int Day_of_Sacrifice_I = 358;
            public static int The_Sharpened_Blade = 1605;
            public static int The_Prison_Guard = 1576;
            public static int The_Four_Feral_Exiles = 1505;
            public static int The_Lady_in_Black = 1541;
            public static int The_Plaguemaw_II = 1570;
            public static int The_Watchers_Watcher = 1669;
            public static int Unbearable_Whispers_III = 1731;
            public static int Dark_Instincts = 4859;
            public static int Last_of_the_Wildmen = 4889;
            public static int Trapped_in_the_Tower = 4893;
            public static int Blinding_Light = 5972;
            public static int A_Call_into_the_Void = 1;
            public static int Beyond_Sight_II = 157;
            public static int The_Plaguemaw_III = 1571;
            public static int Day_of_Sacrifice_III = 360;
            public static int The_Hardened_Armour = 1518;
            public static int Graceful_Flames = 584;
            public static int The_Brutal_Enforcer = 1448;
            public static int The_Scout = 1595;
            public static int Unbearable_Whispers_II = 1730;
            public static int Crimson_Hues = 4921;
            public static int A_Valuable_Combination = 9;
            public static int Ending_the_Torment = 487;
            public static int Power_Magnified = 963;
            public static int Reforged_Bonds = 1043;
            public static int The_Corrupt = 1462;
            public static int The_God_of_Misfortune = 1511;
            public static int The_Walking_Mountain = 1659;
            public static int The_Prison_Key = 1577;
            public static int Rebirth = 1031;
            public static int Anarchys_End_I = 53;
            public static int Plague_of_Frogs = 944;
            public static int Plague_of_Rats = 945;
            public static int The_Plaguemaw_V = 1573;
            public static int Dance_of_Steel = 4868;
            public static int The_Great_Leader_of_the_North = 4908;
            public static int The_Great_Mind_of_the_North = 4896;
            public static int The_Bowstrings_Music = 1440;
            public static int The_Mysterious_Gift = 1555;
            public static int Fire, _Wood_and_Stone = 531;
            public static int Fire_and_Ice = 529;
            public static int Touched_by_the_Wind = 1706;
            public static int Flesh_of_the_Beast = 534;
            public static int The_Beautiful_Guide = 1429;
            public static int A_Master_Seeks_Help = 5;
            public static int Abnormal_Effulgence = 13;
            public static int Against_the_Tide = 28;
            public static int Anarchys_End_II = 54;
            public static int Anarchys_End_IV = 56;
            public static int Ancient_Doom = 59;
            public static int Beyond_Sight_IV = 159;
            public static int Crushing_Squall = 332;
            public static int Custodians_of_Silence = 342;
            public static int Deadly_Rivalry_II = 364;
            public static int Deadly_Rivalry_V = 367;
            public static int A_Forest_of_False_Idols = 3;
            public static int Beyond_Sight_III = 158;
            public static int Bountiful_Traps = 187;
            public static int Unbearable_Whispers_V = 1733;
            public static int Trash_to_Treasure = 1711;
            public static int Fated_Connections = 518;
            public static int The_Kings_Path = 1540;
            public static int Monstrous_Treasure = 823;
            public static int A_Vision_of_Ice_and_Fire = 4912;
            public static int Wind_and_Thunder = 1881;
            public static int Darktongues_Shriek = 4913;
            public static int Song_of_the_Sekhema = 4906;
            public static int Vaal_Winds = 1762;
            public static int The_Jewellers_Touch = 1535;
            public static int Twice_Enchanted = 1726;
            public static int Cleanser_of_Sins = 277;
            public static int Day_of_Sacrifice_IV = 361;
            public static int The_Servants_Heart = 1604;
            public static int Lost_in_the_Pages = 767;
            public static int Defiled_in_the_Sceptre = 404;
            public static int A_Gracious_Master = 4;
            public static int Unnatural_Energy = 1748;
            public static int A_Dishonourable_Death = 4861;
            public static int The_Ambitious_Bandit_III = 1417;
            public static int The_Queens_Vaults = 1580;
            public static int Blind_Faith = 4918;
            public static int Path_of_Betrayal = 918;
            public static int The_Unbreathing_Queen_V = 1647;
            public static int The_Forgotten_Soldiers = 1502;
            public static int Erasmus_Gift = 492;
            public static int The_Flayed_Man = 1497;
            public static int Fire_and_Brimstone = 528;
            public static int Heart_of_the_Fire = 609;
            public static int Vaal_Invasion = 1754;
            public static int Vital_Transformation = 1794;
            public static int Waiting_in_Ambush = 1832;
            public static int Storm_on_the_Reef = 2203;
            public static int The_Dreaded_Rhoa = 4876;
            public static int The_Storm_Spire = 4880;
            public static int A_Rift_in_Time = 4899;
            public static int Suns_Punishment = 4901;
            public static int Cold_Greed = 4902;
            public static int The_Malevolent_Witch = 4903;
            public static int The_Nightmare_Awakens = 4907;
            public static int The_Warmongers_IV = 1667;
            public static int Deadly_Rivalry_I = 363;
            public static int Weeping_Death = 1851;
            public static int Thaumaturgical_History_III = 1410;
            public static int Anarchys_End_III = 55;
            public static int The_Hungering_Swarm = 1527;
            public static int The_King_and_the_Brambles = 1537;
            public static int The_Trembling_Earth = 1638;
            public static int The_Warmongers_I = 1664;
            public static int Battle_Hardened = 7422;
            public static int Burning_Dread = 4878;
            public static int Deadly_Twins = 368;
            public static int An_Unseen_Peril = 52;
            public static int The_Feral_Lord_V = 1495;
            public static int The_Warmongers_II = 1665;
            public static int The_Undead_Storm = 1649;
            public static int The_Unbreathing_Queen_III = 1645;
            public static int Hidden_Vaal_Pathways = 626;
            public static int Ice_from_Above = 655;
            public static int Natures_Resilience = 857;
            public static int Nemesis_of_Greed = 863;
            public static int Pools_of_Wealth = 959;
            public static int Resistant_to_Change = 1053;
            public static int Severed_Limbs = 1112;
            public static int Smothering_Tendrils = 1324;
            public static int Soil, _Worms_and_Blood = 1327;
            public static int Thaumaturgical_History_II = 1409;
            public static int Thaumaturgical_History_IV = 1411;
            public static int The_Ambitious_Bandit_II = 1416;
            public static int The_Apex_Predator = 1419;
            public static int The_Dream_Trial = 1480;
            public static int The_Dreamers_Dream = 1481;
            public static int The_Feral_Lord_IV = 1494;
            public static int The_Flow_of_Energy = 1500;
            public static int The_Fortune_Tellers_Collection = 1504;
            public static int The_Hollow_Pledge = 1525;
            public static int The_Karui_Rebellion = 1536;
            public static int The_Lost_Maps = 1547;
            public static int The_Misunderstood_Queen = 1554;
            public static int The_Petrified = 1568;
            public static int The_Plaguemaw_IV = 1572;
            public static int The_Sinners_Stone = 1611;
            public static int Fire_from_the_Sky = 530;
            public static int Visions_of_the_Drowned = 1793;

        }

       

        public static class Flasks
        {
            public static int Soul_Ripper = 7454;
            public static int Rotgut = 1068;
            public static int Doedres_Elixir = 427;
            public static int Forbidden_Taste = 537;
            public static int Divination_Distillate = 424;
            public static int Coralitos_Signature = 2283;
            public static int The_Writhing_Jar = 1679;
            public static int Kiaras_Determination = 712;
            public static int Coruscating_Elixir = 306;
            public static int Atziris_Promise = 125;
            public static int Rumis_Concoction = 1073;
            public static int Witchfire_Brew = 1893;
        
            public static int Lions_Roar = 763;
            public static int The_Overflowing_Chalice = 1561;
         
            public static int The_Wise_Oak = 2075;
          
            public static int Dying_Sun = 467;
            public static int Taste_of_Hate = 1394;
            public static int Sins_Rebirth = 1956;
      
            public static int The_Sorrow_of_the_Divine = 1614;

        }

        public static class Accessories
        {
            public static int Voideye = 1797;
            public static int Kikazaru = 713;
            public static int Bereks_Pass = 154;
            public static int Ascent_From_Flesh = 98;
            public static int Brinerot_Mark = 199;
            public static int Death_Rush = 391;
            public static int Dream_Fragments = 445;
            public static int Umbilicus_Immortalis = 1728;
            public static int Stormfire = 4886;
            public static int Biscos_Leash = 2080;
            public static int Atziris_Foible = 123;
            public static int The_Hungry_Loop = 2312;
            public static int Blackheart = 166;
            public static int Bloodboil = 176;
            public static int Doedres_Damning = 426;
            public static int Emberwake = 479;
            public static int Eye_of_Chayula = 507;
            public static int Kaoms_Sign = 708;
            public static int Malachais_Artifice = 774;
            public static int Marylenes_Fallacy = 795;
            public static int Mings_Heart = 819;
            public static int Tasalios_Sign = 1393;
            public static int Eye_of_Innocence = 508;
            public static int Carnage_Heart = 227;
            public static int Nights_Hold = 866;
            public static int String_of_Servitude = 6890;
            public static int The_Effigon = 4885;
            public static int Blood_of_Corruption = 172;
            public static int Karui_Charge = 710;
            public static int Mark_of_the_Shaper = 4883;
            public static int Timetwist = 4922;
            public static int The_Primordial_Chain = 7378;
            public static int Voidheart = 1798;
            public static int Rigwalds_Crest = 1058;
            public static int Mokous_Embrace = 822;
            public static int Uzazas_Meadow = 7531;
            public static int Winterweave = 4872;
            public static int Ngamahu_Tiki = 864;
            public static int Cowards_Chains = 6906;
            public static int Daressos_Salute = 349;
            public static int Gifts_from_Above = 569;
            public static int Victarios_Acuity = 1776;
            public static int Mark_of_the_Elder = 4870;
            public static int Ventors_Gamble = 1770;
            public static int Le_Heup_of_All = 741;
            public static int Andvarius = 65;
            public static int Thiefs_Torment = 1685;
            public static int Mutewind_Seal = 845;
            public static int Praxis = 965;
            public static int Pyre = 984;
            public static int Karui_Ward = 711;
            public static int Belt_of_the_Deceiver = 152;
            public static int Prismweave = 976;
            public static int Rashkaldors_Patience = 1013;
            public static int Shapers_Seed = 1259;
            public static int The_Aylardex = 1424;
            public static int Bloodgrip = 2179;
            public static int Extractor_Mentis = 506;
            public static int The_Magnate = 1551;
            public static int Bated_Breath = 139;
            public static int Gluttony = 5973;
            public static int Immortal_Flesh = 660;
            public static int Tear_of_Purity = 1395;
            public static int The_Anvil = 1418;
            public static int Wurms_Molt = 1895;
            public static int Soul_Tether = 2189;
            public static int Maligaros_Cruelty = 2190;
            public static int Perandus_Blazon = 923;
            public static int Sidhebreath = 1304;
            public static int Stone_of_Lazhwar = 1367;
            public static int The_Ignomon = 1528;
            public static int Sunblast = 1381;
            public static int Maligaros_Restraint = 782;
            
            public static int Loris_Lantern = 766;
            public static int Soulthirst = 1336;
            public static int Redblade_Band = 1035;
            public static int Romiras_Banquet = 1067;
            public static int Sibyls_Lament = 1303;
            public static int The_Wardens_Brand = 1661;
            public static int Timeclasp = 1695;
            public static int Valyrium = 1764;
            public static int Warped_Timepiece = 1839;
            public static int Winterheart = 1890;
            
            public static int Perseverance = 1983;
            
            public static int Gloomfang = 2300;
            public static int Cyclopean_Coil = 2314;
            public static int Darkness_Enthroned = 2319;
            public static int Perquils_Toe = 7373;
            public static int Meginords_Girdle = 807;
            public static int Dyadian_Dawn = 460;
            
            public static int Ryslathas_Coil = 2078;
            public static int Mark_of_Submission = 7361;
            public static int Heartbound_Loop = 610;
            public static int Auxium = 2094;
            public static int Feastbind = 520;
            public static int Ngamahus_Sign = 865;
            public static int Auls_Uprising = 7709;
            public static int The_Flow_Untethered = 2229;
            public static int Natural_Hierarchy = 856;
            public static int Kaoms_Way = 709;
            public static int Blightwell = 169;
            public static int Choir_of_the_Storm = 1994;
            public static int Eyes_of_the_Greatwolf = 509;
            public static int Presence_of_Chayula = 2018;
            public static int Demigods_Eye = 411;
            public static int Headhunter = 607;
            public static int Cowards_Legacy = 6950;
            public static int Xophs_Heart = 1959;
            public static int Xophs_Blood = 1993;
            public static int The_Taming = 1628;
            public static int Putembos_Mountain = 7760;
            public static int Ahkelis_Meadow = 7761;
            public static int Bereks_Respite = 155;
            public static int Uzazas_Valley = 7738;
            public static int Araku_Tiki = 76;
            public static int Hinekoras_Sight = 631;
            public static int Bereks_Grip = 153;
            public static int Rigwalds_Curse = 1059;
            public static int The_Halcyon = 1961;
            public static int Putembos_Valley = 7523;
            public static int The_Pariah = 1564;
            public static int Star_of_Wraeclast = 1359;
            public static int Snakepit = 1326;
            public static int Ahkelis_Valley = 7626;
            public static int Perandus_Signet = 925;
            public static int The_Tactician = 4853;
            public static int The_Nomad = 4865;
            public static int Essence_Worm = 497;
            public static int Ahkelis_Mountain = 7521;
            public static int Faminebind = 517;
            public static int Call_of_the_Brotherhood = 216;
            public static int The_Ascetic = 1422;
            public static int Astramentis = 113;
            public static int Yoke_of_Suffering = 2311;
            public static int The_Pandemonius = 2019;
            public static int Shavronnes_Revelation = 1265;
            public static int Second_Piece_of_Time = 2225;
            public static int Valakos_Sign = 1763;
            public static int Voice_of_the_Storm = 1965;
            public static int Uzazas_Mountain = 7620;
            public static int First_Piece_of_Time = 2226;
            public static int Volls_Devotion = 1809;
            public static int The_Retch = 1588;
            public static int Biscos_Collar = 2077;
            public static int Putembos_Meadow = 7628;
            public static int Precursors_Emblem = 7599;
            public static int Ungils_Harmony = 1747;

        }

        public static class Armours
        {
            public static int Demigods_Dominance = 408;
            public static int Flesh_and_Spirit = 533;
            public static int Empires_Grasp = 486;
            public static int Crown_of_the_Pale_King = 330;
            public static int Cragfall = 321;
            public static int Cospris_Will = 308;
            public static int Cherrubims_Maleficence = 263;
            public static int Carcass_Jack = 223;
            public static int Aurseize = 132;
            public static int Alphas_Howl = 46;
            public static int Alberons_Warpath = 42;
            public static int Ezomyte_Hold = 510;
            public static int Prism_Guardian = 974;
            public static int Haemophilia = 2082;
            public static int Goldrim = 575;
            public static int Geofris_Sanctuary = 560;
            public static int Atziris_Step = 130;
            public static int Foxs_Fortune = 4890;
            public static int Yriels_Fostering_Bleeding = 4760;
            public static int Volkuurs_Guidance_Cold = 4750;
            public static int Vix_Lunaris = 2295;
            public static int Volkuurs_Guidance_Lightning = 2252;
            public static int Trolltimber_Spire = 1716;
            public static int The_Rat_Cage = 1582;
            public static int Starkonjas_Head = 1363;
            public static int Lochtonial_Caress = 765;
            public static int Devotos_Devotion = 421;
            public static int Broken_Faith = 206;
            public static int Aegis_Aurora = 27;
            public static int Kaoms_Roots = 707;
            public static int Goldwyrm = 576;
            public static int Chains_of_Command = 5975;
            public static int Glitterdisc = 573;
            public static int Greeds_Embrace = 595;
            public static int Hrimsorrow = 643;
            public static int Invictus_Solaris = 2286;
            public static int Diallas_Malefaction = 2249;
            public static int Malachais_Mark = 2248;
            public static int Allelopathy = 2200;
            public static int The_Coming_Calamity = 2199;
            public static int Tinkerskin = 2195;
            public static int Ebers_Unification = 2192;
            public static int Ahns_Heritage = 2081;
            public static int The_Baron = 2072;
            public static int The_Formless_Flame = 1968;
            public static int The_Snowblind_Grace = 1966;
            public static int Windscream = 1886;
            public static int Wanderlust = 1837;
            public static int Voidwalker = 1802;
            public static int Vis_Mortis = 1790;
            public static int Vipers_Scales = 1787;
            public static int Victarios_Influence = 1779;
            public static int Incandescent_Heart = 662;
            public static int Kaltensoul = 702;
            public static int Kintsugi = 719;
            public static int Leer_Cast = 742;
            public static int Lightning_Coil = 748;
            public static int Maloneys_Nightfall = 784;
            public static int Oskarm = 2259;
            public static int Martyrs_Crown = 794;
            public static int Rats_Nest = 1016;
            public static int Redblade_Tramplers = 1037;
            public static int Soul_Mantle = 1331;
            public static int Soul_Strike = 1334;
            public static int Steppan_Eard = 1366;
            public static int Vaal_Caress = 1751;
            public static int Obscurantis = 881;
            public static int First_Piece_of_Focus = 2210;
            public static int Yriels_Fostering_Poison = 4755;
            public static int Yriels_Fostering_Maim = 4781;
            public static int First_Piece_of_Directions = 2208;
            public static int Third_Piece_of_Directions = 2228;
            public static int Gruthkuls_Pelt = 2079;
            public static int Heretics_Veil = 619;
            public static int Atziris_Splendour_Armour = 1926;
            public static int The_Vertex = 1654;
            public static int The_Oak = 1557;
            public static int Apeps_Slumber = 6891;
            public static int Atziris_Splendour_Armour_Evasion = 1920;
            public static int Saqawals_Winds = 4932;
            public static int The_Red_Trail = 2017;
            public static int Atziris_Splendour_Evasion_ES_Life = 1935;
            public static int Doedres_Malevolence = 4930;
            public static int Shadows_and_Dust = 1119;
            public static int The_Iron_Fortress = 7606;
            public static int Magna_Eclipsis = 2503;
            public static int Lightpoacher_2_Jewels = 4768;
            public static int Hyrris_Demise = 4897;
            public static int Saqawals_Talons = 4904;
            public static int Atziris_Splendour_Armour_ES_Life = 1933;
            public static int The_Signal_Fire = 1608;
            public static int Doedres_Skin = 2321;
            public static int Wall_of_Brambles = 1834;
            public static int Atziris_Splendour_Evasion_ES = 1928;
            public static int Eshs_Mirror = 1970;
            public static int Winds_of_Change = 1885;
            public static int The_Gull = 1517;
            public static int The_Brass_Dome = 1441;
            public static int Voidfletcher = 4857;
            public static int Scolds_Bridle = 1084;
            public static int Shapers_Touch = 1260;
            public static int Crystal_Vault = 4881;
            public static int The_Brine_Crown = 1991;
            public static int Lioneyes_Remorse = 759;
            public static int Queen_of_the_Forest = 992;
            public static int Light_of_Lunaris = 1967;
            public static int Fourth_Piece_of_Focus = 2230;
            public static int Drillneck = 447;
            public static int The_Perfect_Form = 1996;
            public static int Unyielding_Flame = 6996;
            public static int Wildwrap = 4914;
            public static int Belly_of_the_Beast = 149;
            public static int Garukhans_Flight = 2092;
            public static int Mask_of_the_Spirit_Drinker = 6905;
            public static int Tombfist_1_Jewel = 4764;
            public static int Second_Piece_of_Focus = 2207;
            public static int Abyssus = 17;
            public static int Third_Piece_of_Focus = 2222;
            public static int Cloak_of_Tawmr_Isley = 285;
            public static int Shavronnes_Gambit = 1263;
            public static int Eshs_Visage = 2001;
            public static int The_Formless_Inferno = 2009;
            public static int Inyas_Epiphany = 2186;
            public static int Second_Piece_of_Directions = 2224;
            public static int Volkuurs_Guidance_Fire = 4775;
            public static int Deidbellow = 406;
            public static int Lightpoacher_1_Jewel = 4765;
            public static int Bubonic_Trail_1_Jewel = 4766;
            public static int Duskblight = 4856;
            public static int The_Broken_Crown = 1446;
            public static int Jaws_of_Agony = 688;
            public static int Volls_Protector = 1810;
            public static int Rime_Gaze = 1062;
            public static int The_Eternal_Apple = 7359;
            public static int Bones_of_Ullr = 185;
            public static int Geofris_Crest = 559;
            public static int Daressos_Defiance = 345;
            public static int Facebreaker = 512;
            public static int Bramblejack = 192;
            public static int Wheel_of_the_Stormsail = 1872;
            public static int Ahns_Contempt = 2282;
            public static int The_Embalmer = 2193;
            public static int Zahndethus_Cassock = 1902;
            public static int Wyrmsign = 1896;
            public static int Verusos_Battering_Rams = 1771;
            public static int Titucius_Span = 1698;
            public static int Malachais_Loop = 775;
            public static int Malachais_Simula = 776;
            public static int Mindspiral = 816;
            public static int Mutewind_Pennant = 844;
            public static int Mutewind_Whispersteps = 846;
            public static int Saemus_Gift = 1080;
            public static int Ralakeshs_Impatience = 2277;
            public static int Shackles_of_the_Wretched = 1118;
            public static int Snakebite = 1325;
            public static int Sundance = 1382;
            public static int The_Blood_Dance = 1433;
            public static int The_Covenant = 1463;
            public static int The_Restless_Ward = 1585;
            public static int The_Three_Dragons = 1634;
            public static int Slitherpinch = 1320;
            public static int Kitavas_Thirst = 722;
            public static int Wraithlord = 2253;
            public static int Curtain_Call = 7366;
            public static int The_Peregrine = 1567;
            public static int The_Deep_Ones_Hide = 1474;
            public static int Maligaros_Lens = 781;
            public static int Lioneyes_Paws = 758;
            public static int Lightbane_Raiment = 745;
            public static int Kongmings_Stratagem = 726;
            public static int Fairgraves_Tricorne = 515;
            public static int Ezomyte_Peak = 511;
            public static int Craghead = 322;
            public static int Chalice_of_Horrors = 252;
            public static int Ashrend = 107;
            public static int Veil_of_the_Night = 1769;
            public static int Cloak_of_Flame = 282;
            public static int Crown_of_Thorns = 331;
            public static int Speakers_Wreath = 2188;
            public static int Ondars_Clasp = 884;
            public static int Nomics_Storm = 867;
            public static int Chernobogs_Pillar = 262;
            public static int Chitus_Apex = 270;
            public static int Giantsbane = 2254;
            public static int Thousand_Ribbons = 1687;
            public static int Mark_of_the_Red_Covenant = 4855;
            public static int Shavronnes_Pace = 1264;
            public static int Three_step_Assault = 1692;
            public static int Surgebinders = 1383;
            public static int Honourhome = 633;
            public static int Wondertrap = 1894;
            public static int Asphyxias_Wrath = 110;
            public static int Blackgleam = 165;
            public static int Deidbell = 405;
            public static int Kaltenhalt = 701;
            public static int Dusktoe = 458;
            public static int Atziris_Splendour_Armour_ES = 1921;
            public static int Kingsguard = 716;
            public static int Icetomb = 656;
            public static int Bronns_Lithe = 207;
            public static int Brinerot_Whalers = 200;
            public static int Black_Sun_Crest = 163;
            public static int Atziris_Mirror = 124;
            public static int Brinerot_Flag = 198;
            public static int Voidbringer = 1796;
            public static int Memory_Vault = 2298;
            public static int Thunderfist = 1693;
            public static int Zeels_Amplifier = 6936;
            public static int Iron_Heart = 2294;
            public static int Victarios_Charity = 1777;
            public static int Gorgons_Gaze = 4888;
            public static int Hyrris_Bite = 651;
            public static int Southbound = 1337;
            public static int Sentaris_Answer = 1110;
            public static int Victarios_Flight = 1778;
            public static int Ambus_Charge = 48;
            public static int Greedtrap = 4877;
            public static int Hale_Negator = 7588;
            public static int Rainbowstride = 1009;
            public static int Rathpith_Globe = 1014;
            public static int Deaths_Oath = 397;
            public static int The_Bringer_of_Rain = 1444;
            public static int Crown_of_Eyes = 329;
            public static int Bloodbond = 2260;
            public static int Saffells_Frame = 1081;
            public static int The_Infinite_Pursuit = 1969;
            public static int Demon_Stitcher = 7385;
            public static int Maligaros_Virtuosity = 783;
            public static int Meginords_Vise = 808;
            public static int Thirst_for_Horrors = 1686;
            public static int Redblade_Banner = 1036;
            public static int Infernal_Mantle = 669;
            public static int Darkray_Vectors = 354;
            public static int Rise_of_the_Phoenix = 1063;
            public static int Heatshiver = 612;
            public static int Gangs_Momentum = 554;
            public static int Foxshade = 542;
            public static int Doedres_Tenure = 430;
            public static int Deerstalker = 403;
            public static int Daressos_Courage = 344;
            public static int Crest_of_Perandus = 328;
            public static int Briskwrap = 201;
            public static int Asenaths_Mark = 100;
            public static int Asenaths_Gentle_Touch = 99;
            public static int The_Beast_Fur_Shawl = 1426;
            public static int Solaris_Lorica = 1328;
            public static int Doedres_Scorn = 429;
            public static int Blasphemers_Grasp = 2301;
            public static int Volls_Vision = 1962;
            public static int Wake_of_Destruction = 1833;
            public static int Repentance = 1047;
            public static int Sadimas_Touch = 1079;
            public static int Sin_Trek = 1312;
            public static int Skullhead = 1318;
            public static int Springleaf = 1352;
            public static int Dendrobate = 2196;
            public static int Lepers_Alms = 2299;
            public static int Doryanis_Fist = 442;
            public static int Great_Old_Ones_Ward = 594;
            public static int Kalisas_Grace = 2257;
            public static int Hrimnors_Resolve = 642;
            public static int Matua_Tupuna = 798;
            public static int Rearguard = 1030;
            public static int Hyrris_Ire = 652;
            public static int Lioneyes_Vision = 760;
            public static int Skirmish = 1317;
            public static int Thousand_Teeth_Temu = 1690;
            public static int Sunspite = 4873;
            public static int Skyforth = 1319;
            public static int Fenumus_Toxins = 4946;
            public static int Craiceanns_Carapace = 4933;
            public static int Bubonic_Trail_2_Jewels = 4771;
            public static int Kaoms_Heart = 703;
            public static int Tombfist_2_Jewels = 4769;
            public static int Fenumus_Shroud = 4928;
            public static int Fenumus_Spinnerets = 4941;
            public static int The_Tempests_Binding = 2238;
            public static int Seven_League_Step = 1111;
            public static int The_Surrender = 2006;
            public static int Deaths_Door = 392;
            public static int Rigwalds_Quills = 1060;
            public static int Atziris_Reflection = 4974;
            public static int Atziris_Acuity = 119;
            public static int Abberaths_Hooves = 1971;
            public static int Farruls_Bite = 4944;
            public static int Fenumus_Weave = 4942;
            public static int Crown_of_the_Tyrant = 7735;
           
            public static int Inpulsas_Broken_Heart = 2289;
            public static int Third_Piece_of_Storms = 2237;
            public static int Atziris_Splendour_Armour_Evasion_ES = 1918;
            public static int Grip_of_the_Council = 598;
            public static int Malachais_Awakening = 4905;
            public static int The_Unshattered_Will = 2234;
            public static int Craiceanns_Pincers = 4934;
            public static int Saqawals_Flock = 4920;
            public static int The_Fracturing_Spinner = 2233;
            public static int Asenaths_Chant = 4851;
            public static int Indigon = 4879;
            public static int Cloak_of_Defiance = 279;
           
            public static int Geofris_Legacy = 7514;
            public static int Second_Piece_of_Storms = 2236;
            public static int First_Piece_of_Storms = 2232;
            public static int Craiceanns_Chitin = 4917;
            public static int Hrimburn = 637;
            public static int Ylfebans_Trickery = 1900;
            public static int Atziris_Splendour_Evasion = 1930;
            public static int Shavronnes_Wrappings = 1266;
            public static int Tabula_Rasa = 1387;
            public static int Lycosidae = 1950;
            public static int Dance_of_the_Offered = 6898;
            public static int Command_of_the_Pit = 7576;
            public static int Loreweave = 5048;
            public static int Mind_of_the_Council = 815;
            public static int The_Anticipation = 1976;
            public static int Atziris_Splendour_ES = 1927;
            public static int Null_and_Void = 869;
            public static int Farruls_Pounce = 4961;
            public static int Windshriek = 4869;
            public static int Craiceanns_Tracks = 4935;
            public static int Frostferno = 4884;
            public static int Saqawals_Nest = 4910;
            public static int Shroud_of_the_Lightless_1_Jewel = 4770;
            public static int Tukohamas_Fortress = 1981;
            public static int Farruls_Chase = 4945;
            public static int Stormcharger = 2261;

        }

        public static class DivinationCards
        {
            public static int The_Nurse = 18978;
            public static int House_of_Mirrors = 636;
            public static int The_Admirer = 6948;
            public static int The_Darkest_Dream = 6956;
            public static int Harmony_of_Souls = 6997;
            public static int The_Cacophony = 7403;
            public static int Emperors_Luck = 482;
            public static int The_Traitor = 1637;
            public static int Light_and_Truth = 744;
            public static int The_Road_to_Power = 1590;
            public static int The_Realm = 2317;
            public static int The_Endurance = 1486;
            public static int The_Eye_of_the_Dragon = 2309;
            public static int The_Dreamland = 6939;
            public static int The_Blazing_Fire = 2288;
            public static int The_Watcher = 1668;
            public static int The_Puzzle = 4867;
            public static int The_Coming_Storm = 2040;
            public static int The_Demoness = 1475;
            public static int The_Visionary = 1657;
            public static int The_Gladiator = 1510;
            public static int The_Catalyst = 1453;
            public static int Tranquillity = 1709;
            public static int The_Fox = 1506;
            public static int The_Dragon = 1478;
            public static int The_Army_of_Blood = 6913;
            public static int Audacity = 131;
            public static int The_Rite_of_Elements = 6937;
            public static int The_Fathomless_Depths = 6929;
            public static int The_Sword_Kings_Salute = 6921;
            public static int The_Penitent = 1565;
            public static int The_Poet = 1574;
            public static int The_Scavenger = 1592;
            public static int The_Soul = 1615;
            public static int The_Spoiled_Prince = 1617;
            public static int The_Stormcaller = 1619;
            public static int The_Summoner = 1621;
            public static int The_Sun = 1622;
            public static int The_Surveyor = 1625;
            public static int The_Survivalist = 1626;
            public static int The_Trial = 1639;
            public static int The_Union = 1650;
            public static int The_Wrath = 1678;
            public static int Treasure_Hunter = 1712;
            public static int Vinias_Token = 1786;
            public static int Volatile_Power = 1803;
            public static int Call_to_the_First_Ones = 2037;
            public static int The_Wolverine = 2043;
            public static int The_Garish_Power = 2044;
            public static int The_Forsaken = 2048;
            public static int Atziris_Arsenal = 2087;
            public static int No_Traces = 2292;
            public static int The_Insatiable = 4874;
            public static int Blessing_of_God = 4911;
            public static int The_Beast = 6917;
            public static int The_Siren = 1612;
            public static int The_Pact = 1563;
            public static int The_Opulent = 2088;
            public static int Forbidden_Power = 4887;
            public static int A_Mothers_Parting_Gift = 6;
            public static int Assassins_Favour = 111;
            public static int Cartographers_Delight = 229;
            public static int Death = 389;
            public static int Destined_to_Crumble = 420;
            public static int Dying_Anguish = 462;
            public static int Her_Mask = 618;
            public static int Lantadors_Lost_Love = 735;
            public static int Prosperity = 982;
            public static int Rain_of_Chaos = 1006;
            public static int Rain_Tempter = 1008;
            public static int The_Deceiver = 4864;
            public static int The_Betrayal = 1431;
            public static int The_Kings_Blade = 1538;
            public static int The_Lich = 1544;
            public static int The_Lunaris_Priestess = 1550;
            public static int The_Metalsmiths_Gift = 1553;
            public static int The_Rabid_Rhoa = 1581;
            public static int The_Surgeon = 1624;
            public static int The_Warden = 1660;
            public static int The_Web = 1671;
            public static int The_Wolfs_Shadow = 1677;
            public static int Thunderous_Skies = 1694;
            public static int Turn_the_Other_Cheek = 1725;
            public static int The_Incantation = 1530;
            public static int The_Floras_Gift = 1499;
            public static int The_Witch = 6953;
            public static int Mitts = 2034;
            public static int Coveted_Possession = 320;
            public static int The_Feast = 1490;
            public static int Grave_Knowledge = 588;
            public static int Loyalty = 769;
            public static int Rats = 1015;
            public static int The_Doppelganger = 1477;
            public static int The_Drunken_Aristocrat = 1482;
            public static int The_Explorer = 1489;
            public static int The_Gentleman = 1509;
            public static int The_Hermit = 1523;
            public static int The_Inoculated = 1531;
            public static int The_Scholar = 1593;
            public static int The_Tower = 1636;
            public static int Three_Faces_in_the_Dark = 1691;
            public static int Might_is_Right = 2083;
            public static int Three_Voices = 6901;
            public static int Boundless_Realms = 186;
            public static int The_Twins = 1640;
            public static int Anarchys_Price = 57;
            public static int Doedres_Madness = 428;
            public static int The_Gambler = 1507;
            public static int The_Lover = 1549;
            public static int The_Scarred_Meadow = 1591;
            public static int The_Carrion_Crow = 1450;
            public static int The_Sigil = 1606;
            public static int The_Pack_Leader = 1562;
            public static int The_One_With_All = 1560;
            public static int The_Oath = 1558;
            public static int The_Mercenary = 1552;
            public static int The_Kings_Heart = 1539;
            public static int The_Hoarder = 1524;
            public static int The_Hale_Heart = 6915;
            public static int The_Master = 6926;
            public static int The_Breach = 4900;
            public static int The_Artist = 1421;
            public static int The_Undisputed = 6981;
            public static int The_Void = 1658;
            public static int The_Celestial_Justicar = 1457;
            public static int Time_Lost_Relic = 1696;
            public static int Perfection = 6920;
            public static int The_Hunger = 1526;
            public static int The_Enlightened = 1487;
            public static int The_Wind = 1675;
            public static int The_Valley_of_Steel_Boxes = 2036;
            public static int The_Thaumaturgist = 1633;
            public static int The_Polymath = 2035;
            public static int Merciless_Armament = 809;
            public static int Left_to_Fate = 2475;
            public static int Bowyers_Dream = 188;
            public static int The_Ethereal = 1488;
            public static int The_Risk = 1589;
            public static int The_Porcupine = 2047;
            public static int The_Twilight_Moon = 7386;
            public static int The_Last_One_Standing = 1542;
            public static int Heterochromia = 620;
            public static int The_Valkyrie = 1651;
            public static int Pride_Before_the_Fall = 971;
            public static int Beauty_Through_Death = 7437;
            public static int Chaotic_Disposition = 257;
            public static int The_Doctor = 1476;
            public static int The_Fiend = 1496;
            public static int The_Immortal = 1529;
            public static int The_Spark_and_the_Flame = 2045;
            public static int Hunters_Reward = 649;
            public static int The_Samurais_Eye = 6908;
            public static int The_Wolven_Kings_Bite = 2041;
            public static int Immortal_Resolve = 6942;
            public static int The_Iron_Bard = 4927;
            public static int Abandoned_Wealth = 11;
            public static int Mawr_Blaidd = 799;
            public static int The_Queen = 1579;
            public static int The_Celestial_Stone = 6966;
            public static int The_Mayor = 6963;
            public static int The_Vast = 1653;
            public static int The_Dragons_Heart = 1479;
            public static int Wealth_and_Power = 1850;
            public static int Boon_of_the_First_Ones = 7383;
            public static int The_Saints_Treasure = 2042;
            public static int The_Professor = 6916;
            public static int The_Undaunted = 6951;
            public static int The_Wolf = 1676;
            public static int The_Sephirot = 1603;
            public static int The_World_Eater = 4915;
            public static int Last_Hope = 736;
            public static int Lucky_Deck = 771;
            public static int The_Brittle_Emperor = 1445;
            public static int Hubris = 644;
            public static int Hunters_Resolve = 648;
            public static int Jack_in_the_Box = 686;
            public static int Lost_Worlds = 768;
            public static int Lucky_Connections = 770;
            public static int Lysahs_Respite = 772;
            public static int Scholar_of_the_Seas = 1083;
            public static int Shard_of_Fate = 1261;
            public static int The_Aesthete = 1412;
            public static int The_Arena_Champion = 1420;
            public static int The_Avenger = 1423;
            public static int The_Battle_Born = 1425;
            public static int The_Body = 1439;
            public static int The_Calling = 1449;
            public static int The_Cataclysm = 1452;
            public static int The_Conduit = 1460;
            public static int The_Cursed_King = 1468;
            public static int The_Encroaching_Darkness = 1485;
            public static int The_Fletcher = 1498;
            public static int The_Formless_Sea = 1503;
            public static int The_Gemcutter = 1508;
            public static int The_Harvester = 1522;
            public static int The_Jester = 1534;
            public static int The_Lion = 1545;
            public static int The_Lord_in_Black = 1546;
            public static int Hope = 634;
            public static int Struck_by_Lightning = 2091;
            public static int Glimmer_of_Hope = 572;
            public static int Gemcutters_Promise = 556;
            public static int The_Dapper_Prodigy = 1471;
            public static int The_Throne = 1635;
            public static int The_Endless_Darkness = 7393;
            public static int The_Dreamer = 4916;
            public static int The_Dark_Mage = 1472;
            public static int The_Wilted_Rose = 7387;
            public static int The_Tyrant = 1642;
            public static int The_Cartographer = 1451;
            public static int The_Inventor = 1533;
            public static int The_Offering = 1559;
            public static int The_Warlord = 1663;
            public static int Lingering_Remnants = 2039;
            public static int The_Obscured = 4860;
            public static int The_Jewellers_Boon = 6902;
            public static int The_Innocent = 7382;
            public static int The_Price_of_Protection = 7402;
            public static int Emperor_of_Purity = 480;
            public static int Rebirth = 2595;
            public static int Humility = 645;
            public static int The_Standoff = 2046;
            public static int The_Wretched = 2038;
            public static int The_Chains_that_Bind = 1458;
            public static int Blind_Venture = 170;
            public static int Diallas_Subjugation = 422;
            public static int Earth_Drinker = 468;
            public static int Gift_of_the_Gemling_Queen = 568;
            public static int The_Ruthless_Ceinture = 2291;
            public static int A_Dab_Of_Ink = 18957;
        }

        public static class Weapons
        {
            public static int Piscators_Vigil = 937;
            public static int Jorrhasts_Blacksteel = 690;
            public static int Izaros_Dilemma = 684;
            public static int Innsbury_Edge = 675;
            public static int Hegemonys_Era = 614;
            public static int Edge_of_Madness = 474;
            public static int Dreamfeather = 446;
            public static int Doon_Cuebiyari = 440;
            public static int Brightbeak = 197;
            public static int Amplification_Rod = 51;
            public static int Quill_Rain = 1001;
            public static int The_Tempestuous_Steel = 1632;
            public static int Ahns_Might = 2316;
            public static int Tulfall = 2011;
            public static int Arakaalis_Fang = 1975;
            public static int Xirgils_Crank = 1897;
            public static int The_Scourge = 1594;
            public static int Realm_Ender = 1021;
            public static int Chin_Sol = 267;
            public static int Bloodseeker = 179;
            public static int Beltimber_Blade = 2504;
            public static int The_Grey_Spire = 7392;
            public static int Trypanon = 1722;
            public static int Razor_of_the_Seventh_Sun = 1017;
            public static int Reach_of_the_Council = 1018;
            public static int Singularity = 1313;
            public static int Axiom_Perpetuum = 135;
            public static int Midnight_Bargain = 812;
            public static int Pledge_of_Hands = 955;
            public static int Brain_Rattler = 189;
            public static int Deaths_Hand = 393;
            public static int Lifesprig = 743;
            public static int Geofris_Devotion = 4866;
            public static int Augyre = 2481;
            public static int Hopeshredder = 2463;
            public static int Vulconus = 2322;
            public static int The_Wasp_Nest = 2197;
            public static int Dying_Breath = 2061;
            public static int Uul_Netols_Kiss = 1963;
            public static int Xophs_Inception = 1958;
            public static int Hand_of_Thought_and_Motion = 1954;
            public static int Tulborn = 1951;
            public static int Voltaxic_Rift = 1813;
            public static int Touch_of_Anguish = 1705;
            public static int The_Supreme_Truth = 1623;
            public static int The_Princess = 1575;
            public static int The_Dark_Seer = 1473;
            public static int Spine_of_the_First_Claimant = 1348;
            public static int Slivertongue = 1321;
            public static int The_Harvest = 1519;
            public static int Balefire = 2281;
            public static int Shade_of_Solaris = 1972;
            public static int Grelwood_Shank = 2305;
            public static int Disintegrator = 4892;
            public static int Uul_Netols_Embrace = 2008;
            public static int Kitavas_Feast = 1974;
            public static int The_Gryphon = 1516;
            public static int Silverbough = 1306;
            public static int Agnerod_North = 32;
            public static int Shimmeron = 2479;
            public static int Soul_Taker = 1335;
            public static int Corona_Solaris = 5974;
            public static int Varunastra = 1765;
            public static int Agnerod_East = 29;
            public static int Mirebough = 4894;
            public static int Ngamahus_Flame = 1957;
            public static int Xophs_Nurture = 1978;
            public static int Soulwrest = 7377;
            public static int Severed_in_Sleep = 1990;
            public static int Dreadsurge = 4919;
            public static int Chaber_Cairn = 7452;
            public static int Panquetzaliztli = 4882;
            public static int Martyr_of_Innocence = 2084;
            public static int The_Stormwall = 4924;
            public static int Divinarius = 423;
            public static int Hrimnors_Dirge = 638;
            public static int Agnerod_South = 35;
            public static int Sanguine_Gambol = 4871;
            public static int Hand_of_Wisdom_and_Action = 1992;
            public static int The_Enmity_Divine = 2235;
            public static int Ichimonji = 659;
            public static int Doomfletchs_Prism = 434;
            public static int Agnerod_West = 38;
            public static int Breath_of_the_Council = 196;
            public static int Cerberus_Limb = 7418;
            public static int Jack, _the_Axe = 687;
            public static int Apeps_Rage = 66;
            public static int Scaeva = 1082;
            public static int Montreguls_Grasp = 824;
            public static int Roths_Reach = 1070;
            public static int Relentless_Fury = 1045;
            public static int Dreadarc = 444;
            public static int Cybils_Paw = 343;
            public static int Earendels_Embrace = 6884;
            public static int Cane_of_Unravelling = 2256;
            public static int White_Wind = 2255;
            public static int Wildslash = 1880;
            public static int Wideswing = 1877;
            public static int Nuros_Harp = 873;
            public static int Tremor_Rod = 1713;
            public static int Storm_Cloud = 1368;
            public static int Silverbranch = 1309;
            public static int Shiversting = 1273;
            public static int Rigwalds_Charge = 1055;
            public static int Reverberation_Rod = 1054;
            public static int Reapers_Pursuit = 1027;
            public static int Realmshaper = 1024;
            public static int Quecholli = 990;
            public static int Prismatic_Eclipse = 975;
            public static int Mortem_Morsu = 831;
            public static int The_Blood_Reaper = 1434;
            public static int Rebuke_of_the_Vaal = 1032;
            public static int Widowmaker = 1879;
            public static int The_Stormheart = 1620;
            public static int Ungils_Gauche = 1746;
            public static int Twyzel = 1727;
            public static int Pillar_of_the_Caged_God = 934;
            public static int Hrimnors_Hymn = 640;
            public static int Goredrill = 578;
            public static int Fencoil = 524;
            public static int Bloodplay = 178;
            public static int Bitterdream = 162;
            public static int Geofris_Baptism = 557;
            public static int Abberaths_Horn = 12;
            public static int The_Blood_Thorn = 1437;
            public static int Ashcaller = 101;
            public static int Ewars_Mirage = 1955;
            public static int The_Whispering_Ice = 1672;
            public static int Storm_Prison = 1373;
            public static int Queens_Decree = 995;
            public static int Debeons_Dirge = 2198;
            public static int Iron_Commander = 679;
            public static int Aurumvorax = 133;
            public static int Obliteration = 880;
            public static int Daressos_Passion = 348;
            public static int Moonsorrow = 826;
            public static int Laviangas_Wisdom = 740;
            public static int Moonbenders_Wing = 825;
            public static int Marohi_Erqi = 788;
            public static int Mark_of_the_Doubting_Knight = 787;
            public static int Last_Resort = 737;
            public static int The_Searing_Touch = 1597;
            public static int The_Screaming_Eagle = 1596;
            public static int The_Goddess_Bound = 1512;
            public static int Terminus_Est = 1401;
            public static int Sire_of_Shards = 1314;
            public static int Rive = 1065;
            public static int Redbeak = 1034;
            public static int Ornament_of_the_East = 898;
            public static int Nulls_Inclination = 870;
            public static int Mightflay = 814;
            public static int Limbsplit = 752;
            public static int Lakishus_Blade = 734;
            public static int Kongors_Undying_Rage = 727;
            public static int Hezmanas_Bloodlust = 621;
            public static int Frostbreath = 553;
            public static int Dyadus = 461;
            public static int Doomfletch = 431;
            public static int Deaths_Harp = 394;
            public static int Binos_Kitchen_Knife = 160;
            public static int Allure = 45;
            public static int Chitus_Needle = 271;
            public static int Taryns_Shiver = 1390;
            public static int Lioneyes_Glare = 755;
            public static int Essentia_Sanguis = 2085;
            public static int Arborix = 2522;
            public static int Hyaons_Fury = 650;
            public static int Nyctas_Lantern = 876;
            public static int Hiltless = 629;
            public static int Heartbreaker = 611;
            public static int Gorebreaker = 577;
            public static int Flesh_Eater = 535;
            public static int Fidelitas_Spike = 527;
            public static int Femurs_of_the_Saints = 521;
            public static int Eclipse_Solaris = 473;
            public static int Doomsower = 437;
            public static int Darkscorn = 355;
            public static int Chober_Chaber = 272;
            public static int Camerias_Maul = 218;
            public static int Al_Dhih = 41;
            public static int Advancing_Fortress = 26;
            public static int The_Dancing_Dervish = 1469;
            public static int Kaoms_Primacy = 704;
            public static int Clayshaper = 276;
            public static int The_Consuming_Dark = 1461;
            public static int Infractem = 672;
            public static int Ephemeral_Edge = 490;
            public static int Callinellus_Malleus = 217;
            public static int Sinvictas_Mettle = 6919;
            public static int Wings_of_Entropy = 1887;
            public static int Oros_Sacrifice = 899;
            public static int Kondos_Pride = 723;
            public static int Camerias_Avarice = 4923;
            public static int Mjölner = 821;
            public static int Atziris_Disfavour = 120;
            public static int Void_Battery = 1795;
            public static int Rigwalds_Command = 1057;
            public static int The_Poets_Pen = 2258;
            public static int Rigwalds_Savagery = 1061;
            public static int United_in_Dream = 2022;
            public static int Voidhome = 1799;
            public static int Nebuloch = 2304;
            public static int Duskdawn = 1997;
            public static int Tidebreaker = 2089;
            public static int The_Goddess_Scorned = 1513;
            public static int Dreadbeak = 4875;
            public static int Deaths_Opus = 400;
            public static int The_Cauteriser = 1454;
            public static int Brutus_Lead_Sprinkler = 212;
            public static int The_Tempest = 1629;
            public static int Queens_Escape = 998;
            public static int The_Dancing_Duo = 4929;
            public static int Kingmaker = 714;
            public static int Cospris_Malice = 307;
            public static int Starforge = 1360;
            public static int Voidforge = 4937;
            public static int Windripper = 1882;
            public static int The_Rippling_Thoughts = 2231;
            public static int Doryanis_Catalyst = 441;
            public static int Taproot = 2194;
        }
    }

    public class A
    {
        public static ItemCombinationResultBuilder Result => new ItemCombinationResultBuilder();
        public static ItemCombinationBuilderWithFixedResult ItemCombinationWithAFixedResult => new ItemCombinationBuilderWithFixedResult();
    }

    public class An
    {
        public static ItemWithAmountBuilder Ingredient => new ItemWithAmountBuilder();
    }


    

    public class ItemCombinationBuilderWithFixedResult
    {
        public ItemCombinationBuilderWithFixedResult()
        {
            ItemCombination = new ItemCombinationWithFixedResult {CombinationType = CombinationType.DivinationCard};
        }

        private ItemCombinationWithFixedResult ItemCombination { get; }

        public ItemCombinationBuilderWithFixedResult ThatUsesTheIngridients(List<ItemWithAmount> ingredients)
        {
            ItemCombination.Ingredients = ingredients;
            return this;
        }

        public ItemCombinationBuilderWithFixedResult WithTheItemResult(int itemIngameId,bool corrupted = false)
        {
            ItemCombination.Result = A.Result.WithTheItem(itemIngameId,corrupted);
            return this;
        }

        public ItemCombinationBuilderWithFixedResult WithTheSkillGemResult(string nameConstant,int quality,int gemLevel , bool corrupted)
        {
            ItemCombination.Result = A.Result.WithTheItem(
                DatabaseHelper.GetSkillgem(nameConstant,gemLevel,quality,corrupted,CombinationResultsInitalizer.Context)
                , corrupted);
            return this;
        }

        public ItemCombinationBuilderWithFixedResult WithTheSkillGemResult(string nameConstant, int gemLevel, bool corrupted)
        {
            ItemCombination.Result = A.Result.WithTheItem(
                DatabaseHelper.GetSkillgem(nameConstant, gemLevel ,  corrupted, CombinationResultsInitalizer.Context)
                , corrupted);
            return this;
        }


        public ItemCombinationBuilderWithFixedResult WithTheCurrencyResult(int poeNinjaCurrencyId)
        {
            ItemCombination.Result = A.Result.WithTheCurrency(poeNinjaCurrencyId);
            return this;
        }

        public ItemCombinationBuilderWithFixedResult WithTheCombinationType(CombinationType combinationType)
        {
            ItemCombination.CombinationType = combinationType;
            return this;
        }

        public static implicit operator ItemCombinationWithFixedResult(ItemCombinationBuilderWithFixedResult builderWithFixedResult)
        {
            return builderWithFixedResult.ItemCombination;
        }

        public ItemCombinationWithFixedResult ResultTimes(int amount)
        {
            ItemCombination.Result.Amount = amount;
            return this;
        }
    }

    public class ItemCombinationResultBuilder
    {
        private ItemCombinationResult CombinationResult { get; set; }
        public TradingContext Context { get; set; }
        public ItemCombinationResultBuilder()
        {
            Context = CombinationResultsInitalizer.Context;
            CombinationResult = new ItemCombinationResult();
        }

        public ItemCombinationResultBuilder WithTheItem(int ingameItemId, bool corrupted = false)
        {
            CombinationResult.Item = DatabaseHelper.GetItemById(ingameItemId, Context);
            CombinationResult.Corrupted = corrupted;
            return this;
        }

        public ItemCombinationResultBuilder WithTheItem(PoeObject item, bool corrupted = false)
        {
            CombinationResult.Item = item;
            CombinationResult.Corrupted = corrupted;
            return this;
        }

        public ItemCombinationResultBuilder WithTheCurrency(int poeNinjaCurrencyId)
        {
            CombinationResult.Item = (PoeObject)Context.Currencies.First(item => item.PoeNinjaId == poeNinjaCurrencyId);
            CombinationResult.Corrupted = false;
            return this;
        }

        public ItemCombinationResultBuilder Times(int amount)
        {
            CombinationResult.Amount = amount;
            return this;
        }
 

        public static implicit operator ItemCombinationResult(ItemCombinationResultBuilder builder)
        {
            return builder.CombinationResult;
        }


    }

    public class ItemWithAmountBuilder
    {
        public ItemWithAmountBuilder()
        {
            Context = CombinationResultsInitalizer.Context;
            ItemWithAmount = new ItemWithAmount();
        }
        public ItemWithAmountBuilder(int amount) : this()
        {
            ItemWithAmount.Amount = amount;
        }

        private ItemWithAmount ItemWithAmount { get; }
        private TradingContext Context { get; }


        public ItemWithAmountBuilder WithTheItem(int ingameItemId)
        {
            ItemWithAmount.Item = DatabaseHelper.GetItemById(ingameItemId, Context);

            return this;
        }

        public ItemWithAmountBuilder WithTheCurrency(int poeNinjaCurrencyId)
        {
            ItemWithAmount.Item = (PoeObject)Context.Currencies.First(item => item.PoeNinjaId == poeNinjaCurrencyId);
            return this;
        }

        public ItemWithAmountBuilder Times(int amount)
        {
            ItemWithAmount.Amount = amount;
            return this;
        }

        public static implicit operator ItemWithAmount(ItemWithAmountBuilder builder)
        {
            return builder.ItemWithAmount;
        }
    }
}
