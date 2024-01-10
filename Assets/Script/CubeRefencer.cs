using UnityEngine;

public class CubeRefencer : MonoBehaviour
{

    [SerializeField]
    private CubeController _cubeOne;

    [SerializeField]
    private CubeController _cubeTwo;

    public CubeController CubeOne { get => _cubeOne; private set => _cubeOne = value; }
    public CubeController CubeTwo { get => _cubeTwo; private set => _cubeTwo = value; }

    public static CubeRefencer instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            return;
        }

        Destroy(this);
    }
}
