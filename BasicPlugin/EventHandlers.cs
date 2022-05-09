using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

public class EventHandlers : Plugin<Config> {
	private Random rnd = new Random();
	public void PlayerJoined(JoinedEventArgs ev) {
		if(ev.Player.IsConnected) {
			ev.Player.Broadcast(5, $"<color=yellow>Witaj</color> w Watkanie {ev.Player.Nickname}!/nYour current ping is {ev.Player.Ping}ms");
			ev.Player.DisplayNickname = $"D-{rnd.Next(1, 7000)}";

			if(ev.Player.DoNotTrack) {
				ev.Player.Broadcast(10, Config.TrackMessage);
			}
		}
	}
}
