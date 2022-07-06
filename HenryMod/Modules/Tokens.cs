using R2API;
using System;

namespace RegMIAMod.Modules
{
    internal static class Tokens
    {
        // TODO: finish most of these
        internal static void AddTokens()
        {
            #region Reg
            string prefix = RegMIAPlugin.DEVELOPER_PREFIX + "_REG_BODY_";

            // todo: add style tags for readability
            string desc = "Reg is a robotic being who appears to be a little boy." + Environment.NewLine + Environment.NewLine +
                "His actual age, origins, and even name are unknown because he cannot recall anything about his life before his encounter with Riko." + Environment.NewLine + Environment.NewLine +
                "He is named after a dog Riko used to have." + Environment.NewLine + Environment.NewLine + 
                "< ! > Punch is a solid basic attack that deals moderate damage at close range." + Environment.NewLine + Environment.NewLine + 
                "< ! > Extendable Arms is a good single-target anti-air attack, and it is also useful for mobility." + Environment.NewLine + Environment.NewLine +
                "< ! > SHIFT ABILITY TODO" + Environment.NewLine + Environment.NewLine +
                "< ! > Incinerator can be used to decimate enemies within line of sight, but has a limited number of uses per stage." + Environment.NewLine + Environment.NewLine
                ;

            string lore = "TODO";

            string outro = "..and so he remained in the abyss, having succeeded in discovering his true self.";
            string outroFailure = "..and so he vanished, forever a blank slate."; // thanks Henry, this fits with Reg too lol

            LanguageAPI.Add(prefix + "NAME", "Reg");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Treasure of the Deep");
            LanguageAPI.Add(prefix + "LORE", lore);
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Out of Control");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Reg passive");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "Sample text.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_NAME", "Punch");
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Helpers.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_GUN_NAME", "Extendable Arms");
            LanguageAPI.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Helpers.agilePrefix + $"Fire a handgun for <style=cIsDamage>{100f * StaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Roll");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Henry: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Henry, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Henry: Mastery");
            #endregion
            #endregion
        }
    }
}