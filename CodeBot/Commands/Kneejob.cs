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
    public class Kneejob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "https://i.yuki.la/h/1456609087793.gif",
                "http://danbooru.donmai.us/data/__original_drawn_by_tata_artist__dc0ff628b5fdb6b37041cc1bcf6e42fa.jpg",
                "https://cdnio.luscious.net/404/lusciousnet_257fae863676c0ded2368ba_954707783.jpg",
                "https://simg4.gelbooru.com//samples/40/64/sample_40645a8e071b5bd3b105a9ff428b783f.jpg",
                "http://68.media.tumblr.com/5266ba98b2898479181ad60ef3b2e3c7/tumblr_nnlvcn7jgy1unfc16o1_1280.jpg"
        };

        [Command("Kneejob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} You like it in here? ♥ {image}");
        }
    }

}