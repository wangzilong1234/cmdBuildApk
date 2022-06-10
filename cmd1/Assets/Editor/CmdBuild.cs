using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CmdBuild
{
    [MenuItem("Cmd/Build",false,1)]
    public static void PerformBuild() {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(scenes, "cmd.apk",BuildTarget.Android,BuildOptions.None);
    }
}
