using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Redemption.Items;

namespace RedemptionCN.GlobalItems
{
    public class ItemTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
                // 魂符懒得写其他代码了,如果本地化那边修复把这个文件删除，并且把这个移到本地化（魂符本地化的名字暂时删除）
                tooltipLine.Text = tooltipLine.Text.Replace("Crux Card:", "魂符:");
                tooltipLine.Text = tooltipLine.Text.Replace("Common Guard", "共同卫兵");
                tooltipLine.Text = tooltipLine.Text.Replace("Forest Nymph", "森林仙女");
                tooltipLine.Text = tooltipLine.Text.Replace("Gathic Soldiers", "加苏士兵");
                tooltipLine.Text = tooltipLine.Text.Replace("Crumbling Automatons", "损毁岩械");
                tooltipLine.Text = tooltipLine.Text.Replace("Mossy Goliath", "苔藓巨兽");
                tooltipLine.Text = tooltipLine.Text.Replace("Bone Duo", "骨头双人组");
                tooltipLine.Text = tooltipLine.Text.Replace("Gank Squad", "突袭小队");
                tooltipLine.Text = tooltipLine.Text.Replace("Skull Digger", "掘颅者");
                tooltipLine.Text = tooltipLine.Text.Replace("Asher", "阿什卡");
                tooltipLine.Text = tooltipLine.Text.Replace("Kyretha", "凯莉莎");
                // 点此为止
            }
        }
    }
}
