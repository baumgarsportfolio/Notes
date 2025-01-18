namespace Notes.Models;

internal class About
{
	public string Title => AppInfo.Name;
	public string Version => AppInfo.VersionString;
}