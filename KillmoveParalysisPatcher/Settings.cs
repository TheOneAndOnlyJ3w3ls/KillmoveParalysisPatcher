using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillmoveParalysisPatcher
{

  /*  public class DaedricArtifacts
    {
        [SettingName("Sort Daedric artifacts separately")]
        [Tooltip("Check if you want daedric artifacts to have their own formatting")]
        public bool SortDaedricArtifacts = true;

        [SettingName("Daedric items format")]
        [Tooltip("The format you would like for the daedric artifacts. $name will be the actual name of the artifact, use any string to sort them.")]
        public string DaedricFormatting { get; set; } = "# Daedric # $name";
    }*/

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
    }
}