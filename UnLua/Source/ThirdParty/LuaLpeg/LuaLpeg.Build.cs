using UnrealBuildTool;
using System.IO;
using System;

public class LuaLpeg : ModuleRules
{
    public LuaLpeg(ReadOnlyTargetRules Target) : base(Target)
    {
        //Type = ModuleType.External;

        //bEnableUndefinedIdentifierWarnings = false;
        //ShadowVariableWarningLevel = WarningLevel.Off;

        //PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "src"));

        //PublicDependencyModuleNames.AddRange(new string [] { "Core" });

        //PrivateDependencyModuleNames.AddRange(new string [] { "Lua" });

        //string DllPath = Path.GetFullPath(Path.Combine(ModuleDirectory, "Lib", "lpeg.dll"));
        //string LibPath = Path.GetFullPath(Path.Combine(ModuleDirectory, "Lib", "lpeg.lib"));

        //PublicAdditionalLibraries.Add(LibPath);
        //RuntimeDependencies.Add("$(BinaryOutputDir)/" + "lpeg.dll", DllPath);
        //PublicDelayLoadDLLs.Add("lpeg.dll");
    }
}