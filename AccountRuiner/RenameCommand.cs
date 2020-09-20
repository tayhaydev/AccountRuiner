using Discord;
using Discord.Gateway;
using Discord.Commands;

namespace Accountruiner
{
    public partial class Form1
    {
        [Command("rename")]
        public class RenameCommand : ICommand
        {
            [Parameter("channel")]
            public MinimalTextChannel Channel { get; private set; }


            [Parameter("new name")]
            public string NewName { get; private set; }

            public void Execute(DiscordSocketClient client, DiscordMessage message)
            {
                if (message.Guild != null)
                {
                    if (message.Author.Member.GetPermissions().HasFlag(DiscordPermission.ManageChannels))
                    {
                        try
                        {
                            client.GetChannel(Channel.Id).ToGuildChannel().Modify(new GuildChannelProperties() { Name = NewName });

                            message.Channel.SendMessage($"Success! channel has been renamed to \"{NewName}\"");
                        }
                        catch (DiscordHttpException ex)
                        {
                            if (ex.Code == DiscordError.UnknownChannel)
                                message.Channel.SendMessage("Unknown channel.");
                            else
                                message.Channel.SendMessage("An error has occured.");
                        }
                    }
                    else
                        message.Channel.SendMessage("Missing permissions.");
                }
            }
        }

    }
}