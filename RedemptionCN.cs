using System.Linq;
using System.Reflection;
using System.Threading;
using Terraria;
using Terraria.ModLoader;
namespace RedemptionCN
{
	public class RedemptionCN : Mod
	{
		public override void Load()
		{
			RedemptionTranslator.RedemptionTranslator.LoadTranslator();
			base.Load();
		}
	}
}
