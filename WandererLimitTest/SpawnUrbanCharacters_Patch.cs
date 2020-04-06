using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using TaleWorlds.CampaignSystem.SandBox.CampaignBehaviors;
using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

using System.Windows.Forms;
using System.Reflection.Emit;

using System.IO;

namespace WandererLimitTest
{
    [HarmonyPatch(typeof(UrbanCharactersCampaignBehavior))]
    [HarmonyPatch("SpawnUrbanCharacters")]
    public static class SpawnUrbanCharacters_Patch
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            codes.RemoveRange(141, 3);
            return codes.AsEnumerable();
        }
    }
}
