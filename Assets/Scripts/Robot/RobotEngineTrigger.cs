using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEngineTrigger : RobotTrigger
{
    private bool isActivated = false;

    public override void Use()
    {
        robot.isEngineActive = isActivated = !isActivated;
    }
}
