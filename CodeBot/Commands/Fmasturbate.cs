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
    public class FMasturbate : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//images/6a/f3/6af378947ef99df17c222be55639bbdf.gif?3315308",
                "https://gfycat.com/DisfiguredConcreteEchidna",
                "http://pictures.hentai-foundry.com/e/emperpep/249060/emperpep-249060-Stilva__masturbate.jpg",
                "https://gfycat.com/ElectricSolidAtlanticspadefish",
                "http://gelbooru.com//images/87/6a/876a948229d15d1872be498429b4e399.gif?3440470",
                "http://68.media.tumblr.com/5934d5f328c1e31175582f51e51b2072/tumblr_n34zw3n6Df1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/e1f90292ed4391b67f101a130e0094bd/tumblr_n1n5qoAbkz1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/ef0e9de0a011282f951671c421d4af8c/tumblr_mnfyvgkNDi1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/31ff51a3762bf14459578d9e7034dfb4/tumblr_mnq58tIEi71s0sk8ho1_1280.gif",
                "https://68.media.tumblr.com/224a43c2286793337d2a9d7d65d196de/tumblr_o6mx2wyPoR1tjgwy0o1_540.gif",
                "http://68.media.tumblr.com/ea5583bc52c2332199b4782f44b4d4c1/tumblr_mm4mhtf4Dc1soj73yo1_400.jpg",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0017.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0037.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0072.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0108.gif",
        };

        [Command("Fmasturbate")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} I can't... help it... ♥ {image}");
        }
    }

}