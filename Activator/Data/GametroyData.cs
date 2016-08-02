﻿#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	Data/HeroObjectData.cs
// Date:		28/07/2016
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using Activator.Base;
using System.Collections.Generic;

namespace Activator.Data
{
    public class GametroyData
    {
        public string Name { get; set; }
        public string ChampionName { get; set; }
        public SpellSlot Slot { get; set; }
        public float Radius { get; set; }
        public double Interval { get; set; }
        public bool PredictDmg { get; set; }
        public HitType[] SpellFlags { get; set; }
        public int DelayFromStart { get; set; }

        public static List<GametroyData> Troys = new List<GametroyData>(); 

        static GametroyData()
        {
            Troys.Add(new GametroyData
            {
                Name = "MonkeyKing_Base_R",
                ChampionName = "MonkeyKing",
                Radius = 165 + 100 + 0 + 1,
                Slot = SpellSlot.R,
                SpellFlags = new [] { HitType.Danger, HitType.Ultimate, HitType.Initiator },
                PredictDmg = true,
                Interval = 0.5
            });

            Troys.Add(new GametroyData
            {
                Name = "R_Cas",
                ChampionName = "Nunu",
                Radius = 650f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.CrowdControl },
                PredictDmg = true,
                Interval = 0.75
            });

            Troys.Add(new GametroyData
            {
                Name = "Ryze_Base_E",
                ChampionName = "Ryze",
                Radius = 200f,
                Slot = SpellSlot.E,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = .75
            });

            Troys.Add(new GametroyData
            {
                Name = "Hecarim_Defile",
                ChampionName = "Hecarim",
                Radius = 425f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = .75
            });

            Troys.Add(new GametroyData
            {
                Name = "W_AoE",
                ChampionName = "Hecarim",
                Radius = 425f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = .75
            });

            Troys.Add(new GametroyData
            {
                Name = "Gangplank_Base_R",
                ChampionName = "Gangplank",
                Radius = 400f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.5
            });

            Troys.Add(new GametroyData
            {
                Name = "W_Shield",
                ChampionName = "Diana",
                Radius = 225f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "W_Shield",
                ChampionName = "Sion",
                Radius = 225f,
                Slot = SpellSlot.W,
                DelayFromStart = 2800,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "W_aoe_red",
                ChampionName = "Malzahar",
                Radius = 325f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "E_Defile",
                ChampionName = "Karthus",
                Radius = 425f,
                Slot = SpellSlot.E,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "W_volatile",
                ChampionName = "Elise",
                Radius =  250f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 0.3
            });

            Troys.Add(new GametroyData
            {
                Name = "DarkWind_tar",
                ChampionName = "FiddleSticks",
                Radius = 250f,
                Slot = SpellSlot.E,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 0.8
            });

            Troys.Add(new GametroyData
            {
                Name = "lr_buf",
                ChampionName = "Kennen",
                Radius = 250f,
                Slot = SpellSlot.E,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 0.8
            });

            Troys.Add(new GametroyData
            {
                Name = "ss_aoe",
                ChampionName = "Kennen",
                Radius = 475f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.Danger, HitType.Ultimate },
                PredictDmg = true,
                Interval = 0.5
            });

            Troys.Add(new GametroyData
            {
                Name = "Ahri_Base_FoxFire",
                ChampionName = "Ahri",
                Radius = 550f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "AurelionSol_Base_P",
                ChampionName = "AurelionSol",
                Radius = 165f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "Fizz_Ring_Red",
                ChampionName = "Fizz",
                Radius = 300f,
                Slot = SpellSlot.R,
                DelayFromStart = 800,
                SpellFlags = new[] { HitType.Danger, HitType.Ultimate },
                PredictDmg = true,
                Interval = 1.0
             });

            Troys.Add(new GametroyData
            {
                Name = "katarina_deathLotus_tar",
                ChampionName = "Katarina",
                Radius = 550f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.ForceExhaust, HitType.Danger },
                PredictDmg = true,
                Interval = 0.5
            });

            Troys.Add(new GametroyData
            {
                Name = "Nautilus_R_sequence_impact",
                ChampionName = "Nautilus",
                Radius = 250f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.CrowdControl, HitType.Danger, HitType.Ultimate },
                PredictDmg = false,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "Acidtrail_buf",
                ChampionName = "Singed",
                Radius = 200f,
                Slot = SpellSlot.Q,
                SpellFlags = new []{ HitType.None },
                PredictDmg = true,
                Interval = 0.5
            });

            Troys.Add(new GametroyData
            {
                Name = "Tremors_cas",
                ChampionName = "Rammus",
                Radius = 450f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "Crowstorm",
                ChampionName = "FiddleSticks",
                Radius = 425f,
                Slot = SpellSlot.R,
                SpellFlags =  new[] { HitType.Danger, HitType.Ultimate, HitType.ForceExhaust },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "yordleTrap_idle",
                ChampionName = "Caitlyn",
                Radius = 265f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.CrowdControl },
                PredictDmg = false,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "tar_aoe_red",
                ChampionName = "Lux",
                Radius = 400f,
                Slot = SpellSlot.E,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 2.0
            });

            Troys.Add(new GametroyData
            {
                Name = "Viktor_ChaosStorm",
                ChampionName = "Viktor",
                Radius = 425f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.Danger, HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "Viktor_Catalyst",
                ChampionName = "Viktor",
                Radius = 375f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.CrowdControl },
                PredictDmg = false,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "W_AUG",
                ChampionName = "Viktor",
                Radius = 375f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.CrowdControl },
                PredictDmg = false,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "cryo_storm",
                ChampionName = "Anivia",
                Radius = 400f,
                Slot = SpellSlot.R,
                SpellFlags = new[] { HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "ZiggsE",
                ChampionName = "Ziggs",
                Radius = 325f,
                Slot = SpellSlot.E,
                SpellFlags = new []{ HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "ZiggsWRing",
                ChampionName = "Ziggs",
                Radius = 325f,
                Slot = SpellSlot.W,
                SpellFlags = new []{ HitType.CrowdControl },
                PredictDmg = false,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "W_Miasma_tar",
                ChampionName = "Cassiopeia",
                Radius = 365f,
                Slot = SpellSlot.W,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "E_rune",
                ChampionName = "Soraka",
                Radius = 375f,
                Slot = SpellSlot.E,
                SpellFlags = new[] { HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            Troys.Add(new GametroyData
            {
                Name = "W_Tar",
                ChampionName = "Morgana",
                Radius = 275f,
                Slot = SpellSlot.W,
                SpellFlags = new []{ HitType.None },
                PredictDmg = true,
                Interval = .75
            });
        }
    }
}