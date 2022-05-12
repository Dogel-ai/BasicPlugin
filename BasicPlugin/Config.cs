using Exiled.API.Interfaces;
using System.ComponentModel;

public class Config : IConfig {
	[Description("Whether or not the plugin is enabled.")]
	public bool IsEnabled { get; set; } = true;

	[Description("Whether or not Do Not Track related messages should be shown")]
	public bool DoNotTrackBroadcast { get; set; } = false;
	[Description("Message players would receive if they have the \"Do Not Track option\" turned on")]
	public string TrackMessage { get; set; } = "Example DNT Message";

	[Description("Whether or not welcome messages should be shown")]
	public bool WelcomeBroadcast { get; set; } = false;
	[Description("Message players would receive upon joining")]
	public string WelcomeMessage { get; set; } = "Example Welcome Message";

	[Description("Whether players should get their nicknames set to a number. E.g (prefix)2137")]
	public bool NicknameToNumber { get; set; } = false;
	[Description("The number prefix that will be shown as their nickname. E.g D-(number)")]
	public string NumberPrefix { get; set; } = "D-";
}