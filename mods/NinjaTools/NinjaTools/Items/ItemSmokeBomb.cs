using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Vintage Story Includes
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;

namespace NinjaTools.Items
{
    internal class ItemSmokeBomb : Item
    {
        public override void OnAttackingWith(IWorldAccessor world, Entity byEntity, Entity attackedEntity, ItemSlot itemslot)
        {
            //  Super
            base.OnAttackingWith(world, byEntity, attackedEntity, itemslot);
        }
    }
}
