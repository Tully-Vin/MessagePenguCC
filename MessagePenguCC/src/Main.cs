using BepInEx;
using RoR2;

namespace MessagePenguCC;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]

public class Main : BaseUnityPlugin
{
    public const string PluginGUID = PluginAuthor + "." + PluginName;
    public const string PluginAuthor = "Tully_Vin";
    public const string PluginName = "MessagePenguCC";
    public const string PluginVersion = "0.0.1";

    public void Awake()
    {
    }
}