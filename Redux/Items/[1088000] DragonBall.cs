using Redux.Game_Server;
using Redux.Structures;

namespace Redux.Items
{
    /// <summary>
    /// Handles item usage for [1088000] MeteorScroll
    /// </summary>
    public class Item_1088000 : IItem
    {
        public override void Run(Player _client, ConquerItem _item)
        {
            if (!_client.HasItem(Constants.DRAGONBALL_ID, 10))
                return;

            for (var i = 0; i < 10; i++)
                _client.DeleteItem(Constants.DRAGONBALL_ID);
            _client.CreateItem(Constants.DB_SCROLL_ID);
        }
    }
}
