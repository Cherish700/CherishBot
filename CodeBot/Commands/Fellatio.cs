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
    public class Fellatio : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "http://gelbooru.com//images/68/d7/68d74eb7551ca008ce033911a9dc2208.png?3204431",
                "http://gelbooru.com//samples/44/a9/sample_44a92a5abbae84023971effef27dbdfe.jpg?3188017",
                "http://gelbooru.com//samples/02/1a/sample_021a49e15860c61d96b6333dc4af02e0.jpg?2406972",
                "https://gelbooru.com//images/2d/32/2d32641a05ebc533eed7129c81eb2f6b.jpg?954336",
                "http://gelbooru.com//images/0f/ee/0feec8f5e3f5947806520305ecea0a0e.gif?3383319",
                "http://gelbooru.com//samples/70/15/sample_7015c50e6ba5e62124dac4a0f05be0b2.jpg?2965085",
                "http://gelbooru.com//images/7a/79/7a790df63ad2fda1621ab2bda4b6f0aa.gif?1567599",
                "https://cdn.discordapp.com/attachments/285534446411710464/289047915064983552/sexy-blowjob.gif",
                "http://rule34-data-002.paheal.net/_images/0e4756338248b986603151dbedef3dd9/2063414%20-%20Dead_or_Alive%20Nyotengu%20animated%20fluffy_pokemon%20source_filmmaker.gif",
                "http://68.media.tumblr.com/04030ed044e51ea6f2d2ff80c2e99204/tumblr_n504z0GNtr1s0sk8ho1_400.gif",
                "http://68.media.tumblr.com/7db42733ee0e5fa51ed63576396e5628/tumblr_mndsil6ntB1s0sk8ho1_1280.gif",
                "https://68.media.tumblr.com/c13c262e26cd9f6f2c5d0c40f446c664/tumblr_o4xkndjuiR1si5p72o1_500.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0008.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0009.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0033.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0059.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0094.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0142.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0143.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0185.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0199.gif",
                "http://x.imagefapusercontent.com/u/TrickyLouse/3985842/754781524/Uehara-Ami-Love-Selection-Hentai-GIF.gif",
        };

        [Command("Fellatio")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Mmmmfff... It tastes... sho good... slurp~♥ {image}");
        }
    }

}