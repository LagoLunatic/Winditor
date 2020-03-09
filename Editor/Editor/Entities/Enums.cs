﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindEditor
{
    public enum BokoblinHeldItem
    {
        Unlit_Torch,
        Machete_1,
        Lit_Torch,
        Machete_2
    }

    public enum BokoblinType
    {
        Wandering,
        Unknown_1,
        Unknown_2,
        Hiding_in_a_Pot,
        Guarding,
        Being_Carried_by_a_Kargaroc,
        Search_Light_Operator,
        Jumping,
        Guarding_and_Yawning = 10,
        Pink_Bokoblin_with_Telescope,
        Debug = 15
    }

    public enum BombFlowerType
    {
        Ripe,
        Withered
    }

    public enum ChestType
    {
        Light_wood,
        Dark_wood,
        Metal,
        Big_Key
    }

    public enum ChestBehavior
    {
        Normal,
        Spawn_when_a_switch_is_set,
        Spawn_when_all_enemies_are_defeated,
        Visible_but_unopenable_until_a_switch_is_set,
        Transparent_until_a_switch_is_set,
        Apply_gravity,
        Spawn_when_a_Wind_Waker_song_is_played,
        Uses_extra_open_flag,
        Uses_extra_open_flag_and_spawns_when_a_switch_is_set
    }

    public enum FoliageType
    {
        Grass,
        Tree,
        White_Flower,
        Pink_Flower
    }

    public enum GohdanComponent
    {
        Head,
        Left_Hand,
        Right_Hand
    }

    public enum ObjPaperType
    {
        Normal_Papers,
        Ornate_Papers,
        Stone
    }

    public enum ItemID
    {
        Heart = 0x00,
        Green_Rupee = 0x01,
        Blue_Rupee = 0x02,
        Yellow_Rupee = 0x03,
        Red_Rupee = 0x04,
        Purple_Rupee = 0x05,
        Orange_Rupee = 0x06,
        Piece_of_Heart = 0x07,
        Heart_Container = 0x08,
        Small_Magic_Jar = 0x09,
        Large_Magic_Jar = 0x0A,
        Bombs_5 = 0x0B,
        Bombs_10 = 0x0C,
        Bombs_20 = 0x0D,
        Bombs_30 = 0x0E,
        Silver_Rupee = 0x0F,
        Arrows_10 = 0x10,
        Arrows_20 = 0x11,
        Arrows_30 = 0x12,
        Unknown_13 = 0x13,
        Unknown_14 = 0x14,
        Small_Key = 0x15,
        Fairy = 0x16,
        Unknown_17 = 0x17,
        Unknown_18 = 0x18,
        Unknown_19 = 0x19,
        Yellow_Rupee_Joke_Message = 0x1A,
        Unknown_1B = 0x1B,
        Unknown_1C = 0x1C,
        Unknown_1D = 0x1D,
        Three_Hearts = 0x1E,
        Joy_Pendant = 0x1F,
        Telescope = 0x20,
        Tingle_Tuner = 0x21,
        Wind_Waker = 0x22,
        Picto_Box = 0x23,
        Spoils_Bag = 0x24,
        Grappling_Hook = 0x25,
        Deluxe_Picto_Box = 0x26,
        Heros_Bow = 0x27,
        Power_Bracelets = 0x28,
        Iron_Boots = 0x29,
        Magic_Armor = 0x2A,
        Unknown_2B = 0x2B,
        Bait_Bag = 0x2C,
        Boomerang = 0x2D,
        Unknown_2E = 0x2E,
        Hookshot = 0x2F,
        Delivery_Bag = 0x30,
        Bombs = 0x31,
        Heros_Clothes = 0x32,
        Skull_Hammer = 0x33,
        Deku_Leaf = 0x34,
        Fire_and_Ice_Arrows = 0x35,
        Light_Arrow = 0x36,
        Heros_New_Clothes = 0x37,
        Heros_Sword = 0x38,
        Powerless_Master_Sword = 0x39,
        Half_Power_Master_Sword = 0x3A,
        Heros_Shield = 0x3B,
        Mirror_Shield = 0x3C,
        Recovered_Heros_Sword = 0x3D,
        Full_Power_Master_Sword = 0x3E,
        Piece_of_Heart_Alternate_Message = 0x3F,
        Unknown_40 = 0x40,
        Unknown_41 = 0x41,
        Pirates_Charm = 0x42,
        Heros_Charm = 0x43,
        Unknown_44 = 0x44,
        Skull_Necklace = 0x45,
        Boko_Baba_Seed = 0x46,
        Golden_Feather = 0x47,
        Knights_Crest = 0x48,
        Red_Chu_Jelly = 0x49,
        Green_Chu_Jelly = 0x4A,
        Blue_Chu_Jelly = 0x4B,
        Dungeon_Map = 0x4C,
        Compass = 0x4D,
        Big_Key = 0x4E,
        Unknown_4F = 0x4F,
        Empty_Bottle = 0x50,
        Red_Potion = 0x51,
        Green_Potion = 0x52,
        Blue_Potion = 0x53,
        Elixir_Soup_Half_Full = 0x54,
        Elixir_Soup = 0x55,
        Bottled_Water = 0x56,
        Fairy_in_Bottle = 0x57,
        Forest_Firefly = 0x58,
        Forest_Water = 0x59,
        Unknown_5A = 0x5A,
        Unknown_5B = 0x5B,
        Unknown_5C = 0x5C,
        Unknown_5D = 0x5D,
        Unknown_5E = 0x5E,
        Unknown_5F = 0x5F,
        Unknown_60 = 0x60,
        Triforce_Shard_1 = 0x61,
        Triforce_Shard_2 = 0x62,
        Triforce_Shard_3 = 0x63,
        Triforce_Shard_4 = 0x64,
        Triforce_Shard_5 = 0x65,
        Triforce_Shard_6 = 0x66,
        Triforce_Shard_7 = 0x67,
        Triforce_Shard_8 = 0x68,
        Nayrus_Pearl = 0x69,
        Dins_Pearl = 0x6A,
        Farores_Pearl = 0x6B,
        Unknown_6C = 0x6C,
        Winds_Requiem = 0x6D,
        Ballad_of_Gales = 0x6E,
        Command_Melody = 0x6F,
        Earth_Gods_Lyric = 0x70,
        Wind_Gods_Aria = 0x71,
        Song_of_Passing = 0x72,
        Unknown_73 = 0x73,
        Unknown_74 = 0x74,
        Unknown_75 = 0x75,
        Unknown_76 = 0x76,
        Unknown_77 = 0x77,
        Boats_Sail = 0x78,
        Triforce_Chart_1_Deciphered = 0x79,
        Triforce_Chart_2_Deciphered = 0x7A,
        Triforce_Chart_3_Deciphered = 0x7B,
        Triforce_Chart_4_Deciphered = 0x7C,
        Triforce_Chart_5_Deciphered = 0x7D,
        Triforce_Chart_6_Deciphered = 0x7E,
        Triforce_Chart_7_Deciphered = 0x7F,
        Triforce_Chart_8_Deciphered = 0x80,
        Unknown_81 = 0x81,
        All_Purpose_Bait = 0x82,
        Hyoi_Pear = 0x83,
        Unknown_84 = 0x84,
        Unknown_85 = 0x85,
        Unknown_86 = 0x86,
        Unknown_87 = 0x87,
        Unknown_88 = 0x88,
        Unknown_89 = 0x89,
        Unknown_8A = 0x8A,
        Unknown_8B = 0x8B,
        Town_Flower = 0x8C,
        Sea_Flower = 0x8D,
        Exotic_Flower = 0x8E,
        Heros_Flag = 0x8F,
        Big_Catch_Flag = 0x90,
        Big_Sale_Flag = 0x91,
        Pinwheel = 0x92,
        Sickle_Moon_Flag = 0x93,
        Skull_Tower_Idol = 0x94,
        Fountain_Idol = 0x95,
        Postman_Statue = 0x96,
        Shop_Guru_Statue = 0x97,
        Fathers_Letter = 0x98,
        Note_to_Mom = 0x99,
        Maggies_Letter = 0x9A,
        Moblins_Letter = 0x9B,
        Cabana_Deed = 0x9C,
        Complimentary_ID = 0x9D,
        FillUp_Coupon = 0x9E,
        Legendary_Pictograph = 0x9F,
        Unknown_A0 = 0xA0,
        Unknown_A1 = 0xA1,
        Unknown_A2 = 0xA2,
        Dragon_Tingle_Statue = 0xA3,
        Forbidden_Tingle_Statue = 0xA4,
        Goddess_Tingle_Statue = 0xA5,
        Earth_Tingle_Statue = 0xA6,
        Wind_Tingle_Statue = 0xA7,
        Unknown_A8 = 0xA8,
        Unknown_A9 = 0xA9,
        Hurricane_Spin = 0xAA,
        Rupee_Wallet_1000 = 0xAB,
        Rupee_Wallet_5000 = 0xAC,
        Bomb_Bag_60 = 0xAD,
        Bomb_Bag_99 = 0xAE,
        Arrow_Quiver_60 = 0xAF,
        Arrow_Quiver_99 = 0xB0,
        Unknown_B1 = 0xB1,
        Magic_Meter_Upgrade = 0xB2,
        Tingle_Statues_Reward_50_Rupees = 0xB3,
        Tingle_Statues_Reward_100_Rupees = 0xB4,
        Tingle_Statues_Reward_150_Rupees = 0xB5,
        Tingle_Statues_Reward_200_Rupees = 0xB6,
        Tingle_Statues_Reward_250_Rupees = 0xB7,
        Tingle_Statues_Reward_500_Rupees = 0xB8,
        Unknown_B9 = 0xB9,
        Unknown_BA = 0xBA,
        Unknown_BB = 0xBB,
        Unknown_BC = 0xBC,
        Unknown_BD = 0xBD,
        Unknown_BE = 0xBE,
        Unknown_BF = 0xBF,
        Unknown_C0 = 0xC0,
        Unknown_C1 = 0xC1,
        Submarine_Chart = 0xC2,
        Beedles_Chart = 0xC3,
        Platform_Chart = 0xC4,
        Light_Ring_Chart = 0xC5,
        Secret_Cave_Chart = 0xC6,
        Sea_Hearts_Chart = 0xC7,
        Island_Hearts_Chart = 0xC8,
        Great_Fairy_Chart = 0xC9,
        Octo_Chart = 0xCA,
        INcredible_Chart = 0xCB,
        Treasure_Chart_7 = 0xCC,
        Treasure_Chart_27 = 0xCD,
        Treasure_Chart_21 = 0xCE,
        Treasure_Chart_13 = 0xCF,
        Treasure_Chart_32 = 0xD0,
        Treasure_Chart_19 = 0xD1,
        Treasure_Chart_41 = 0xD2,
        Treasure_Chart_26 = 0xD3,
        Treasure_Chart_8 = 0xD4,
        Treasure_Chart_37 = 0xD5,
        Treasure_Chart_25 = 0xD6,
        Treasure_Chart_17 = 0xD7,
        Treasure_Chart_36 = 0xD8,
        Treasure_Chart_22 = 0xD9,
        Treasure_Chart_9 = 0xDA,
        Ghost_Ship_Chart = 0xDB,
        Tingles_Chart = 0xDC,
        Treasure_Chart_14 = 0xDD,
        Treasure_Chart_10 = 0xDE,
        Treasure_Chart_40 = 0xDF,
        Treasure_Chart_3 = 0xE0,
        Treasure_Chart_4 = 0xE1,
        Treasure_Chart_28 = 0xE2,
        Treasure_Chart_16 = 0xE3,
        Treasure_Chart_18 = 0xE4,
        Treasure_Chart_34 = 0xE5,
        Treasure_Chart_29 = 0xE6,
        Treasure_Chart_1 = 0xE7,
        Treasure_Chart_35 = 0xE8,
        Treasure_Chart_12 = 0xE9,
        Treasure_Chart_6 = 0xEA,
        Treasure_Chart_24 = 0xEB,
        Treasure_Chart_39 = 0xEC,
        Treasure_Chart_38 = 0xED,
        Treasure_Chart_2 = 0xEE,
        Treasure_Chart_33 = 0xEF,
        Treasure_Chart_31 = 0xF0,
        Treasure_Chart_23 = 0xF1,
        Treasure_Chart_5 = 0xF2,
        Treasure_Chart_20 = 0xF3,
        Treasure_Chart_30 = 0xF4,
        Treasure_Chart_15 = 0xF5,
        Treasure_Chart_11 = 0xF6,
        Triforce_Chart_8 = 0xF7,
        Triforce_Chart_7 = 0xF8,
        Triforce_Chart_6 = 0xF9,
        Triforce_Chart_5 = 0xFA,
        Triforce_Chart_4 = 0xFB,
        Triforce_Chart_3 = 0xFC,
        Triforce_Chart_2 = 0xFD,
        Triforce_Chart_1 = 0xFE,
        No_item = 0xFF,
    }
}
