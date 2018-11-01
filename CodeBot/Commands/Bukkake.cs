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
    public class Bukkake : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
                "https://cdn.discordapp.com/attachments/271131227652751361/295710623692750848/pic-3-white-carnival-an-hentai-gallery-filled-with-bukkake-pictures-lt-407876.jpg",
                "https://cdn.discordapp.com/attachments/271131227652751361/295721648487661568/Bukkake2.jpg",
                "https://cdn.discordapp.com/attachments/294945693812916224/296379506858655755/Bukkake.jpg",
                "http://gelbooru.com//images/1e/03/1e03523298848a3b5c4819c96c5cee3d.jpg?3423306",
                "http://gelbooru.com//samples/53/2b/sample_532b102c0610865758954e7c5ebf721b.jpg?3198598",
                "https://68.media.tumblr.com/510003e41a1e3b8fd5485e9a105b0484/tumblr_o8l8mfNvUB1vs7mk8o4_400.gif",
                "https://cdn.discordapp.com/attachments/224173921094598664/300304603512045570/0d594c249756503db42e387b4a316e11.jpeg",
                "http://x.imagefapusercontent.com/u/Moewe/4063225/2045886240/Hen_CS_(17).jpg",
                "http://x.imagefapusercontent.com/u/Silcoon/6319407/1547233913/Hentai_bukkake_16_guishen_0028ymev085.jpg",
                "http://x.imagefapusercontent.com/u/Silcoon/3207397/2080297600/Ho_rino2.jpg",
                "http://x.imagefapusercontent.com/u/Silcoon/3514659/1633437544/2gou_sxen.jpg",
                "http://simg4.gelbooru.com//images/76/00/7600a19e9b415dcb2698af56aa6cf481.jpeg?3295687",
        };

        [Command("Bukkake")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} :notes: Pomf Pomf Kimochi, What's This Sticky Stuff on Me? :notes: {image}");
        }
    }

}