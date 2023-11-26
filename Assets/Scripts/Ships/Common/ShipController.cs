using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Ships.Commom
{
    public class ShipController : MonoBehaviour
    {
        protected NavMeshAgent agent;

        // Start is called before the first frame update
        void Start()
        {
            TryGetComponent(out agent);
            if (agent != null)
            {
                agent.updateRotation = false;
                agent.updateUpAxis = false;
            }
        }
    }
}
