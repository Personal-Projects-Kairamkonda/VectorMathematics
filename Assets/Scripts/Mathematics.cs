using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathematics : MonoBehaviour
{
    public Transform guard;
    public Transform player;

    private Vector3 vectorDistance;
    private Vector3 vectorUnit;
    private float vectorLength;

    Vector3 facingNormal;
    Vector3 distance;

    void Awake()
    {
        //Vector positions
        Vector3 guardPos=guard.position;
        Vector3 guardFacing = transform.right;
        Vector3 playerPos = player.position;

        //normalize the positions
        facingNormal = Vector3.Normalize(guardFacing);
        distance = Vector3.Normalize(playerPos - guardPos);

        //Check angle
        float angle = Vector3.Angle(distance, facingNormal);

        float angleAcos = Mathf.Acos(Vector3.Dot(distance, facingNormal));
        Debug.Log($"Angle between guard and player is {angle}");
        Debug.Log($"AngleCos between guard and player is {angleAcos}");
    }

    void MyDotProduct()
    {
        float directionFacing = Vector3.Dot(distance, facingNormal);
        Debug.Log($"Dot product between them is {directionFacing}");
    }

    void UnitLength()
    {
        vectorLength = Vector3.Distance(guard.position, player.position);
        vectorDistance = Distance(guard, player);
        vectorUnit = vectorDistance.normalized;
        Debug.Log($"Distance is { vectorDistance}");
    }


    Vector3 Distance(Transform a, Transform b)
    {
        Vector3 dis;
        dis = a.position - b.position;
        return dis;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(guard.position, player.position);
    }
}
