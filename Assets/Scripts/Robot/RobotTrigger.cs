using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RobotTrigger : MonoBehaviour
{
    protected Robot robot;
    public bool isHoldTrigger;

    private void Awake()
    {
        robot = GetComponentInParent<Robot>();
    }

    public abstract void Use();
}
