Shader "Custom/watereffect"
{
	Properties 
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
 
	CGINCLUDE
	#include "UnityCG.cginc"
	uniform sampler2D _MainTex;
	float4 _MainTex_TexelSize;
	uniform float _distanceFactor;
	uniform float _timeFactor;
	uniform float _totalFactor;
	uniform float _waveWidth;
	uniform float _curWaveDis;
	uniform float4 _startPos;
 
	fixed4 frag(v2f_img i) : SV_Target
	{
		//DX下纹理坐标反向问题
		#if UNITY_UV_STARTS_AT_TOP
		if (_MainTex_TexelSize.y < 0)
			_startPos.y = 1 - _startPos.y;
		#endif
		//计算uv到中间点的向量(向外扩，反过来就是向里缩)
		float2 dv = _startPos.xy - i.uv;

		//base on size of screen to zoom
		float dis = sqrt(dv.x * dv.x + dv.y * dv.y);
		//用sin函数计算出波形的偏移值factor
		//dis在这里都是小于1的，所以我们需要乘以一个比较大的数，比如60，这样就有多个波峰波谷
		//sin函数是（-1，1）的值域，我们希望偏移值很小，所以这里我们缩小100倍，据说乘法比较快,so...
		float sinFactor = sin(dis * _distanceFactor) * _totalFactor * 0.005;
		//归一化
		float2 dv1 = normalize(dv);
		//计算每个像素uv的偏移值
		float2 offset = dv1  * sinFactor ;
		//像素采样时偏移offset
		float2 uv = offset + i.uv;
		return tex2D(_MainTex, uv);	
	}
 
	ENDCG
 
	SubShader 
	{
		Pass
		{
			ZTest Always
			Cull Off
			ZWrite Off
			Fog { Mode off }
 
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest 
			ENDCG
		}
	}
	Fallback off
}

