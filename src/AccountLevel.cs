using AmongUs.Data;

namespace AUnlocker;
public static class AccountLevel
{
    public static uint parsedLevel;

    public static void spoofLevel()
    {
        // Parse AccountLevel config entry and turn it into a uint
        if (!string.IsNullOrEmpty(AUnlocker.AccountLevel.Value) && 
            uint.TryParse(AUnlocker.AccountLevel.Value, out parsedLevel) &&
            parsedLevel != DataManager.Player.Stats.Level)
        {

            // Temporarily save the spoofed level using DataManager
            DataManager.Player.stats.level = parsedLevel - 1;
            DataManager.Player.Save();
        }
    }
}
