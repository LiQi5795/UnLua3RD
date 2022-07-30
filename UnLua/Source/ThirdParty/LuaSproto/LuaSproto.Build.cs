using UnrealBuildTool;
using System.IO;
using System;

public class LuaSproto : ModuleRules
{
    public LuaSproto(ReadOnlyTargetRules Target) : base(Target)
    {
        //Type = ModuleType.External;

        //bEnableUndefinedIdentifierWarnings = false;
        //ShadowVariableWarningLevel = WarningLevel.Off;

        //PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "src"));

        //PublicDependencyModuleNames.AddRange(new string [] { "Core" });

        //PrivateDependencyModuleNames.AddRange(new string [] { "Lua" });

        //string DllPath = Path.GetFullPath(Path.Combine(ModuleDirectory, "Lib", "sproto.dll"));
        //string LibPath = Path.GetFullPath(Path.Combine(ModuleDirectory, "Lib", "sproto.lib"));

        //PublicAdditionalLibraries.Add(LibPath);
        //RuntimeDependencies.Add("$(BinaryOutputDir)/" + "sproto.dll", DllPath);
        //PublicDelayLoadDLLs.Add("sproto.dll");
    }
}