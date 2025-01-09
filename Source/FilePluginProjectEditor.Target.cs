// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FilePluginProjectEditorTarget : TargetRules
{
	public FilePluginProjectEditorTarget(TargetInfo Target) : base(Target)
	{
        
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V4;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
        ExtraModuleNames.Add("FilePluginProject");
	}
}
