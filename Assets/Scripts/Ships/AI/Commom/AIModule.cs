using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIModule : MonoBehaviour
{
    protected virtual void SetUpModule(GameObject AIGameObject){}
    protected virtual void CheckModuleSetUp(GameObject AIGameObject){}
    public virtual void OnFixedUpdate(GameObject AIGameObject, AIActionVariables variables, Transform target = null){}
    public virtual void Draw(GameObject AIGameObject, AIActionVariables variables) {}
}
