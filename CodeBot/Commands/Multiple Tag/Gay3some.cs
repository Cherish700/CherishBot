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
    public class Gay3some : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "http://68.media.tumblr.com/0aba9574b4f8edbf3f11a87a6310de4a/tumblr_nygbrexhvO1t0bnt8o1_500.gif",
                "https://gelbooru.com//images/54/22/5422c3999e10ea44dee83ed04548e33d.jpeg",
                "http://hotcomics.3dgayart.com/gay-toons-gmoh/ancy-hentai-gay-porn_23456.jpg",
                "http://x.imagefapusercontent.com/u/Rotom/5940562/1208390000/mp.jpg",
        };

        [Command("Gay3some")]
        public async Task CommandAsync(SocketGuildUser user, SocketGuildUser user2, SocketGuildUser user3)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention},{user2.Mention},{user3.Mention} It's even more fun with three! {image}");
        }
    }

}