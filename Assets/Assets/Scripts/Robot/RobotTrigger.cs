using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RobotTrigger : MonoBehaviour
{
    public bool isHoldTrigger;

    public abstract void Use();
}
