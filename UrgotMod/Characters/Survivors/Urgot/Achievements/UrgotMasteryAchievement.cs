using RoR2;
using HenryMod.Modules.Achievements;

namespace UrgotMod.Survivors.Urgot.Achievements
{
    //automatically creates language tokens "ACHIEVMENT_{identifier.ToUpper()}_NAME" and "ACHIEVMENT_{identifier.ToUpper()}_DESCRIPTION" 
    [RegisterAchievement(identifier, unlockableIdentifier, null, 10, null)]
    public class UrgotMasteryAchievement : BaseMasteryAchievement
    {
        public const string identifier = UrgotSurvivor.URGOT_PREFIX + "masteryAchievement";
        public const string unlockableIdentifier = UrgotSurvivor.URGOT_PREFIX + "masteryUnlockable";

        public override string RequiredCharacterBody => UrgotSurvivor.instance.bodyName;

        //difficulty coeff 3 is monsoon. 3.5 is typhoon for grandmastery skins
        public override float RequiredDifficultyCoefficient => 3;
    }
}