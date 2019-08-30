Shader "Custom/HIdden"
{

properties
{
   _MainTex ("Texture", 2D) = "white"{}

}


CGINCLUDE
 #include "UnityCG.cginc"

 sampler2D _MainTex;
 //構造体だったか。。。　
 float _ScrollValue;

 fixed4 frag (v2f_img i) : SV_Target
 {
   
   float u = i.uv.x;
   float v = i.uv.y; 

   //off set 

   v = frac(v + _ScrollValue);
 return tex2D(_MainTex, float2(u, v));


 }
    ENDCG

    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag
            ENDCG
        }
    }


}

