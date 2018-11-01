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
    public class Handjob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//images/38/f4/38f499202dc94bf78a53b2b83c6e60c4.gif?3340166",
                "https://cdn.discordapp.com/attachments/232026978910208000/265838051517923328/some-handjob.gif",
                "http://gelbooru.com//samples/f6/bb/sample_f6bb970a795564acc2abd7003733a600.jpg?650754",
                "https://cdn.discordapp.com/attachments/224173921094598664/296022068804321280/e8ca12a89dc51c20fc7cc12113dcfa52.gif",
                "https://68.media.tumblr.com/29676c9af78c9ce6dbe7011152f508f1/tumblr_o6qboqk1IJ1tjgwy0o1_540.gif",
        };

        [Command("Handjob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Do you like it when I stroke it like this..? ♥ {image}");
        }
    }

}