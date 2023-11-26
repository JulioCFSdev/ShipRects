using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct AIActionModuleVariables
{
    public AIActionModuleTriggers trigger;
    public float triggerTimer;
    public List<float> floats;
    public List<string> strings;
    public List<GameObject> objects;
    public AIActionModule actionModule;
    public bool debugDraw;

}
