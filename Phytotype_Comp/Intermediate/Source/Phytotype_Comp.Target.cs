using UnrealBuildTool;

public class Phytotype_CompTarget : TargetRules
{
	public Phytotype_CompTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Phytotype_Comp");
	}
}
