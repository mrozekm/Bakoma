﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FruitsPanelPoints : MonoBehaviour {

    public enum fruitsNames
    {
        Apple = 1,
        Raspberry = 2,
        Blueberry = 3,
        Blackberry = 4,
        Peach = 5,
        Strawberry = 6
    }

    public fruitsNames fruitNamePoints;
    private int _lastPoint;
    private bool _updateScore = false;

    void Start() {
        _lastPoint = PlayerPrefs.GetInt("GamePoints_" + fruitNamePoints.ToString());
        GetComponent<Text>().text = _lastPoint.ToString();
    }

    void Update()
    {
        if (_updateScore)
        {
            GetComponent<Text>().text = PlayerPrefs.GetInt("GamePoints_" + fruitNamePoints.ToString()).ToString();
            _updateScore = false;
        
        }
    }

    public void UpdateScore() {
        _updateScore = true;
    }
}
