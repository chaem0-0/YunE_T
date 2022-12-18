Shader "Custom/Moon"
{
    Properties
    {
        _MainTex1 ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {}
        _LerpRange ("Lerp Range", Range(0, 1)) = 0


    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

//1pass step

        cull front 
        CGPROGRAM
        #pragma surface surf NoLight noambient vertex:vert

        sampler2D _MainTex1;
        sampler2D _MainTex2;
        float _LerpRange;
        struct Input
        {
            float2 uv_MainTex1;
            float2 uv_MainTex2;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {

            fixed4 c = tex2D (_MainTex1, IN.uv_MainTex1);
            fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2);
            //o.Albedo = c.rgb;
            o.Albedo = lerp(c.rgb, d.rgb, _LerpRange);
            o.Alpha = c.a;
        }
        void vert(inout appdata_full v){
                v.vertex.xyz += v.normal.xyz * 0.01;
        }

        float4 LightingNoLight(SurfaceOutput s, float3 lightDir, float atten){
                return float4(0,0,0,1);
        }
        ENDCG

//2pass step

        cull back 
        CGPROGRAM
        #pragma surface surf Lambert


        sampler2D _MainTex1;
        sampler2D _MainTex2;
        float _LerpRange;
        struct Input
        {
            float2 uv_MainTex1;
            float2 uv_MainTex2;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {

            fixed4 c = tex2D (_MainTex1, IN.uv_MainTex1);
            fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2);
            //o.Albedo = c.rgb;
            o.Albedo = lerp(c.rgb, d.rgb, _LerpRange);
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
