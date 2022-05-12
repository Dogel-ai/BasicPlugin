using Exiled.API.Interfaces;

public class Config : IConfig {
	public bool IsEnabled { get; set; } = true;
	public string TrackMessage { get; set; } = "<color=yellow>Aby cieszyć się z rozgrywki na najwyższym poziomie, zalecamy wyłączyć </color><color=lime>DNT</color>";
}
