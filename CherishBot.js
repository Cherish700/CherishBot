const Discord = require('discord.js');
const client = new Discord.Client();
const token = 'Mjk1NTcxMjM1OTUyMzk0MjQx.Drx9hw.9UO7lBPff5yUebLcR9DqKw22VaE';

client.on('ready', () => {
    console.log("I'm a horny little bot <3");
});

client.on('message', message => {
    if (message.content === 'Hello') message.reply('Hello horny little peeps ;)');
});

client.login(token).catch(err => console.log(err));
   

