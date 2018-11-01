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
    public class Futa : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//images/c0/d3/c0d3654a198bf64e2566c914e9bc495a.gif?2473398",
                "https://gelbooru.com//images/c6/bb/c6bbbbe3c8a83d3b0c94c71aec3b3307.png",
                "https://68.media.tumblr.com/866fae1157e95058bd4fa6503ed58386/tumblr_nt1qg9ulZr1tzjoauo1_1280.gif",
                "https://68.media.tumblr.com/82e1d577eaed6578085ed92b291c5bac/tumblr_nx5kwsGrrr1ukvp97o1_r1_400.gif",
                "https://68.media.tumblr.com/4be9b0235badf28e3f8eed17767f3203/tumblr_ohaurkM0Xh1v2hfg0o1_500.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0198.gif",
                "http://x.imagefapusercontent.com/u/ron2007/3681967/2055072975/03_12.gif",
        };

        [Command("Futa")]
        public async Task CommandAsync()
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"The dick only makes it better. {image}");
        }
    }

}