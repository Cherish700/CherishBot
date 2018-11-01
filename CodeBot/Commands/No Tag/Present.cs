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
    public class Present : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "https://gelbooru.com//samples/e7/68/sample_e76806c6c64a26eac9048478ad8907da.jpg",
                "https://cdn.discordapp.com/attachments/224173921094598664/297215918734573568/a6f4d2fdb1030b6dcef5d9c6496a7128.jpg",
                "http://68.media.tumblr.com/52d5c67e4227365de949a8d8ed033967/tumblr_oh81fsyOgC1v5d8lno1_1280.png",
        };

        [Command("Present")]
        public async Task CommandAsync()
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"P-Please put it in me, senpai...♥ {image}");
        }
    }

}