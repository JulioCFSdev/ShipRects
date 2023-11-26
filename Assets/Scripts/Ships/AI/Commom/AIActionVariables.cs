using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct AIActionVariables
{
    public List<float> floats;
    public List<string> strings;

    public AIModule pathModule;
}
