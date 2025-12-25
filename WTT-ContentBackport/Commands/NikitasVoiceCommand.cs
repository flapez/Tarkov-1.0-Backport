using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.Callbacks;
using SPTarkov.Server.Core.Controllers;
using SPTarkov.Server.Core.Helpers;
using SPTarkov.Server.Core.Helpers.Dialog.Commando.SptCommands;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Eft.Dialog;
using SPTarkov.Server.Core.Models.Eft.Profile;
using SPTarkov.Server.Core.Models.Enums;
using SPTarkov.Server.Core.Models.Spt.Dialog;
using SPTarkov.Server.Core.Servers;
using SPTarkov.Server.Core.Services;
using WTTServerCommonLib.Helpers;

namespace WTTExampleMod.Commands;

[Injectable]
public class NikitasVoiceCommand(
    MailSendService mailSendService,
    RewardHelper rewardHelper,
    ProfileHelper profileHelper) : ISptCommand
{

    
    public ValueTask<string> PerformAction(UserDialogInfo commandHandler, MongoId sessionId, SendMessageRequest request)
    {

        
        var profile = profileHelper.GetFullProfile(sessionId);
        rewardHelper.AddAchievementToProfile(profile, "6948990c05f4f91bdb9a56f3");
        IEnumerable<MongoId> ruafVoices = new MongoId[]
        {
            "68a322944dc8ea81b603528f",
            "68a322c44dc8ea81b6035293",
        };
        profile.AddCustomisation("690d4eda458927196f0775f8", "voice");
        profile.AddCustomisation("690d4eef8cef6e31cb0d7b88", "voice");
        mailSendService.SendUserMessageToPlayer(sessionId, commandHandler, $"This REQUIRES a full game restart in order to use Nikita's Voice");
        return new ValueTask<string>(request.DialogId);
    }

    public string Command
    {
        get { return "nikitasvoice"; }
    }

    public string CommandHelp
    {
        get
        {
            return "Usage: Receive Nikita's Voice";
        }
    }
}