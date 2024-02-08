using Terraria.ModLoader;
using RedemptionCN.Patch;

namespace RedemptionCN
{
	public class RedemptionCN : Mod
	{
        public static RedemptionCN Instance;

        public override void Load()
        {
            Instance = this;
            PatchManager.Load();
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}