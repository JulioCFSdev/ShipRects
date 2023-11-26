using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ships.Commom
{
    public class ShipAI : MonoBehaviour
    {
        [Header("Player Detection")]
        [SerializeField] protected float fieldOfViewRadius = 20;
        [SerializeField] protected LayerMask playerLayerMask;

        [Header("Feedback")]
        [SerializeField] protected bool lockOnGetHit = true;

        [Header("AI Movement")]
        [SerializeField] protected AIActionVariables idleBehavior;
        [SerializeField] protected AIActionVariables detectPlayerBehavior;

        [Header("AI Action")]
        [SerializeField] protected List<AIActionModuleVariables> actions;

        [Header("Debug")]
        [SerializeField] private bool drawFieldOfView;
    }
}
