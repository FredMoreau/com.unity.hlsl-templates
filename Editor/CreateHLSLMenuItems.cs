using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Unity.HLSLTemplates.Editor
{
    public static class CreateHLSLMenuItems
    {
        const string TemplatesRoot = "Packages/com.unity.hlsl-templates/Templates";

        [MenuItem("Assets/Create/Shader Graph/Custom Function HLSL File")]
        public static void CreateHLSLFile()
        {
            CreateNewFromTemplate("SGCustomFunction", "NewSGCustomFunction.hlsl");
        }

        [MenuItem("Assets/Create/Shader Graph/Custom Function HLSL/Sample Texture")]
        public static void CreateHLSLFile_SampleTexture()
        {
            CreateNewFromTemplate("SGSampleTexture", "NewSGSampleTexture.hlsl");
        }

        [MenuItem("Assets/Create/Shader Graph/Custom Function HLSL/FloatArray")]
        public static void CreateHLSLFile_FloatArray()
        {
            CreateNewFromTemplate("SGFloatArray", "NewSGFloatArray.hlsl");
        }

        public static void CreateNewFromTemplate(string template, string filename)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile($"{TemplatesRoot}/{template}.txt", filename);
        }
    }
}