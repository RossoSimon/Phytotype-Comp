using UnrealBuildTool;

public class Phytotype_CompEditorTarget : TargetRules
{
	public Phytotype_CompEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Phytotype_Comp");
	}
}
