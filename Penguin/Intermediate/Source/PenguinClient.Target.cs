using UnrealBuildTool;

public class PenguinClientTarget : TargetRules
{
	public PenguinClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Penguin");
	}
}
