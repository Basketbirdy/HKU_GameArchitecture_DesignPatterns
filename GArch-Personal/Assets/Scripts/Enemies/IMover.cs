using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMover
{
    float Speed { get; }
    void Move();
}
