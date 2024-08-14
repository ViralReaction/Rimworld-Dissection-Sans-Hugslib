using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using Verse;

namespace HMDissection
{
    public class Mod_Dissection : Mod
    {

        public static ModSettings_Dissection settings;
        public Mod_Dissection(ModContentPack content) : base(content)
        {
            settings = GetSettings<ModSettings_Dissection>();
            Harmony harmony = new Harmony(this.Content.PackageIdPlayerFacing);
            harmony.PatchAll();

        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            settings.DoSettingsWindowContents(inRect);
        }
        public override string SettingsCategory()
        {
            return "Medical Dissection";
        }
        public override void WriteSettings()
        {
            base.WriteSettings();
        }
    }
}