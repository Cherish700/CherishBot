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
    public class Cunnilingus : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "http://gelbooru.com//images/7f/a3/7fa39b9011b8594ba832c74282b690d5.png?3416115",
                "http://mhentai.net/wp-content/uploads/2010/07/Haruhi-Suzumiya-Cunnilingus.jpg",
                "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTRrqo14pbmDkEnNNVzTqKPVak2S_itD6Q8dChITI0-mwD_m7g25Q",
                "http://68.media.tumblr.com/4c5aa696bbf791fe35561fe07233c9d5/tumblr_n1n5o9RuSz1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/a5971e56f4093c784f337ac042aaf6b9/tumblr_mnahgs9K951s0sk8ho1_1280.gif",
                "https://gfycat.com/gifs/detail/kindheartedgranularcrane",
                "https://gfycat.com/gifs/detail/shinymisguidedfugu",
        };

        [Command("Cunnilingus")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} *Licks*♥ {image}");
        }
    }

}