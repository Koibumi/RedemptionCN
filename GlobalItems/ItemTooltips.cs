using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Redemption.Items;
using Redemption.Items.Armor.Vanity.SkySquire;
using Redemption.Items.Placeable.Furniture.Misc;
using Redemption.Globals;

namespace RedemptionCN.GlobalItems
{
    public class ItemTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
                tooltipLine.Text = tooltipLine.Text.Replace("There is no moonlight to reflect...", "没有可以用来反射的月光......");                     // 月矢，月辉箭，月光杖
                tooltipLine.Text = tooltipLine.Text.Replace("Right-click to summon Nebuleus' Final Form instantly", "右键可立即召唤涅布琉斯的终极形态");// 银河石
                tooltipLine.Text = tooltipLine.Text.Replace("NOTE: This class is not yet complete", "注意：这类物品尚未制作完成");                      // 守夜人的小刀
                tooltipLine.Text = tooltipLine.Text.Replace("base health", "基础生命值");                                                               // 魂符
                tooltipLine.Text = tooltipLine.Text.Replace("defense", "防御");                                                                         // 魂符
                // 两行关于魂符的在多开且另一个多开模组未汉化的情况下可能会出现一些文本汉化不完全的现象）
                // 天空侍卫套装
                tooltipLine.Text = tooltipLine.Text.Replace("Hold [Shift] to view lore", "按住[Shift]可阅读相关故事");
                tooltipLine.Text = tooltipLine.Text.Replace("The Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.", "天空侍卫是南以桑的一支队伍，职责是保护伊林、克莱卡布和诺拉帕斯等王国。");
                tooltipLine.Text = tooltipLine.Text.Replace("The armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'", "他们身上的盔甲相对大多数别的种类，具有更好的灵活性，这对迅速前往救援非常有用。”");
                // 头盔 SkySquiresHelm
                if (item.type == ModContent.ItemType<SkySquiresHelm>())
                {
                    tooltipLine.Text = tooltipLine.Text.Replace("'A sallet helm made of Kanite, worn by the Sky Squires of Ithon. The metal has a blue hue and a cold touch,", "“一种用穹鉲制成的轻盔，为以桑的天空侍卫们所装备。");
                    tooltipLine.Text = tooltipLine.Text.Replace("being used as a replacement for iron which is lacking in southern Ithon.", "这种金属具有蓝色的色调和冰冷的触感，在缺乏铁矿资源的南以桑作为铁的替代品。");
                }
                // 制服 SkySquiresTabard
                if (item.type == ModContent.ItemType<SkySquiresTabard>())
                {
                    tooltipLine.Text = tooltipLine.Text.Replace("'A tabard made of Kanite and cloth in a checkered pattern, worn by the Sky Squires of Ithon. The metal", "“一种用穹鉲和丝绸制成的带方格图案的无袖外罩，为以桑的天空侍卫们所装备。");
                    tooltipLine.Text = tooltipLine.Text.Replace("has a blue hue and a cold touch, being used as a replacement for iron which is lacking in southern Ithon.", "这种金属具有蓝色的色调和冰冷的触感，在缺乏铁矿资源的南以桑作为铁的替代品。");
                }
                // 护胫 SkySquiresGreaves
                if (item.type == ModContent.ItemType<SkySquiresGreaves>())
                {
                    tooltipLine.Text = tooltipLine.Text.Replace("'Greaves made of Kanite, worn by the Sky Squires of Ithon. The metal has a blue hue and a cold touch,", "“一种用穹鉲制成的护胫，为以桑的天空侍卫们所装备。");
                    tooltipLine.Text = tooltipLine.Text.Replace("being used as a replacement for iron which is lacking in southern Ithon.", "这种金属具有蓝色的色调和冰冷的触感，在缺乏铁矿资源的南以桑作为铁的替代品。");
                }
                // 沉没船长画
                if (item.type == ModContent.ItemType<SunkenCaptainPainting>())
                {
                    tooltipLine.Text = tooltipLine.Text.Replace("'Once a great captain, a legend to some,", "曾经是一位伟大的船长，被一些人视作一个传奇。");
                    tooltipLine.Text = tooltipLine.Text.Replace("Even after death would he still sail the seas,", "虽已死去，但他仍在海上航行，");
                    tooltipLine.Text = tooltipLine.Text.Replace("Leading his phantom crew to unknown lands.", "带领他的幻影船员们前往未知的土地。");
                    tooltipLine.Text = tooltipLine.Text.Replace("Only under the brightest light of the moon", "只有在最皎洁的月光下，");
                    tooltipLine.Text = tooltipLine.Text.Replace("Could they set a foot on a seashore.", "他们才能踏上海滩。");
                    tooltipLine.Text = tooltipLine.Text.Replace("Until then, they were ever chasing waves", "在那之前，他们总是在追逐海浪");
                    tooltipLine.Text = tooltipLine.Text.Replace("With the thickest of fog keeping them company.'", "最浓密的雾陪伴着他们。");
                    tooltipLine.Text = tooltipLine.Text.Replace("On the backside there's a note, hold [Shift] to read", "画的背面有一些字，按住[Shift]阅读");
                }
            }
        }
    }
}
