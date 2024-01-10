using UnityEngine;

public class CubeDistanceCalculator
{

    public static float CalculateDistance()
    {
        return (CubeRefencer.instance.CubeOne.transform.position - CubeRefencer.instance.CubeTwo.transform.position).sqrMagnitude;
    }



}
