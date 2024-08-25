// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Empty_DevEnvEditorTarget : TargetRules
{
	public Empty_DevEnvEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		bOverrideBuildEnvironment = true;
		ExtraModuleNames.AddRange( new string[] { "Empty_DevEnv" } );
	}
}
