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
    public class Gangbang : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "http://simg4.gelbooru.com//samples/3d/9f/sample_3d9fcf66440c8c78ac2b5cb51b25878c.jpg?1327930",
                "http://img-hw.xvideos.com/videos/profiles/galleries/a1/a3/ed/yinu/gal320786/pic_6_big.jpg",
                "https://simg4.gelbooru.com//images/6f/de/6fde6d3c03ea785886517ddc60adf7eb.gif",
                "https://68.media.tumblr.com/2fdb0bf8065d7f28ffba887866bbb08f/tumblr_o1n48oHkCC1tlb937o1_1280.gif",
                "http://x.imagefapusercontent.com/u/Silcoon/6319407/1547233913/Hentai_bukkake_16_guishen_0028ymev085.jpg",
        };

        [Command("Gangbang")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} How does it feel to be surrounded by so many? {image}");
        }
    }

}