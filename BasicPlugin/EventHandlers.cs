using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

public class EventHandlers : Plugin<Config> {
	private Random rnd = new Random();
	public void OnVerified(VerifiedEventArgs ev) {
		if(ev.Player.DoNotTrack) { ev.Player.Broadcast(10, $"Config.TrackMessage", Config.DoNotTrackBroadcast, Broadcast.BroadcastFlags.Normal); }
		if(Config.NicknameToNumber) { ev.Player.DisplayNickname = $"{Config.NumberPrefix}{rnd.Next(1, 7000)}"; }
		ev.Player.Broadcast(5, $"Config.WelcomeMessage", Config.WelcomeBroadcast, Broadcast.BroadcastFlags.Normal);
	}
}
