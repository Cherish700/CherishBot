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
    public class Footjob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://66.media.tumblr.com/1215ad859f17e00de7eeb34be9cfeb01/tumblr_npb25ucltL1tc3w7go1_500.gif ",
                "http://gelbooru.com//images/64/18/6418ea739d61d8631055aaf1c05d3abe.png?2360134",
                "http://simg4.gelbooru.com//images/4a/4b/4a4b786b9da3686f6c5158478d1c7a02.gif?2821923",
                "https://cdn.discordapp.com/attachments/277010998886400010/295595995419377665/d315de52fdb3317cb7c0745a08f0ea9e6e34fbba.jpg",
                "https://cdn.discordapp.com/attachments/277010998886400010/295596105897476096/boner92929.jpg",
                "https://cdn.discordapp.com/attachments/277010998886400010/295596161421672448/0c1b7969bdba24ffc37c8a84413699b8.png",
                "http://gelbooru.com//samples/67/2e/sample_672e6bd606a537f8a81eaafedb3964ae.jpg?2530069",
                "http://gelbooru.com//images/77/55/7755634ec798460d322a2142619c0890.gif?3340102",
                "https://cdn.discordapp.com/attachments/294945693812916224/296380439193583617/FootJob.jpg",
                "https://gfycat.com/AgonizingAmusingBoubou",
        };

        [Command("Footjob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Only a pervert like you would enjoy something like this~ ♥ {image}");
        }
    }

}