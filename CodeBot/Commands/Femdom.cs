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
    public class Femdom : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://68.media.tumblr.com/a2222b77c50bce3ba771dd4cd5691fa2/tumblr_ngbg5seBz61soj73yo1_400.gif",
                "https://cumonmy.com/galleries/2015-updates/01-002-Porn-Update-2700-Pics/Hentai/foot-job-femdom/Hentai-Footjob-socks-upskirt-Femdom-Porn-027.jpg",
                "https://simg4.gelbooru.com//images/2a/b5/2ab5e077af2361170ed16e23c3d4fd1c.jpeg",
                "https://gelbooru.com//images/6a/57/6a576d17776cce5975d345e7cebab604.jpeg",
                "https://simg4.gelbooru.com//images/bb/ad/bbada3be421a00a07454900f22c47805.jpeg",
                "http://66.media.tumblr.com/8f81aefab15f2c42c307acf7d9d4530e/tumblr_nrvz93iZkK1urv7ulo1_1280.gif",
                "http://68.media.tumblr.com/f66a81d3a312eb9f7471200602a0c688/tumblr_ng0b42HJZg1soj73yo1_400.jpg",
        };

        [Command("Femdom")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} Be a good boy and obey ♥ {image}");
        }
    }

}