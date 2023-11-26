using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ships.Commom;
using UnityEditor.Timeline.Actions;
using UnityEngine.EventSystems;

namespace Ships.Playable
{
    public class ShipControllerPlayable : ShipController
    {
        [SerializeField] private float moveSpeed;

        private bool isMoving = false;

        private void FixedUpdate()
        {
            Vector2 inputVector = new Vector2(0, 0);
            isMoving = false;

            if (Input.GetKey(KeyCode.W))
            {
                inputVector.y = 1;
                isMoving = true;
            }
            if (Input.GetKey(KeyCode.S))
            {
                inputVector.y = -1;
                isMoving = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                inputVector.x = +1;
                isMoving = true;
            }
            if (Input.GetKey(KeyCode.A))
            {
                inputVector.x = -1;
                isMoving = true;
            }

            if (isMoving)
            {
                inputVector = inputVector.normalized;
                Vector3 moveDirection = new Vector3(inputVector.x, inputVector.y, 0f);
                print(moveDirection * moveSpeed * Time.deltaTime);
                transform.position += moveDirection * moveSpeed * Time.deltaTime;

                float rotationSpeed = 1f;
                Vector3 currentEulerAngles = transform.rotation.eulerAngles;
                Vector3 targetEulerAngles = Quaternion.LookRotation(Vector3.forward, moveDirection).eulerAngles;

                // Normaliza os ângulos entre 0 e 360 graus
                currentEulerAngles.z = Mathf.Repeat(currentEulerAngles.z, 360f);
                targetEulerAngles.z = Mathf.Repeat(targetEulerAngles.z, 360f);

                targetEulerAngles.x = currentEulerAngles.x;
                targetEulerAngles.y = currentEulerAngles.y;

                float angularThreshold = 1f;  // Ajuste conforme necessário

                float angleDifference = Quaternion.Angle(transform.rotation, Quaternion.Euler(targetEulerAngles));
                print(angleDifference);

                if (angleDifference > angularThreshold)
                {
                    // Slerp apenas se a diferença angular for significativa
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetEulerAngles), Time.deltaTime * rotationSpeed);
                }
                else
                {
                    // Se a diferença angular for pequena, defina diretamente a rotação
                    transform.rotation = Quaternion.Euler(targetEulerAngles);
                }
            }
        }

    }

}
