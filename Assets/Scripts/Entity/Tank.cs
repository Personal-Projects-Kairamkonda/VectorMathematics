using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank : MonoBehaviour
{
    public Text dotValueText;
    public Text dotAngleText;

    public Transform enemy;
    private string tankMessage;

    private Vector3 distanceNormals;
    private Vector3 tankNormals;
    private static float dotValue;
    private static float tankRot;

    void LateUpdate()
    {
        FacingDirection();
        TankRotation();

        UpdateTextData();
    }

    void FacingDirection()
    {
        distanceNormals = Vector3.Normalize(enemy.position - transform.position);
        tankNormals = transform.forward;

        dotValue = DotProduct.Dot(distanceNormals, tankNormals);
        tankRot = DotProduct.DotAngle(distanceNormals, tankNormals);
        //tankRot = Vector3.Angle(distanceNormals, tankNormals) * Mathf.Rad2Deg;

        if (dotValue > 0)
            tankMessage="Enemy is front of me";
        if(dotValue<0)
            tankMessage = "Enemy is behind me!!!!!!";

        //Debug.Log($"{tankMessage} & Value is {value}");
        //Debug.Log($"Angle Value is {tankRot}");
    }

    void TankRotation()
    {
        transform.eulerAngles += Vector3.up * tankRot * 10f * Time.deltaTime;
    }

    void UpdateTextData()
    {
        dotValueText.text = $"Value:{dotValue}";
        dotAngleText.text = $"Angle:{tankRot}";
    }
}
