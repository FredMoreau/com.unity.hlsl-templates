using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Unity.HLSLTemplates.Editor
{
    public static class CreateHLSLMenuItems
    {
        const string TemplatesRoot = "Packages/com.unity.hlsl-templates/Templates";

        [MenuItem("Assets/Create/HLSL/Shader Graph/Custom Function")]
        public static void CreateHLSLFile()
        {
            CreateNewFromTemplate("SGCustomFunction", "NewSGCustomFunction.hlsl");
        }

        [MenuItem("Assets/Create/HLSL/Shader Graph/Texture Sampler")]
        public static void CreateHLSLFile_SampleTexture()
        {
            CreateNewFromTemplate("SGSampleTexture", "NewSGTextureSampler.hlsl");
        }

        [MenuItem("Assets/Create/HLSL/Shader Graph/FloatArray")]
        public static void CreateHLSLFile_FloatArray()
        {
            CreateNewFromTemplate("SGFloatArray", "NewSGFloatArray.hlsl");
        }

        [MenuItem("Assets/Create/HLSL/VFX Graph/Custom Function")]
        public static void CreateVFXG_CustomFunction()
        {
            CreateNewFromTemplate("VFXGCustomFunction", "NewVFXGCustomFunction.hlsl");
        }

        public static void CreateNewFromTemplate(string template, string filename)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile($"{TemplatesRoot}/{template}.txt", filename);
        }
    }
}