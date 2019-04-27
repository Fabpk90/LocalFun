using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEngine : MonoBehaviour
{
    public float angle = 0;
    public float radius;

    private Robot robot;

    private void Awake()
    {
        robot = GetComponentInParent<Robot>();
        Turn();
    }

    public void Turn()
    {
        Vector2 pos = Vector2.zero;
        float xAngle = Mathf.Cos(Mathf.Deg2Rad * angle);
        float yAngle = Mathf.Sin(Mathf.Deg2Rad * angle);

        robot.direction.x = xAngle + .1f;
        robot.direction.y = yAngle + .5f;
        
        pos.x = radius * xAngle;
        pos.y = radius * yAngle;
        
        transform.position = new Vector3(pos.x, 0, pos.y);
    }
}
