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
    public class Fuck : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://66.media.tumblr.com/c07b0b6a3a9003a6b229bb32be27b92f/tumblr_oa8c56T3Yx1u3ma4bo1_500.gif",
                "http://gelbooru.com//images/d1/65/d165e4432ccd95c83c57899f760db1c1.gif?3348050",
                "http://gelbooru.com//images/4c/02/4c02f929a75607e091306edc34ffed19.gif?3244891",
                "https://cdn.discordapp.com/attachments/232026978910208000/265837765634162706/some-fuck-2.gif",
                "http://gelbooru.com//images/2c/73/2c73e6812d38a5b34300552eea926f6f.jpeg?3352441",
                "http://gelbooru.com//images/24/a5/24a5d00501bfe8246b92ab093e73c779.gif?391537",
                "http://gelbooru.com//images/80/df/80df59c6d8c35b2fed9ff3cfce2592bf.gif?3315319",
                "http://68.media.tumblr.com/c5cb2defebe32381b303c6f0dce0e29c/tumblr_n8dtt4GFIY1s0sk8ho1_540.gif",
                "http://68.media.tumblr.com/843c33a366588923c014aed1b76337ca/tumblr_mm5h8sgGdC1s0sk8ho1_r1_1280.gif",
                "http://68.media.tumblr.com/00bb0ffdfd8a74667a6ae81ff733de56/tumblr_mvopuqTui01s0sk8ho1_1280.gif",
                "http://68.media.tumblr.com/3ed68c79498d1f3525273e3a8e7bf3e1/tumblr_mvoo5ogA1R1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/ee7d080b9320247cebd7c3ccca2f14ac/tumblr_mne3erOsh01s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/dd9725d3a64c7423fe43ce2e14ff717c/tumblr_mndsw6CvOC1s0sk8ho1_500.gif",
                "https://68.media.tumblr.com/be8b3872ce868ddf61d441900bfa5d9d/tumblr_o7j3uoTDre1vr1ctao1_500.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0025.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0086.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0105.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0118.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0196.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0201.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0056.gif",
                "http://x.imagefapusercontent.com/u/TrickyLouse/3985842/133744856/tumblr_mckz8pj9q41rfusuoo1_1280.gif",
                "http://x.imagefapusercontent.com/u/TrickyLouse/3985842/285493354/uncensored-hentai-gif-sex-doggy-style.gif",
                "https://cdn.discordapp.com/attachments/271469081721438212/300435854369751050/3608626.gif",
        };

        [Command("Fuck")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Feels good, doesn't it? {image}");
        }
    }

}