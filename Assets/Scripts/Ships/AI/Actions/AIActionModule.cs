using UnityEngine;

public class AIActionModule : AIModule
{
    public virtual bool PerformAction(GameObject AIGameObject, AIActionModuleVariables variables, Transform target = null)
    {
        CheckModuleSetUp(AIGameObject);
        return false;
    }

    public virtual void ReceiveCallbackID(int actionId, GameObject AIGameObject, AIActionModuleVariables variables, Transform target = null) { }

    protected virtual bool CheckVariablesAmount(AIActionModuleVariables variables, int floats = 0, int strings = 0, int objects = 0)
    {
        if (floats > 0 && (variables.floats == null || variables.floats.Count < floats))
        {
            Debug.Log("Not enought variables passed");
            return false;
        }
        else if (strings > 0 && (variables.strings == null || variables.strings.Count < strings))
        {
            Debug.Log("Not enought variables passed");
            return false;
        }
        else if (objects > 0 && (variables.objects == null || variables.objects.Count < objects))
        {
            Debug.Log("Not enought variables passed");
            return false;
        }

        return true;
    }

    public virtual Vector2 GetDesiredPosition(GameObject AIGameObject, Vector2 positionOnLock)
    {
        return positionOnLock;
    }

    public virtual void StopAction() { }

    public virtual void Draw(GameObject AIGameObject, AIActionModuleVariables variables) { }
}
