using System;
using Il2CppCombatMaster.GDI;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using MelonLoader;
using Il2CppCombatMaster.GDI.Loot;
using Il2Cpp;
using System.Linq;

namespace CombatMasterHack_Joelmatic.Cheats
{
    class HUnlocker
    {
        private static List<(MatchInfo, EntityType, ushort, ushort, ushort, ushort, float)> originalMatchInfoValues = new List<(MatchInfo, EntityType, ushort, ushort, ushort, ushort, float)>();

        public static void MaxLevel()
        {
            foreach (LevelsInfo item5 in Resources.FindObjectsOfTypeAll<LevelsInfo>())
            {
                for (int j = 0; j < 55; j++)
                {
                    List<uint> xpOfLevel = item5._xpOfLevel;
                    xpOfLevel[j] = 0u;
                }
            }
            MelonLogger.Msg($"Max Level LOADED");
        }

        public static void XPBoost()
        {
            Il2CppArrayBase<MatchInfo> obj = Resources.FindObjectsOfTypeAll<MatchInfo>();
            foreach (MatchInfo item in obj)
            {
                item.FirstPlaceExpBonus = (ushort)short.MaxValue;
                item.HighlightExpMultiplier = (ushort)short.MaxValue;
                item.SecondPlaceExpBonus = (ushort)short.MaxValue;
                item.ThirdPlaceExpBonus = (ushort)short.MaxValue;
                item.VictoryExpBonus = (ushort)short.MaxValue;
            }
            MelonLogger.Msg($"XP boost LOADED");
        }
        public static void BattlePass()
        {
            foreach (BattlePassInfo item in Resources.FindObjectsOfTypeAll<BattlePassInfo>())
            {
                Il2CppStructArray<BattlePassItem> levelsBattlePassItems = item.LevelsBattlePassItems;
                for (int i = 0; i < ((Il2CppArrayBase<BattlePassItem>)(object)levelsBattlePassItems).Count; i++)
                {
                    BattlePassItem val = ((Il2CppArrayBase<BattlePassItem>)(object)levelsBattlePassItems)[i];
                    val.ExpToGetItem = 0u;
                    val.IsFree = true;
                    ((Il2CppArrayBase<BattlePassItem>)(object)levelsBattlePassItems)[i] = val;
                }
                List<BattlePassItem> allBattlePassItems = item.AllBattlePassItems;
                for (int j = 0; j < allBattlePassItems.Count; j++)
                {
                    BattlePassItem val2 = allBattlePassItems[j];
                    val2.ExpToGetItem = 0u;
                    val2.IsFree = true;
                    allBattlePassItems[j] = val2;
                }
            }
            MelonLogger.Msg($"BattlePass LOADED");
        }

        public static void FreeBundles()
        {
            Il2CppArrayBase<ShopBundleLootInfo> obj = Resources.FindObjectsOfTypeAll<ShopBundleLootInfo>();
            ShopBundleLootInfo[] objArray = obj.ToArray();
            StoreKey storeKey = ((ShopLootInfo)objArray.FirstOrDefault((ShopBundleLootInfo info) => ((UnityEngine.Object)info).name == "4.GrenadeLauncher")).StoreKey;
            foreach (ShopBundleLootInfo item in objArray)
            {
                ((ShopLootInfo)item).StoreKey = storeKey;
                ((ShopLootInfo)item).BuyPrice = new Price((EnumPublicSealedvaMoRe3vUnique)0, 0u);
            }
        }
    }
}