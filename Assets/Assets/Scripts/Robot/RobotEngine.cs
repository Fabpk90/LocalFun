using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEngine : MonoBehaviour
{
    public float angle = 0;
    public float radius;

    private Robot robot;
    private bool isEngineActive;

    public float movementSpeed;
    public Vector2 direction;

    private ParticleSystem particles;

    private void Awake()
    {
        robot = GetComponentInParent<Robot>();

        radius = robot.GetComponent<BoxCollider>().bounds.size.x;
        radius += GetComponent<BoxCollider>().bounds.size.x;

        particles = GetComponentInChildren<ParticleSystem>();

        Turn();
    }

    private void FixedUpdate()
    {
        if (isEngineActive)
        {
            Vector2 dir = direction * movementSpeed;
            transform.position += new Vector3(dir.x, 0 , dir.y);
        }
    }

    public void Turn()
    {
        Vector2 pos = Vector2.zero;
        Vector3 centerRobot = robot.transform.position;
        
        angle %= 361;
        
        float xAngle = Mathf.Cos(Mathf.Deg2Rad * angle);
        float yAngle = Mathf.Sin(Mathf.Deg2Rad * angle);

        direction.x = -xAngle;
        direction.y = -yAngle;
        
        pos.x = centerRobot.x + radius * xAngle;
        pos.y = centerRobot.z + radius * yAngle;
        
        transform.position = new Vector3(pos.x, 0, pos.y);
    }

    public void SetIsEngineActive(bool isEngineActive)
    {
        particles.gameObject.SetActive(isEngineActive);
        
        this.isEngineActive = isEngineActive;
    }

    public bool GetIsEngineActive()
    {
        return isEngineActive;
    }
}
