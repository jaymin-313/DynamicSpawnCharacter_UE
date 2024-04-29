// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DynamicSpawn : ModuleRules
{
	public DynamicSpawn(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "HeadMountedDisplay", "NavigationSystem", "AIModule", "Niagara" });

		/*PrivateDependencyModuleNames.AddRange(new string[] { "EnhancedInput/Public" });*/

        PublicIncludePaths.AddRange(new string[] { "C:\\Program Files\\Epic Games\\UE_5.2\\Engine\\Plugins\\EnhancedInput\\Source\\EnhancedInput\\Public" });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
