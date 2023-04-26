using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mathematics : MonoBehaviour
{
    public Transform guard;
    public Transform player;

    public Text dotValueText;
    private float dotValue;

    public Text dotAngleText;
    private float dotAngle;

    private Vector3 vectorDistance;
    private Vector3 vectorUnit;
    private float vectorLength;

    Vector3 facingNormal;
    Vector3 distance;


    void Update()
    {
        CalculateDirection(player.position,guard.position);
        if(Input.GetKeyDown(KeyCode.Space))
            CalculateAngle();
    }

    void CalculateDirection(Vector3 targetPos, Vector3 startPos)
    {
        dotValue = DotProduct.Dot(Vector3.one, DotProduct.distance(targetPos, startPos));
        dotValueText.text = "Value:" + dotValue.ToString();
    }

    void CalculateAngle()
    {
        //Vector positions
        Vector3 guardPos = guard.position;
        Vector3 guardFacing = guard.transform.right;
        Vector3 playerPos = player.position;

        //normalize the positions
        facingNormal = Vector3.Normalize(guardFacing);
        distance = Vector3.Normalize(playerPos - guardPos);

        dotAngle = DotProduct.DotAngle(distance, facingNormal);
        dotAngleText.text = "Angle:" + dotAngle.ToString();

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(guard.position, player.position);
    }
}
