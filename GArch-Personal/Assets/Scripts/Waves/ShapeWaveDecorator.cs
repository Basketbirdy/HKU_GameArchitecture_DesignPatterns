using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ShapeWaveDecorator : IWaveInfo
{
    private IWaveInfo waveInfo;
    private Shape shape;


    public ShapeWaveDecorator(IWaveInfo waveInfo)
    {
        this.waveInfo = waveInfo;

        foreach(Shape shape in Enum.GetValues(typeof(Shape)))
        {
            if ((int)shape == UnityEngine.Random.Range(0, Enum.GetValues(typeof(Shape)).Cast<int>().Max()))
            {
                this.shape = shape;
            }
        }
    }

    public List<GroupInfo> GetGroupInfo()
    {
        List<GroupInfo> decoratedShapes = waveInfo.GetGroupInfo();
        decoratedShapes.Add(new GroupInfo(shape));
        return decoratedShapes;
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval();
    }
}
