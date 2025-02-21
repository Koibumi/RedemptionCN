using RedemptionCN.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace RedemptionCN.RedemptionTranslator
{
	public class RedemptionTranslator
	{
		private class Redemption{}
		[ExtendsFromMod("Redemption"), JITWhenModsEnabled("Redemption")]
		private class TranslatorLoad : ForceLocalizeSystem<Redemption, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("Redemption",out var mod))
			{
				#region Redemption.Items.Armor.Vanity.SkySquire.SkySquiresGreaves// 天空侍卫套装：护胫
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Armor.Vanity.SkySquire.SkySquiresGreaves", "ModifyTooltips", new ()
				{
					{"'Greaves made of Kanite, worn by the Sky Squires of Ithon. The metal has a blue hue and a cold touch,\nbeing used as a replacement for iron which is lacking in southern Ithon.\n\nThe Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.\nThe armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'","一种用穹鉲制成的护胫，为以桑的天空侍卫们所装备。\n这种金属具有蓝色的色调和冰冷的触感，在缺乏铁矿资源的南以桑作为铁的替代品。\n\n天空侍卫是南以桑的一支队伍，职责是保护伊林、克莱卡布和诺拉帕斯等王国。\n他们身上的盔甲相对大多数别的种类，具有更好的灵活性，这对迅速前往救援非常有用。"},
				});
				#endregion Redemption.Items.Armor.Vanity.SkySquire.SkySquiresGreaves


				#region Redemption.Items.Armor.Vanity.SkySquire.SkySquiresHelm// 天空侍卫套装：头盔
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Armor.Vanity.SkySquire.SkySquiresHelm", "ModifyTooltips", new ()
				{
					{"'A sallet helm made of Kanite, worn by the Sky Squires of Ithon. The metal has a blue hue and a cold touch,\nbeing used as a replacement for iron which is lacking in southern Ithon.\n\nThe Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.\nThe armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'","一种用穹鉲制成的轻盔，为以桑的天空侍卫们所装备。\n这种金属具有蓝色的色调和冰冷的触感，在缺乏铁矿资源的南以桑作为铁的替代品。\n\n天空侍卫是南以桑的一支队伍，职责是保护伊林、克莱卡布和诺拉帕斯等王国。\n他们身上的盔甲相对大多数别的种类，具有更好的灵活性，这对迅速前往救援非常有用。"},
				});
				#endregion Redemption.Items.Armor.Vanity.SkySquire.SkySquiresHelm


				#region Redemption.Items.Armor.Vanity.SkySquire.SkySquiresTabard// 天空侍卫套装：制服
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Armor.Vanity.SkySquire.SkySquiresTabard", "ModifyTooltips", new ()
				{
					{"'A tabard made of Kanite and cloth in a checkered pattern, worn by the Sky Squires of Ithon. The metal\nhas a blue hue and a cold touch, being used as a replacement for iron which is lacking in southern Ithon.\n\nThe Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.\nThe armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'","一种用穹鉲和丝绸制成的带方格图案的无袖外罩，为以桑的天空侍卫们所装备。\n这种金属具有蓝色的色调和冰冷的触感，在缺乏铁矿资源的南以桑作为铁的替代品。\n\n天空侍卫是南以桑的一支队伍，职责是保护伊林、克莱卡布和诺拉帕斯等王国。\n他们身上的盔甲相对大多数别的种类，具有更好的灵活性，这对迅速前往救援非常有用。"},
				});
				#endregion Redemption.Items.Armor.Vanity.SkySquire.SkySquiresTabard


				#region Redemption.Items.Weapons.PreHM.Ranged.LunarShot// 月矢
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Weapons.PreHM.Ranged.LunarShot", "ModifyTooltips", new ()
				{
					{"There is no moonlight to reflect...","没有可以用来反射的月光..."},
				});
				#endregion Redemption.Items.Weapons.PreHM.Ranged.LunarShot


				#region Redemption.Items.Weapons.PreHM.Ammo.MoonflareArrow// 月辉箭
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Weapons.PreHM.Ammo.MoonflareArrow", "ModifyTooltips", new ()
				{
					{"There is no moonlight to reflect...","没有可以用来反射的月光..."},
				});
				#endregion Redemption.Items.Weapons.PreHM.Ammo.MoonflareArrow


				#region Redemption.Items.Weapons.PreHM.Summon.BaseCruxCard// 魂符
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Weapons.PreHM.Summon.BaseCruxCard", "ModifyTooltips", new ()
				{
					{" base health","基础生命值"},
					{" defense","防御"},
				});
				#endregion Redemption.Items.Weapons.PreHM.Summon.BaseCruxCard


				#region Redemption.Items.Weapons.PreHM.Summon.MoonflareStaff// 月光杖
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Items.Weapons.PreHM.Summon.MoonflareStaff", "ModifyTooltips", new ()
				{
					{"There is no moonlight to reflect...","没有可以用来反射的月光..."},
				});
				#endregion Redemption.Items.Weapons.PreHM.Summon.MoonflareStaff


				#region Redemption.Globals.RedeItem
				TranslatorLoad.LocalizeByTypeFullName("Redemption.Globals.RedeItem", "ModifyTooltips", new ()
				{
					{"-Donator Item-","-捐献者物品-"},
				});
				#endregion Redemption.Globals.RedeItem


				#region Redemption.DamageClasses.RitItem
				TranslatorLoad.LocalizeByTypeFullName("Redemption.DamageClasses.RitItem", "ModifyTooltips", new ()
				{
					{"NOTE: This class is not yet complete","注意：这类物品尚未制作完成"},
				});
				#endregion Redemption.DamageClasses.RitItem


			}
		}
	}
}
