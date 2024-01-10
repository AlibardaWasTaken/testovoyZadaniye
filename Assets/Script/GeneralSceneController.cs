using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralSceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject _spheres;

    private bool _active;

    void Update()
    {
        _active = (CubeDistanceCalculator.CalculateDistance() > 2);
        _spheres.SetActive(!_active);



        if (CubeDistanceCalculator.CalculateDistance() > 1) return;

        SceneManager.LoadScene(1);



    }
}
