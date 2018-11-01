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
    public class Tentacles : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//samples/6f/e3/sample_6fe3f827087067a76fd6cc2f1138c402.jpg?3344867",
                "http://gelbooru.com//images/45/e0/45e09bda446b272a8edb0affc5d1ad70.jpg?427279",
                "https://simg4.gelbooru.com//samples/11/fb/sample_11fb75e0389e45859a85eb75baa852c3.jpg",
                "http://gelbooru.com//images/29/0a/290aae6fa0091fb698e528af90a3d3ce.jpeg?3393446",
                "http://68.media.tumblr.com/f0da33c6c980cf3fff3eb051ada49d19/tumblr_n7f4uffkuB1s0sk8ho1_500.gif",
                "https://68.media.tumblr.com/02034f9d9e6028955ec1d3f5653c6e40/tumblr_o0xnh2Z3xf1rsv6t3o3_r1_540.gif",
                "http://x.imagefapusercontent.com/u/Pingasforce/6091591/518916840/05a0a14a803c382b68331a185bf513e5b3ef3924.jpg",
        };

        [Command("Tentacles")]
        public async Task CommandAsync()
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"I've seen enough hentai to know where this is going... {image}");
        }
    }

}