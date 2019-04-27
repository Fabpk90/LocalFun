using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public float movementSpeed;
    public Vector2 direction;
    public bool isEngineActive;

    private void FixedUpdate()
    {
        if (isEngineActive)
        {
            Vector2 dir = direction * movementSpeed;
            transform.position += new Vector3(dir.x, 0 , dir.y);
        }
    }
}
