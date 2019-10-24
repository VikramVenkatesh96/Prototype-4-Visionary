﻿using UnityEngine;

public class watereffect : PostEffectBase
{


    //距离系数
    //distance factor
    public float distanceFactor = 60.0f;
    //时间系数
    //time factor
    public float timeFactor = -30.0f;
    //sin函数结果系数
    // Sin result factor
    public float totalFactor = 1.0f;

    //波纹宽度
    //wave width para
    public float waveWidth = 0.3f;
    //波纹扩散的速度
    //wave speed para
    public float waveSpeed = 0.3f;

    private float waveStartTime;
    private Vector4 startPos = new Vector4(0.5f, 0.5f, 0, 0);


    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        //计算波纹移动的距离，根据enable到目前的时间*速度求解
        //culcate the distance of curwave
        float curWaveDistance = (Time.time - waveStartTime) * waveSpeed;
        //设置一系列参数
        _Material.SetFloat("_distanceFactor", distanceFactor);
        _Material.SetFloat("_timeFactor", timeFactor);
        _Material.SetFloat("_totalFactor", totalFactor);
        _Material.SetFloat("_waveWidth", waveWidth);
        _Material.SetFloat("_curWaveDis", curWaveDistance);
        _Material.SetVector("_startPos", startPos);
        Graphics.Blit(source, destination, _Material);
    }

    void Update()
    {

    }
}