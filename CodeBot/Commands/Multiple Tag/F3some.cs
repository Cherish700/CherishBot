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
    public class F3some : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "https://gelbooru.com//samples/25/95/sample_25958a7681ef0f02bc8a4ae6a7de4ba6.jpg",
                "https://cdnio.luscious.net/FullMetalPervert/277942/hentai-small-album-of-some-threesome-harem_01B633Q2E2CYQP6XX7C4M77H8C.jpg",
                "http://rule34-data-010.paheal.net/_images/24459dcbf44932bc756b87c7cde946bb/1814436%20-%20Strea%20Sword_Art_Online%20philia.jpg",
                "https://gelbooru.com//images/f5/07/f5075476232fa69e3a70567bdfb3441f.gif",
                "http://www.teenmpegs.com/images/videos/0114/245766/main.jpg",
                "http://soft-hentai.com/images/hentai/p23/_Hentai%20Picture%20-%20Threesome.jpg",
                "https://cdn.discordapp.com/attachments/224173921094598664/300304800124370944/bc4295d40607a40bf3f3380cd33a0023.jpeg",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0018.gif",
        };

        [Command("F3some")]
        public async Task CommandAsync(SocketGuildUser user, SocketGuildUser user2, SocketGuildUser user3)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention},{user2.Mention},{user3.Mention} It's even more fun with three!~ ♥ {image}");
        }
    }

}