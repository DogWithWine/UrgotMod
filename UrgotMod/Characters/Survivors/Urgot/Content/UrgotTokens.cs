using System;
using UrgotMod.Modules;
using UrgotMod.Survivors.Urgot.Achievements;

namespace UrgotMod.Survivors.Urgot
{
    public static class UrgotTokens
    {
        public static void Init()
        {
            AddUrgotTokens();

            ////uncomment this to spit out a lanuage file with all the above tokens that people can translate
            ////make sure you set Language.usingLanguageFolder and printingEnabled to true
            //Language.PrintOutput("Henry.txt");
            ////refer to guide on how to build and distribute your mod with the proper folders
        }

        public static void AddUrgotTokens()
        {
            string prefix = UrgotSurvivor.URGOT_PREFIX;

            string desc = "Crab.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine
             + "< ! > Purge." + Environment.NewLine + Environment.NewLine
             + "< ! > Corrosive Charge." + Environment.NewLine + Environment.NewLine
             + "< ! > Disdain." + Environment.NewLine + Environment.NewLine
             + "< ! > Fear beyond Death." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he moved on, searching for the unworthy.";
            string outroFailure = "..and so he died, weak.";

            Language.Add(prefix + "NAME", "Urgot");
            Language.Add(prefix + "DESCRIPTION", desc);
            Language.Add(prefix + "SUBTITLE", "The Dreadnought");
            Language.Add(prefix + "LORE", "Once a powerful Noxian headsman, Urgot was betrayed by the empire for which he had killed so many. Bound in iron chains, he was forced to learn the true meaning of strength in the Dredge—a prison mine deep beneath Zaun. Emerging in a disaster that spread chaos throughout the city, he now casts an imposing shadow over its criminal underworld. Raising his victims on the very chains that once enslaved him, he will purge his new home of the unworthy, making it a crucible of pain.");
            Language.Add(prefix + "OUTRO_FLAVOR", outro);
            Language.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            Language.Add(prefix + "MASTERY_SKIN_NAME", "Crab");
            #endregion

            #region Passive
            Language.Add(prefix + "PASSIVE_NAME", "Echoing Flames");
            Language.Add(prefix + "PASSIVE_DESCRIPTION", "Urgot's six symetrical, globally alligned legs each conceal a shotgun covering an 60° arc, together forming a full circle of coverfire around him. Each shotgun can fire once befor incurring a unique cooldown\n\t\tEvery attack of Urgot's M1 in a direction of a shotgun that is off cooldown will cause that shotgun to fire in an arc dealing 900% damage and stunning briefly\n.");
            #endregion

            #region Primary
            Language.Add(prefix + "PRIMARY_NAME", "Purge");
            Language.Add(prefix + "PRIMARY_DESCRIPTION", Tokens.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * UrgotStaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            Language.Add(prefix + "SECONDARY_NAME", "Corrosive Charge");
            Language.Add(prefix + "SECONDARY_DESCRIPTION", Tokens.agilePrefix + $"Fire a handgun for <style=cIsDamage>{100f * UrgotStaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            Language.Add(prefix + "UTILITY_NAME", "Disdain");
            Language.Add(prefix + "UTILITY_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            Language.Add(prefix + "SPECIAL_NAME", "Fear beyond Death");
            Language.Add(prefix + "SPECIAL_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * UrgotStaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            Language.Add(Tokens.GetAchievementNameToken(UrgotMasteryAchievement.identifier), "Urgot: Mastery");
            Language.Add(Tokens.GetAchievementDescriptionToken(UrgotMasteryAchievement.identifier), "As Urgot, beat the game or obliterate on Monsoon.");
            #endregion
        }
    }
}
