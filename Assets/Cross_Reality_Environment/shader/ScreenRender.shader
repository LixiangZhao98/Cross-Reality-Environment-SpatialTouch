Shader "Custom/ScreenRender" {
    Properties {
        _MainTex ("Base (RGB)", 2D) = "white" {}
    }
    SubShader {
        Pass {
            CGPROGRAM

            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            uniform sampler2D _MainTex;
            float2 _MainTex_TexelSize;

            struct v2f {
                float4 pos : SV_POSITION;
                float4 pos_frag : TEXCOORD0;
            };

            v2f vert(appdata_base v) {
                v2f o;
                float4 clipSpacePosition = UnityObjectToClipPos(v.vertex);
                o.pos = clipSpacePosition;
                o.pos_frag = clipSpacePosition;
                return o;
            }

            half4 frag(v2f i) : SV_Target {
                float2 uv = i.pos_frag.xy / i.pos_frag.w;
                uv = (uv + float2(1.0, 1.0)) * 0.5;
                if (_ProjectionParams.x < 0.0)
                {
                    uv.y = 1.0 - uv.y;
                }

                return tex2D(_MainTex, uv);
            }
            ENDCG
        }
    }
}