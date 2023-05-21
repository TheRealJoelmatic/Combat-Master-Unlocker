using System;
using Il2CppCombatMaster.GDI;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using MelonLoader;

namespace CombatMasterHack_Joelmatic.Cheats
{
	class Unlocker
	{
		public static void SoftUnlockAll()
		{
			//Calls all the methods
			SoftUnlockEmblems();
			SoftUnlockOperator();
			SoftUnlockReticle();
			SoftUnlockWristband();
			SoftUnlockCamoChallenges();
			SoftUnlockWeaponBlueprint();
		}

		//------------------
		//
		// Soft Unlocks
		//
		//------------------

		public static void SoftUnlockEmblems()
		{
			//unlock Emblems
			foreach (EmblemInfo Emblem in Resources.FindObjectsOfTypeAll<EmblemInfo>())
			{
				Emblem.IsPremium = false;
				Emblem.LevelLock = 1;
			}
			MelonLogger.Msg($"Emblems unlocked");
		}
		public static void SoftUnlockOperator()
		{
			//unlock Operator
			foreach (OperatorInfo Operator in Resources.FindObjectsOfTypeAll<OperatorInfo>())
			{
				Operator.IsPremium = false;
				Operator.LevelLock = 1;
			}
			MelonLogger.Msg($"Operators unlocked");
		}
		public static void SoftUnlockReticle()
		{
			//unlock Reticle
			foreach (ReticleAttachmentInfo Reticle in Resources.FindObjectsOfTypeAll<ReticleAttachmentInfo>())
			{
				Reticle.RequiredKills = 0;
			}
			MelonLogger.Msg($"Reticles unlocked");
		}
		public static void SoftUnlockWristband()
		{
			//unlock Wristband
			foreach (WristbandInfo Wristband in Resources.FindObjectsOfTypeAll<WristbandInfo>())
			{
				Wristband.IsPremium = false;
			}
			MelonLogger.Msg($"Wristbands unlocked");
		}
		public static void SoftUnlockCamoChallenges()
		{
			//unlock CamoChallenges
			Il2CppArrayBase<WeaponInfo> val = Resources.FindObjectsOfTypeAll<WeaponInfo>();
			foreach (Il2CppCombatMaster.GDI.WeaponInfo Camo in val)
			{
				Camo.LevelLock = 1;
				Il2CppStructArray<Il2CppCombatMaster.GDI.WeaponInfo.CamoChallengeData> camoChallenges = Camo.CamoChallenges;
				for (int i = 0; i < ((Il2CppArrayBase<Il2CppCombatMaster.GDI.WeaponInfo.CamoChallengeData>)(object)camoChallenges).Length; i++)
				{
					Il2CppCombatMaster.GDI.WeaponInfo.CamoChallengeData val2 = ((Il2CppArrayBase<Il2CppCombatMaster.GDI.WeaponInfo.CamoChallengeData>)(object)camoChallenges)[i];
					val2.RequiredLevel = 1;
					val2._targetValue = 0;
					((Il2CppArrayBase<Il2CppCombatMaster.GDI.WeaponInfo.CamoChallengeData>)(object)camoChallenges)[i] = val2;
				}
			}
			MelonLogger.Msg($"CamoChallenges unlocked");
		}
		public static void SoftUnlockWeaponBlueprint()
		{
			//unlock WeaponBlueprint
			Il2CppArrayBase<WeaponBlueprintInfo> obj = Resources.FindObjectsOfTypeAll<WeaponBlueprintInfo>();
			Il2CppArrayBase<WeaponInfo> val = Resources.FindObjectsOfTypeAll<WeaponInfo>();
			foreach (WeaponBlueprintInfo Blueprint in obj)
			{
				Blueprint._isPremium = false;
			}
			MelonLogger.Msg($"Blueprints unlocked");
		}
	}
}
