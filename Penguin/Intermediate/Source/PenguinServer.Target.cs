using UnrealBuildTool;

public class PenguinServerTarget : TargetRules
{
	public PenguinServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Penguin");
	}
}
