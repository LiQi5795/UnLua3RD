
using System.IO;
using System;
using UnrealBuildTool;

public class LuaCrypt : ModuleRules
{
    public LuaCrypt(ReadOnlyTargetRules Target) : base(Target)
    {
        //Type = ModuleType.External;

        //bEnableUndefinedIdentifierWarnings = false;
        //ShadowVariableWarningLevel = WarningLevel.Off;

        //PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "src"));

        //PublicDependencyModuleNames.AddRange(new string [] { "Core" });

        //PrivateDependencyModuleNames.AddRange(new string [] { "Lua" });

        //string DllPath = Path.GetFullPath(Path.Combine(ModuleDirectory, "Lib", "crypt.dll"));
        //string LibPath = Path.GetFullPath(Path.Combine(ModuleDirectory, "Lib", "crypt.lib"));

        //PublicAdditionalLibraries.Add(LibPath);
        //RuntimeDependencies.Add("$(BinaryOutputDir)/" + "crypt.dll", DllPath);
        //PublicDelayLoadDLLs.Add("crypt.dll");
    }
}