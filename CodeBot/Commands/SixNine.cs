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
    public class SixNine : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//samples/b6/8e/sample_b68e8fb0635dfc9367177f562f12ed75.jpg?3396867",
                "https://gelbooru.com//samples/a9/c5/sample_a9c5fa7659a64d9ebf993a1bae90091b.jpg",
                "http://eclecticaerotica.com/wp-content/uploads/2009/09/anime-69.jpg",
                "http://i.imgur.com/XO8wMbq.jpg",
                "http://static.hentai-image.com/upload/20150103/17/16397/p=700/1.jpg",
                "http://68.media.tumblr.com/0dc7f5f10e011f970ca780b19637793c/tumblr_mndshjC4F71s0sk8ho1_400.gif",
                "https://assets.gelbooru.com/samples/d1/90/sample_d1901a1c30ef674b42aec0d4bbdae488.jpg",
                "https://assets.gelbooru.com//images/fc/e7/fce761fd3a4bbbec9cd03d124a2b7024.jpg",
                "https://assets.gelbooru.com/samples/8d/b1/sample_8db16df5911222a101bb1c9823895f1f.jpg",
                "http://gelbooru.com//samples/51/f3/sample_51f3354e1f783237edf787a419b8bfbe.jpg?3386882",
        };

        [Command("SixtyNine")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} :open_mouth: + :stuck_out_tongue: {image}");
        }
    }

}