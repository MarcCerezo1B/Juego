using UnrealBuildTool;

public class PenguinEditorTarget : TargetRules
{
	public PenguinEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Penguin");
	}
}
