using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace KillmoveParalysisPatcher
{
    public class Settings
    {
        //public DaedricArtifacts DaedricArtifacts { get; set; } = new();

        // Paralysis
        [SettingName("Prevent Killmove Paralysis")]
        [Tooltip("Prevent NPCs or creatures from getting paralyzed in the middle of killmoves")]
        public bool PreventKillmoveParalysis = true;

        // Stagger
        [SettingName("Prevent Killmove Stagger (EXPERIMENTAL)")]
        [Tooltip("Prevent NPCs or creatures from getting staggered in the middle of killmoves (EXPERIMENTAL)")]
        public bool PreventKillmoveStagger = false;


        // Debug
        [SettingName("Debug")]
        [Tooltip("Leave this off unless asked to, this is just for debugging purposes")]
        public bool Debug = false;
    }
}