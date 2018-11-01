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
    public class StraponMale : ModuleBase<SocketCommandContext>
    {
        private static string[] _imagePaths = new[]
        {
              "http://hentaifemdom.net/wp-content/uploads/2016/03/original_124474051.jpg",
                "https://cdn.discordapp.com/attachments/294945693812916224/296660853875408897/StrapOn.jpg",
                "http://68.media.tumblr.com/dc166db706ef33e859bae288f51faa2a/tumblr_nm3m8zXmyR1uo2syjo1_400.gif",
                "http://68.media.tumblr.com/cab9fcc2ae88fc25e97d246afc18b0a1/tumblr_ng09ihKq2V1tmblnjo1_500.jpg",
                "https://s-media-cache-ak0.pinimg.com/564x/04/5f/32/045f32992a7736ba5073aa61f9d9e630.jpg",
                "http://carmenicadiaz.net/zen/albums/january2014/2501fd14_censored.jpg",
                "http://femdomxhentai.com/pics/150Hot_babe_with_strapon_hentai_footage.jpg",
                "http://66.media.tumblr.com/8f81aefab15f2c42c307acf7d9d4530e/tumblr_nrvz93iZkK1urv7ulo1_1280.gif",
        };

        [Command("StraponMale")]
        public async Task CommandAsync(SocketGuildUser user)
        {
            // using a new instance of the Random class we randomize a path with an index from 0 to x - 1, where x is the amount of paths in the array 
            var image = _imagePaths[new Random().Next(_imagePaths.Length)];

            // we send the image
            await ReplyAsync($"{user.Mention} How do you like this fake dick huh, you fucking masochist boy. {image}");
        }
    }

}