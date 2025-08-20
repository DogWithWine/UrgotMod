using UrgotMod.Survivors.Urgot.SkillStates;

namespace UrgotMod.Survivors.Urgot
{
    public static class UrgotStates
    {
        public static void Init()
        {
            Modules.Content.AddEntityState(typeof(SlashCombo));

            Modules.Content.AddEntityState(typeof(Shoot));

            Modules.Content.AddEntityState(typeof(Roll));

            Modules.Content.AddEntityState(typeof(ThrowBomb));
        }
    }
}
