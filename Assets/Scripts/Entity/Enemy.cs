using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timeCounter=0;
    float radius = 8f;
    float speed = 0.2f;
   

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime*speed;

        float x = Mathf.Cos(timeCounter);
        float y = transform.position.y;
        float z= Mathf.Sin(timeCounter);

        transform.position = new Vector3(x, y, z)*radius;
    }
}
