using UnrealBuildTool;

public class Workshop2_2023Target : TargetRules
{
	public Workshop2_2023Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Workshop2_2023");
	}
}
