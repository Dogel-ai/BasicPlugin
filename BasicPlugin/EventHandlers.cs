using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using dumbass;

public class EventHandlers : Plugin<Config> {
	private Random rnd = new Random();
	public void PlayerJoined(JoinedEventArgs ev) {
		if(ev.Player.IsConnected == true) {
			ev.Player.Broadcast(5, $"Witaj w <color=yellow>Watkanie</color> {ev.Player.Nickname}!");
			ev.Player.DisplayNickname = $"Dumbass nr.{rnd.Next(1, 7000)}";

			if(ev.Player.DoNotTrack == true) {
				ev.Player.Broadcast(10, Config.TrackMessage);
			}
		}
	}
}
