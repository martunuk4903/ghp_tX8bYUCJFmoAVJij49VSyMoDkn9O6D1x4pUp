using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

[InitializeOnLoad]
public static class AndroidProjectSettings
{
    static AndroidProjectSettings()
    {
        EditorApplication.delayCall += Apply;
    }

    public static void Apply()
    {
        var android = NamedBuildTarget.Android;
        var architectures = AndroidArchitecture.ARMv7 | AndroidArchitecture.ARM64;

        if (PlayerSettings.Android.minSdkVersion != AndroidSdkVersions.AndroidApiLevel26)
            PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel26;
        if (PlayerSettings.Android.targetSdkVersion != AndroidSdkVersions.AndroidApiLevel37)
            PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevel37;

        if (PlayerSettings.GetScriptingBackend(android) != ScriptingImplementation.IL2CPP)
            PlayerSettings.SetScriptingBackend(android, ScriptingImplementation.IL2CPP);
        if (PlayerSettings.GetApiCompatibilityLevel(android) != ApiCompatibilityLevel.NET_Standard)
            PlayerSettings.SetApiCompatibilityLevel(android, ApiCompatibilityLevel.NET_Standard);
        if (PlayerSettings.GetIl2CppCodeGeneration(android) != Il2CppCodeGeneration.OptimizeSpeed)
            PlayerSettings.SetIl2CppCodeGeneration(android, Il2CppCodeGeneration.OptimizeSpeed);
        if (PlayerSettings.Android.targetArchitectures != architectures)
            PlayerSettings.Android.targetArchitectures = architectures;
        if (PlayerSettings.Android.preferredInstallLocation != AndroidPreferredInstallLocation.Auto)
            PlayerSettings.Android.preferredInstallLocation = AndroidPreferredInstallLocation.Auto;
        if (PlayerSettings.Android.preferredDataLocation != AndroidPreferredDataLocation.PreferExternal)
            PlayerSettings.Android.preferredDataLocation = AndroidPreferredDataLocation.PreferExternal;
        if (!PlayerSettings.Android.forceInternetPermission)
            PlayerSettings.Android.forceInternetPermission = true;
        if (PlayerSettings.Android.forceSDCardPermission)
            PlayerSettings.Android.forceSDCardPermission = false;
        if (PlayerSettings.Android.splitApplicationBinary)
            PlayerSettings.Android.splitApplicationBinary = false;
        if (PlayerSettings.Android.applicationEntry != AndroidApplicationEntry.Activity)
            PlayerSettings.Android.applicationEntry = AndroidApplicationEntry.Activity;

        if (PlayerSettings.GetManagedStrippingLevel(android) != ManagedStrippingLevel.Minimal)
            PlayerSettings.SetManagedStrippingLevel(android, ManagedStrippingLevel.Minimal);
        if (!PlayerSettings.stripEngineCode)
            PlayerSettings.stripEngineCode = true;
        if (!PlayerSettings.stripUnusedMeshComponents)
            PlayerSettings.stripUnusedMeshComponents = true;
    }
}

public sealed class AndroidProjectSettingsBuildGuard : IPreprocessBuildWithReport
{
    public int callbackOrder => 0;

    public void OnPreprocessBuild(BuildReport report)
    {
        if (report.summary.platform == BuildTarget.Android)
            AndroidProjectSettings.Apply();
    }
}
