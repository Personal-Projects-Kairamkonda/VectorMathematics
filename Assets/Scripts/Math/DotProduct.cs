using UnityEngine;

public static class DotProduct 
{
    public static float Dot(Vector3 a, Vector3 b)
    {
       return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    public static Vector3 distance(Vector3 a, Vector3 b)
    {
        return new Vector3(a.x - b.x, a.y - b.y);
    }

    public static float DotLength(Vector3 a)
    {
        return Mathf.Sqrt(Dot(a, a));
    }

    //θ = acos([AB]/[|A||B|]).
    public static float DotAngle(Vector3 a, Vector3 b)
    {
        return Mathf.Acos(Dot(a, b) / DotLength(a) * DotLength(b));
    }
}