Shader "Examples/ShaderSyntax"
{
    SubShader
    {
        Tags { "ExampleSubShaderTagKey" = "ExampleSubShaderTagValue" }
        LOD 100

        // ShaderLab commands that apply to the whole SubShader go here. 

        Pass
        {                
            Name "ExamplePassName"
            Tags { "ExampleTagKey" = "ExampleTagValue" }

            // ShaderLab commands go here.

            // HLSL code goes here.
            HLSLPROGRAM
            float4 frag (v2f i) : SV_Target 
            {
                return float4(1, 0, 0, 0);
            }
            ENDHLSL
        }
    }
}
