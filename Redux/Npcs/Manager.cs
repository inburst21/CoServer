using System;
using Redux.Game_Server;

namespace Redux.Npcs
{
    public static class Manager
    {
        public static void ProcessNpc(Player _client, uint _npc, ushort _linkback)
        {
            try
            {
                var type = Type.GetType("Redux.Npcs.NPC_" + _npc);
                INpc npc = Activator.CreateInstance(type,_client) as INpc;

                if (!_client.VisibleObjects.ContainsKey(_npc) && !npc.IsGlobal)
                { Console.WriteLine("{0} trying to use non global npc {1} while not on screen!", _client.Name, _npc); return; }
                npc.Run(_client, _linkback);
                _client.CurrentNPC = npc;
            }
            catch (Exception p){ _client.SendMessage("Could not load npc script for npc ID: " + _npc); }
        }
    }
}
