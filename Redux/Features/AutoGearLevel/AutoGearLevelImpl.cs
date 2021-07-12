
using Redux.Enum;
using Redux.Game_Server;
using Redux.Packets.Game;
using Redux.Structures;

namespace Redux.Features.AutoGearLevel
{
    class AutoGearLevelImpl : IAutoGearLevel
    {
        public void OnLevelUp(Player player)
        {
            AttemptUpgrade(player, ItemLocation.Helmet);
            AttemptUpgrade(player, ItemLocation.Necklace);
            AttemptUpgrade(player, ItemLocation.Ring);
            AttemptUpgrade(player, ItemLocation.WeaponR);
            AttemptUpgrade(player, ItemLocation.Armor);
            AttemptUpgrade(player, ItemLocation.WeaponL);
            AttemptUpgrade(player, ItemLocation.Boots);
        }

        private void AttemptUpgrade(Player player, ItemLocation location)
        {
            ConquerItem item = player.Equipment.GetItemBySlot(location);
            if (item != null && player.Level >= item.GetDBItemByStaticID(item.GetNextItemLevel()).LevelReq)
            {
                item.ChangeItemID(item.GetNextItemLevel());
                player.Send(ItemInformationPacket.Create(item, ItemInfoAction.Update));
            }
        }
    }
}
