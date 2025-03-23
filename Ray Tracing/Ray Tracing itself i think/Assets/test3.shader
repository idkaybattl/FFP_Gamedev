Shader "Custom/test3"
{
    SubShader
    {
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            Name "test3"

            CGPROGRAM
            #include "UnityCustomRenderTexture.cginc"
            #pragma vertex vert
            #pragma fragment frag
			#pragma multi_compile _ DEBUG_VIS


            struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			};

            float3 ViewParams;
            float4x4 CamLocalToWorldMatrix;

            struct Ray
            {
                float3 origin;
                float3 dir;
            };

            struct HitInfo
            {
                bool didHit;
                float distance;
                float3 normal;
                float3 hitPos;
            };

            HitInfo raySphere(Ray ray, float radius, float3 center) 
            {
                HitInfo hit = (HitInfo)0;
                float offsetRayOrigin = ray.origin - center;
                // The equation for wheter a ray touches the sphere is the squaredlength(Pos + Dir * dst) = r^2
                // When you solve that for distance you get a quadratic equation with these values for a, b, c
                // the thing in the root is the discriminant and it decides how many intersections there are with the sphere
                // if its less than 0 there are no intersections at 0 theres 1 and above there are two
                // this quadratic equation is btw fucking hard to find if you dont know what seems to me like advanced vector algebra which feels really damn hard but nvm

                float a = dot(ray.dir, ray.dir);
                float b = 2 * dot(ray.dir, offsetRayOrigin);
                float c = dot(offsetRayOrigin, offsetRayOrigin) - radius * radius;

                float discriminant = b * b - 4 * a * c;

                if (discriminant >= 0) {
                    float dst = (-b - sqrt(discriminant)) / (2 * a);

                    if (dst >= 0) {
                        hit.didHit = true;
                        hit.distance = dst;
                        hit.hitPos = ray.origin + ray.dir * dst;
                        hit.normal = normalize(hit.hitPos - center);
                    }
                }

                return hit;
            };

            float4 frag(v2f i) : SV_Target
            {
                float3 viewPointLocal = float3(i.uv - 0.5, 1) * ViewParams;
                float3 viewPoint = mul(CamLocalToWorldMatrix, float4(viewPointLocal, 1));

                Ray ray;
                ray.origin = _WorldSpaceCameraPos;
                ray.dir = normalize(viewPoint - ray.origin);

                return raySphere(ray, 1, 0).didHit;
            };
            ENDCG
        }
    }
}
