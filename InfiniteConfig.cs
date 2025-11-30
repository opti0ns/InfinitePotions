
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace InfinitePotions
{
    internal class InfiniteConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [LabelKey("$Mods.InfinitePotions.Config.InfinitePotionCount")]
        [TooltipKey("$Mods.InfinitePotions.Config.InfinitePotionCount.Description")]
        [DefaultValue(30)]
        public int InfinitePotionCount;

    }
}
