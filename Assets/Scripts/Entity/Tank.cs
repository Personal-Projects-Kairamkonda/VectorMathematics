using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public Transform enemy;
    private string tankMessage;

    private Vector3 distanceNormals;
    private Vector3 tankNormals;
    private float tankRot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            FacingDirection();

        TankRotation();
    }

    void FacingDirection()
    {
        distanceNormals = Vector3.Normalize(enemy.position - transform.position);
        tankNormals = transform.forward;
        float value = DotProduct.Dot(tankNormals, distanceNormals);

        if (value > 0)
        {
            tankMessage="Enemy is front of me";
        }
        if(value<0)
        {
            tankMessage = "Enemy is behind me!!!!!!";
        }

        Debug.Log($"{tankMessage} & Value is {value}");

        tankRot = DotProduct.DotAngle(tankNormals, distanceNormals);
        Debug.Log($"Angle Value is {tankRot}");
    }

    void TankRotation()
    {
        transform.eulerAngles = new Vector3(0, tankRot, 0);
    }



}
