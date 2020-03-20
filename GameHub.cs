using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Game_of_Life
{
    public class GameHub : Hub
    {
        public async Task SendClick(int index, int red, int green, int blue)
        {
            if (index != 0)
            {
                Game.UpdateCell(index, red, green, blue);
            }
            await Clients.All.SendAsync("ReceiveBoard", Game.currentGameBoard);
        }
        
        public async Task Next()
        {
            Game.UpdateStatus();
            await Clients.All.SendAsync("ReceiveBoard", Game.currentGameBoard);
        }
    }
}