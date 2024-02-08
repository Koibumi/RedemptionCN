using Microsoft.Xna.Framework;
using Terraria;

namespace RedemptionCN.Patch
{
    public class ChatMessages : PatchBase
    {
        public override void Load()
        {
            Terraria.On_Main.NewText_string_byte_byte_byte += NewText_string_byte_byte_byte;
            Terraria.On_Main.NewTextMultiline += NewTextMultiline;
        }
        private static void NewText_string_byte_byte_byte(Terraria.On_Main.orig_NewText_string_byte_byte_byte orig, string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue)
        {
            if (newText == null)
            {
                return;
            }
            if (newText == "TARGET UNIMPORTANT...")
            {
                orig.Invoke($"目标不重要......", R, G, B);
            }
        }
        private static void NewTextMultiline(Terraria.On_Main.orig_NewTextMultiline orig, string text, bool force = false, Color c = default, int WidthLimit = -1)
        {
            if (text == null)
            {
                return;
            }
            if (text == "TARGET UNIMPORTANT...")
            {
                orig.Invoke($"目标不重要......", force, c, WidthLimit);
            }
        }
    }
}
                