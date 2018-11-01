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
    public class Ride : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "https://cdn.discordapp.com/attachments/271469081721438212/294955050051305472/tumblr_nti17aAbX61u3sqw6o1_500.gif",
                "http://simg4.gelbooru.com//images/59/e9/59e90dee9e1a4b4ba654faa1cab33c33.gif?1567603",
                "http://gelbooru.com//samples/93/7c/sample_937c300a99f23d9602f94a6fb24e0ca1.jpg?3494637",
                "http://gelbooru.com//samples/7a/a9/sample_7aa9a552adbbc8da30896d7213bef1f9.jpg?3012403",
                "https://cdn.discordapp.com/attachments/277010998886400010/295596398999765003/sample_33b359f686aa0892a1658b56e212404a.jpg",
                "https://cdn.discordapp.com/attachments/277010998886400010/295596559712911361/84594185e97dfc0d6255bc4ff3721424.png",
                "https://gelbooru.com//samples/76/e1/sample_76e14ea4e2e2468f12f43255336a3a69.jpg?2714697",
                "http://gelbooru.com//images/c1/29/c12948eaf1b3054611efa70bbafdcf76.gif?3432755",
                "https://images-ext-2.discordapp.net/.eJwNyL0KgzAUQOF3CThqfkzUuhXarVOXQpfLVW80EmNI41T67nU48HG-7Eie9WzJOfacp8NTrcsJM5ZCiiriQuirQJmD23CmD5eox3GYjJZCmcaiGpXWaEwrh3Y4L1eiuzSdLpQoz-6b8w5PPKmor_BwlsAFQLg5aylRyPDak5_Apn2DN6W9WuPMfn8p_jB8.-xGsBDsHvBdTXaZ8nlO_XRYWHM4?width=214&height=251",
                "http://68.media.tumblr.com/8e7bca6ff34b2c4989766bf3820514cb/tumblr_mnglkrHAks1s0sk8ho1_500.gif",
                "http://68.media.tumblr.com/3d54d8139481e48908efe81b2d5e921b/tumblr_mne9vmf43N1s0sk8ho1_400.gif",
                "http://68.media.tumblr.com/a6f67125214b6687d6b997d60a8c0ccd/tumblr_mndtbop4QG1s0sk8ho1_400.gif",
                "http://68.media.tumblr.com/8ff3db263ffa515b0ad10f80b9f3f621/tumblr_mndt0xFgKd1s0sk8ho1_400.gif",
                "https://68.media.tumblr.com/ff9b4fcc8f81d93de59fd23021c04c55/tumblr_o7rqa9KpOX1toy0ydo1_500.gif",
                "https://cdn.discordapp.com/attachments/224173921094598664/300303409788092417/4a45eeb9a6cfe7108faa4a500085054d.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0047.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0093.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0182.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0183.gif",
                "http://www.animated-gifs.eu/category_xxx/phone-640x480-hentai/0057.gif",
                "http://x.imagefapusercontent.com/u/TrickyLouse/3985842/21994963/e2552d09265a8597fb9ea85cf440b8a3.gif",
                "https://up8.xhcdn.com/000/120/918/663_1000.gif",
        };

        [Command("Ride")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} You're my favorite legendary mount..! {image}");
        }
    }

}