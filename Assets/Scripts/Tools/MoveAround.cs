using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    private float speedVariartion;
    private const float defaultSpeed=10f;
    private Vector3 rotAngle;


    void Start()
    {
        speedVariartion = Random.Range(0.4f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        rotAngle = new Vector3(0, 10, 0)*speedVariartion*defaultSpeed*Time.deltaTime;

        // Rotate the object 90 degrees around the Y axis
        transform.Rotate(rotAngle);
    }
}
