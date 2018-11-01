using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBot
{
    public class Ahegao : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "https://simg4.gelbooru.com//images/3f/97/3f97119256174301e0d66f0a109fdd35.png",
                "https://i.gyazo.com/5447441b58b512616fb705da2b0c94c9.png",
                "http://68.media.tumblr.com/3009a2aa4578c117d1618479b9e0de32/tumblr_ocrzacozah1vzttmyo2_540.gif",
                "https://i.gyazo.com/f57716b07e57c208eb223b447765c2d8.png",
                "https://cdn.discordapp.com/attachments/298695839910461442/298922130433900545/a790003af339a869c16.jpg",
                "http://gelbooru.com//images/ed/3d/ed3d8c74058a8414cb91ce1c3c2fa29a.jpeg?2231425",
        };

        [Command("Ahegao")]
        public async Task CommandAsync()
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"KIMOCHIIIII...♥ {image}");
        }
    }

}