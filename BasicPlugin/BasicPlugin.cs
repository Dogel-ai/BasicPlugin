using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

public class BasicPlugin : Plugin<Config> {
	public EventHandlers EventHandler;

	public override string Name => "Basic Plugin";
	public override string Author => "Dogel";
	public override Version Version => new Version(1,0,0);

	public override void OnEnabled() {
		try {
			EventHandler = new EventHandlers();
			Player.Joined += EventHandler.PlayerJoined;
		}
		catch (Exception arg) {
			Log.Error($"Loading error: {arg}");
			if(ImADumbass)
		}
	}
	public override void OnDisabled() {
		Player.Joined -= EventHandler.PlayerJoined;
		EventHandler = null;
	}
}
