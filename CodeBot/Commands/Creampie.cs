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
    public class Creampie : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
               "https://cdn.discordapp.com/attachments/271469081721438212/294955070477434881/tumblr_o9vqd8LnRK1vy9tiho2_500.gif",
                "https://cdn.discordapp.com/attachments/271469081721438212/290292949986705418/8a7eb2eaf587acc32b99b9cb7b6f9.gif",
                "http://simg4.gelbooru.com//images/59/e9/59e90dee9e1a4b4ba654faa1cab33c33.gif?1567603",
                "http://68.media.tumblr.com/37b20335963c9fd8541b0d7d72dfa472/tumblr_nneyu4nKqx1s0h0cio1_400.gif http://68.media.tumblr.com/94cef443bb45c1a3e7d426dce6c15b4b/tumblr_odwqs67hyl1vvb8iho1_500.gif",
                "http://simg4.gelbooru.com//images/43/b9/43b98d881e4ae3a9ba9b2657e7972c9b.gif?2555531",
                "http://gelbooru.com//images/31/88/31881710e52f57ffd4085b6004ca6941.jpeg?2736413",
                "http://68.media.tumblr.com/8a809b07e289141f7ce468671d82164a/tumblr_ocrzacozah1vzttmyo5_540.gif",
                "https://cdn.discordapp.com/attachments/271469081721438212/300436106460135424/tumblr_o2n7iih80L1v59icgo4_500.gif",
                "https://cdn.discordapp.com/attachments/271469081721438212/300437472888881152/8DZCyhf.gif",
        };

        [Command("Creampie")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} I'm going to fill you up! ♥ {image}");
        }
    }

}