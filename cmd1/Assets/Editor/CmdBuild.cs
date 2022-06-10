using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class CmdBuild
{
    [MenuItem("Cmd/Build",false,1)]
    public static void PerformBuild() {
        var outdir = System.Environment.CurrentDirectory + "/BuildOutPutPath/Android";
        var outputPath = Path.Combine(outdir, Application.productName + ".apk");
        //�ļ��д���
        if(!Directory.Exists(outdir))
            Directory.CreateDirectory(outdir);
        if(File.Exists(outputPath))
            File.Delete(outputPath);

        //��ʼ��Ŀһ�����
        string[] scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        UnityEditor.BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
        if(File.Exists(outputPath)) {
            Debug.Log("Build Success :" + outputPath);
        } else {
            Debug.LogException(new Exception("Build Fail! Please Check the log! "));
        }

    }
}
