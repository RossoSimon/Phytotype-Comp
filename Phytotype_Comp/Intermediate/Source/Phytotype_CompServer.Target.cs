using UnrealBuildTool;

public class Phytotype_CompServerTarget : TargetRules
{
	public Phytotype_CompServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Phytotype_Comp");
	}
}
