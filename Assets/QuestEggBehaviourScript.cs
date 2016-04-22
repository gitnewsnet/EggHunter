using UnityEngine;
using System.Collections;

public class QuestEggBehaviourScript : MonoBehaviour {
    public float SpeedRotation = 15f;
    public float SpeedElevation = 0.75f;

    private Vector3 StartPosition;

    private void Start()
    {
        StartPosition = transform.position;
        Move();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Rotate(Vector3.up, SpeedRotation * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, StartPosition.y + Mathf.Sin(Time.time * SpeedElevation), transform.position.z);
    }
}
