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
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("Help")]
        public async Task CommandAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("No Tags", "Ahegao, Futa, Tentacles, Present");
            builder.AddField("Single Tag [*Command @User]", "Anal, \nBondage, Boobjob, Bukkake, \nChoke, Creampie, Cumshot, Cunnilingus, \nDrip, \nFacesit, Feet, Fellatio, Finger, Femdom, Fist, Fmasturbate, Footjob, Fuck, \nGangbang, Grope, \nHandjob, Harem, \nKneejob, \nLesOrgy, Lick, \nNTR, \nOrgy, \nPetSlave, Pussyjob, \nRide, \nSixNine, Strapon, StraponMale, \nTeaseHer, TeaseHim, Thighjob, \nYaoi, Yuri");
            builder.AddField("Triple Tag [*Command @User @User @User]", "F3Some, M3Some, Gay3Some, Les3Some");

            await ReplyAsync("", false, builder.Build());
        }
    }

}