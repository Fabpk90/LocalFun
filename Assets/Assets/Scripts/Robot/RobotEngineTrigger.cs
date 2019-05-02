using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEngineTrigger : RobotTrigger
{
    private bool isActivated = false;
    public RobotEngine engine;

    public override void Use()
    {
        isActivated = !isActivated;
        engine.SetIsEngineActive(isActivated);
    }
}
