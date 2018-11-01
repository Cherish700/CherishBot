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
    public class Cumshot : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "https://gelbooru.com//images/d5/ad/d5ad2d11a18333f17888e14a7e0063fb.gif?3390864",
                "https://gelbooru.com//images/dc/ca/dccaa3e33f0781eb1b5b514231680cb7.jpeg",
                "http://68.media.tumblr.com/330db0def21830d73c86be5f6f11f86a/tumblr_nog24vQH5M1tfkuabo1_500.gif",
                "http://gelbooru.com//images/6c/87/6c872ab2661d820de7f3b2a38e7b4a8d.jpg?664259",
                "http://simg4.gelbooru.com//images/f7/4b/f74b853f338736be36e0d99220b73553.jpeg?3402194",
                "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQkxLhP03PMI0NvTh7f92To7bEvGMPDURvUlphnhxtvv4qaP5VN",
                "https://68.media.tumblr.com/cd8d86831dd3e9cfa342fbbb1310b730/tumblr_ob5iyhGlMl1vy09pso1_500.gif",
                "https://68.media.tumblr.com/a48fa5e3f4fe2297c75bb9431aaf182d/tumblr_o8l8mfNvUB1vs7mk8o3_500.gif",
                "https://68.media.tumblr.com/0e86bce73effe8ac5d604022285abcf6/tumblr_o7zrlyDi8O1vr1ctao1_400.gif",
                "https://68.media.tumblr.com/91be67745341628a176e1ba40cd17068/tumblr_o59bemPjlm1v8szqxo1_500.gif",
                "http://gelbooru.com//samples/b6/be/sample_b6bed4441ac90e06e53de142025d977f.jpg?2981818",
                "http://x.imagefapusercontent.com/u/skylarks25/6786225/1372584161/Shakugan_no_Shana_00992146af97f04e7312649c8cae28ee24534a44.jpg",
        };

        [Command("Cumshot")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Ahhhn~ Cumming Feels Great ~ ♥{image}");
        }
    }

}