using UnrealBuildTool;

public class Phytotype_CompClientTarget : TargetRules
{
	public Phytotype_CompClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Phytotype_Comp");
	}
}
