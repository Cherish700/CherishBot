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
    public class Choke : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://falara-unveiled.com/wp-content/gallery/angel-beats/11.jpg",
                "http://68.media.tumblr.com/c9a14f21b4ecd2f93a923ad2b42bd5ea/tumblr_ncw7rccbQQ1tokhouo1_500.gif",
                "http://falara-unveiled.com/wp-content/gallery/angel-beats/23.jpg",
                "http://gelbooru.com//samples/4a/cb/sample_4acb2ec79d4f0aa19819b18d443c4956.jpg?3157346",
                "http://gelbooru.com//samples/ec/d1/sample_ecd1037935a32f829130f9c2128ea06f.jpg?3178094",
                "http://simg4.gelbooru.com//samples/ed/f3/sample_edf330d8ffdcf93bfe15455821466e15.jpg?3266968",
                "http://gelbooru.com//samples/9a/f2/sample_9af23da6ab81d20977f5bb3e7738c59e.jpg?3089154",
        };

        [Command("Choke")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} You like it like this, you masochist slut..? {image}");
        }
    }

}