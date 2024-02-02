using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Redemption.Items;
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
                // 两行关于魂符的在多开且另一个多开模组未汉化的情况下可能会出现一些文本汉化不完全的现象）以及上面这些内容想改文本的话直接改中文内容就行
            }
        }
    }
}
