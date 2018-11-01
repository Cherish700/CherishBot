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
    public class Feet : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://gelbooru.com//samples/24/31/sample_2431bc98fe10e9a5c0c58eb4d2b85791.jpg?2660159",
                "http://gelbooru.com//samples/35/e8/sample_35e837fb892db646b28ee3c56615ed59.jpg?3135382",
                "https://cdn.discordapp.com/attachments/294945693812916224/296038939394048001/62779b6b6659ace111bd2aa04a3dd324.jpg",
                "http://gelbooru.com//samples/ab/5d/sample_ab5d5542c7150ea7280aed0e0c20664b.jpg?3044573",
                "http://68.media.tumblr.com/7bd3f6442fc1889c65a7e2a73127ea5c/tumblr_ojxfa0s3aX1uy4ukeo1_1280.jpg",
        };

        [Command("Feet")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Worship and lick my feet like a good boy~ ♥ {image}");
        }
    }

}   