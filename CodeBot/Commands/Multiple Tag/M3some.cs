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
    public class M3some : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "http://gelbooru.com//images/50/77/5077eeb12d92d9a6f5b4a110bebe2435.gif?2618294",
                "https://s-media-cache-ak0.pinimg.com/736x/9f/f6/c4/9ff6c482b2923c349b5c1edb5f231b7a.jpg",
                "http://rss.seriousarea.com/hentaipicsworld_rssimgs/0213picsv_lpe_p.jpg",
                "https://gfycat.com/InfiniteFeistyFlounder",
        };

        [Command("M3some")]
        public async Task CommandAsync(SocketGuildUser user, SocketGuildUser user2, SocketGuildUser user3)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention},{user2.Mention},{user3.Mention} It's even more fun with three! {image}");
        }
    }

}