using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace InfinitePotions
{
    internal class InfinitePlayer : ModPlayer
    {
        private readonly HashSet<int> buffs = [];

        public override void PostUpdateBuffs()
        {
            Item[] items = [.. this.Player.bank.item
                .Concat(this.Player.bank2.item)
                .Concat(this.Player.inventory)
                .Where(b => b.buffType != 0)];

            foreach (var item in items)
            {
                if (item.buffType != 0 && item.stack >= InfinitePotions.GetIConfig().InfinitePotionCount)
                {
                    this.Player.AddBuff(item.buffType, 60 * 30);
                    buffs.Add(item.buffType);
                    Main.buffNoTimeDisplay[item.buffType] = true;
                }
            }

            foreach (var buff in buffs)
            {
                if (!items.Select(o => o.buffType).Contains(buff))
                {
                    this.Player.DelBuff(buff);
                    Main.buffNoTimeDisplay[buff] = false;
                }
            }
        }
    }
}
