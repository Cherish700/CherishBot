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
    public class Boobjob : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://simg4.gelbooru.com//samples/3e/dc/sample_3edcf7fe5db05cebe7d240365da7f837.jpg?2538613",
                "https://cdn.discordapp.com/attachments/277010998886400010/295597336275451914/scaled_full_b4fa44e764b5bae481d1.jpg",
                "https://cdn.discordapp.com/attachments/277010998886400010/295598731389042688/0673747f3fb8dc54733ed019e8bb77dd.jpg",
                "http://68.media.tumblr.com/a6d0b780be1dac1425de625962ad103c/tumblr_np7p3pe1dH1uw4m7uo1_250.png",
                "http://simg4.gelbooru.com//images/0b/db/0bdb4207cfbfa7766ff6e9f47b6177ab.gif?3387692",
                "https://cdn.discordapp.com/attachments/224173921094598664/297216034874851328/a586948adebbfa47ecf5d6afde51e3d4.jpg",
                "https://68.media.tumblr.com/e235362ff6d120e418edd6d428c0642b/tumblr_msbvqbAb181ss99fto1_400.gif",
                "http://gelbooru.com//samples/2d/70/sample_2d70b5c08f435047270bec9e6f081fc6.jpg?2714669",
                "http://x.imagefapusercontent.com/u/TrickyLouse/3985842/255691207/7d137abe675c3d22606df978c3f3c3df.gif",
                "http://x.imagefapusercontent.com/u/TrickyLouse/3985842/1990687614/photo-Big-Tits-Hentai-139965485.gif",
        };

        [Command("Boobjob")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Do my breasts feel good? ♥ {image}");
        }
    }

}