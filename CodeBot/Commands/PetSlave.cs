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
    public class Petslave : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
             "http://nood.megabooru.com/_images/a7b03c3293f0f9209f686b813a9f86a7/190959%20-%20all_fours%20animal_ears%20aqua_eyes%20aqua_hair%20ass%20bad_id%20blush%20butt_plug%20butt_plug_tail%20cat_ears%20censored%20eto%20hatsune_miku%20leash%20long_hair%20looking_back%20nude%20solo%20tail%20thighhighs%20twintails%20very_long_hair%20vocaloid.jpg",
                "http://gelbooru.com//images/f1/ba/f1ba80b35d15c50357e33ddae78bf437.png?3397333",
                "http://68.media.tumblr.com/e6ef9401a0d61f727412c1b491b49ee4/tumblr_o6aoe4OyjE1vqrhexo3_1280.jpg",
                "http://gelbooru.com//samples/7d/e9/sample_7de9b28b0860f9d16fd2f4a6ddb87d6d.jpg?3369282",
                "https://s-media-cache-ak0.pinimg.com/236x/94/a5/8b/94a58bc5608be6e50feac07794847246.jpg",
        };

        [Command("Petslave")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Who's a cute little kitty? ♥ {image}");
        }
    }

}