using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeDistanceTextUpdater : MonoBehaviour
{

    private Text _distanceText;

    private void Start()
    {
        _distanceText = this.GetComponent<Text>();
    }

    private void Update()
    {
        UpdateDistanceText();
    }


    private void UpdateDistanceText()
    {
        _distanceText.text = CubeDistanceCalculator.CalculateDistance().ToString();
    }


}
