using UrgotMod.Survivors.Urgot.Achievements;
using RoR2;
using UnityEngine;

namespace UrgotMod.Survivors.Urgot
{
    public static class UrgotUnlockables
    {
        public static UnlockableDef characterUnlockableDef = null;
        public static UnlockableDef masterySkinUnlockableDef = null;

        public static void Init()
        {
            masterySkinUnlockableDef = Modules.Content.CreateAndAddUnlockbleDef(
                UrgotMasteryAchievement.unlockableIdentifier,
                Modules.Tokens.GetAchievementNameToken(UrgotMasteryAchievement.identifier),
                UrgotSurvivor.instance.assetBundle.LoadAsset<Sprite>("texMasteryAchievement"));
        }
    }
}
