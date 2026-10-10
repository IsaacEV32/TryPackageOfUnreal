// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PruebaPackage : ModuleRules
{
	public PruebaPackage(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"PruebaPackage",
			"PruebaPackage/Variant_Platforming",
			"PruebaPackage/Variant_Platforming/Animation",
			"PruebaPackage/Variant_Combat",
			"PruebaPackage/Variant_Combat/AI",
			"PruebaPackage/Variant_Combat/Animation",
			"PruebaPackage/Variant_Combat/Gameplay",
			"PruebaPackage/Variant_Combat/Interfaces",
			"PruebaPackage/Variant_Combat/UI",
			"PruebaPackage/Variant_SideScrolling",
			"PruebaPackage/Variant_SideScrolling/AI",
			"PruebaPackage/Variant_SideScrolling/Gameplay",
			"PruebaPackage/Variant_SideScrolling/Interfaces",
			"PruebaPackage/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
