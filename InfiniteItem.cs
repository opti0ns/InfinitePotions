using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace InfinitePotions
{
    internal class InfiniteItem : GlobalItem
    {

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.buffType != 0)
            {
                TooltipLine tooltip = new(Mod, "InfinitePotions.InfiniteText", $"Infinite buff at {InfinitePotions.GetIConfig().InfinitePotionCount} stack")
                {
                    OverrideColor = new Microsoft.Xna.Framework.Color(44, 109, 230),
                };

                tooltips.Add(tooltip);
            }
        }
    }
}
