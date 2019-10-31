﻿// <copyright file="CommonEnums.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by an XSL transformation.
//     Do not change this file. Instead, change the XML data which contains
//     the packet definitions and re-run the transformation (rebuild this project).
// </auto-generated>
//------------------------------------------------------------------------------

namespace MUnique.OpenMU.Network.Packets
{
    using System;        /// <summary>
        /// Defines from or to which item storage an item is moved.
        /// </summary>
        public enum ItemStorageKind
        {
            /// <summary>
            /// The inventory storage
            /// </summary>
            Inventory = 0,

            /// <summary>
            /// The trade storage
            /// </summary>
            Trade = 1,

            /// <summary>
            /// The vault storage
            /// </summary>
            Vault = 2,

            /// <summary>
            /// The chaos machine storage
            /// </summary>
            ChaosMachine = 3,

            /// <summary>
            /// The player shop storage
            /// </summary>
            PlayerShop = 4,
        }

        /// <summary>
        /// The quest state for the legacy quest system.
        /// </summary>
        public enum LegacyQuestState
        {
            /// <summary>
            /// The state is undefined. This value is used when there is no quest defined for a specific index
            /// </summary>
            Undefined = 0,

            /// <summary>
            /// The quest is active and in progress.
            /// </summary>
            Active = 1,

            /// <summary>
            /// The quest was completed.
            /// </summary>
            Complete = 2,

            /// <summary>
            /// The quest is inactive, that means it isn't active and wasn't completed yet.
            /// </summary>
            Inactive = 3,
        }

        /// <summary>
        /// Defines the values which are used for the character classes on client side.
        /// </summary>
        public enum CharacterClassNumber
        {
            /// <summary>
            /// Value for the dark wizard character class.
            /// </summary>
            DarkWizard = 0,

            /// <summary>
            /// Value for the soul master character class.
            /// </summary>
            SoulMaster = 2,

            /// <summary>
            /// Value for the grand master character class.
            /// </summary>
            GrandMaster = 3,

            /// <summary>
            /// Value for the dark knight character class.
            /// </summary>
            DarkKnight = 4,

            /// <summary>
            /// Value for the blade knight character class.
            /// </summary>
            BladeKnight = 6,

            /// <summary>
            /// Value for the blade master character class.
            /// </summary>
            BladeMaster = 7,

            /// <summary>
            /// Value for the fairy elf character class.
            /// </summary>
            FairyElf = 8,

            /// <summary>
            /// Value for the muse elf character class.
            /// </summary>
            MuseElf = 10,

            /// <summary>
            /// Value for the high elf character class.
            /// </summary>
            HighElf = 11,

            /// <summary>
            /// Value for the magic gladiator character class.
            /// </summary>
            MagicGladiator = 12,

            /// <summary>
            /// Value for the duel master character class.
            /// </summary>
            DuelMaster = 13,

            /// <summary>
            /// Value for the dark lord character class.
            /// </summary>
            DarkLord = 16,

            /// <summary>
            /// Value for the lord emperor character class.
            /// </summary>
            LordEmperor = 17,

            /// <summary>
            /// Value for the summoner character class.
            /// </summary>
            Summoner = 20,

            /// <summary>
            /// Value for the bloody summoner character class.
            /// </summary>
            BloodySummoner = 22,

            /// <summary>
            /// Value for the dimension master character class.
            /// </summary>
            DimensionMaster = 23,

            /// <summary>
            /// Value for the rage fighter character class.
            /// </summary>
            RageFighter = 24,

            /// <summary>
            /// Value for the fist master character class.
            /// </summary>
            FistMaster = 25,
        }

        /// <summary>
        /// Defines the type of a character stat attribute.
        /// </summary>
        public enum CharacterStatAttribute
        {
            /// <summary>
            /// The strength attribute.
            /// </summary>
            Strength = 0,

            /// <summary>
            /// The agility attribute.
            /// </summary>
            Agility = 1,

            /// <summary>
            /// The vitality attribute.
            /// </summary>
            Vitality = 2,

            /// <summary>
            /// The energy attribute.
            /// </summary>
            Energy = 3,

            /// <summary>
            /// The leadership attribute.
            /// </summary>
            Leadership = 4,
        }

        /// <summary>
        /// Defines the hero state of a character.
        /// </summary>
        public enum CharacterHeroState
        {
            /// <summary>
            /// The character is new and has the highest state.
            /// </summary>
            New = 0,

            /// <summary>
            /// The character is a hero.
            /// </summary>
            Hero = 1,

            /// <summary>
            /// The character is a hero, but the state is almost gone.
            /// </summary>
            LightHero = 2,

            /// <summary>
            /// The character is in a neutral state.
            /// </summary>
            Normal = 3,

            /// <summary>
            /// The character killed another character, and has a kill warning.
            /// </summary>
            PlayerKillWarning = 4,

            /// <summary>
            /// The character killed two characters, and has some restrictions.
            /// </summary>
            PlayerKiller1stStage = 5,

            /// <summary>
            /// The character killed more than two characters, and has hard restrictions.
            /// </summary>
            PlayerKiller2ndStage = 6,
        }

        /// <summary>
        /// Describes the way how the player wants to leave the current game.
        /// </summary>
        public enum LogOutType
        {
            /// <summary>
            /// The player wants to close the game.
            /// </summary>
            CloseGame = 0,

            /// <summary>
            /// The player wants to go back to the character selection screen.
            /// </summary>
            BackToCharacterSelection = 1,

            /// <summary>
            /// The player wants to go back to the server selection screen.
            /// </summary>
            BackToServerSelection = 2,
        }

}