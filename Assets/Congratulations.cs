﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{
    public Text text;
    private Delay delay;
    public float timeToLoadScore;
    public GameState gameState;
    public Scene scene;

    private void OnEnable()
    {
        delay = new Delay(timeToLoadScore);
    }
    private void Update()
    {
        if (delay.IsOver)
        {
            text.enabled = true;
            gameState.Save();
            scene.Load("score board");
        }
    }
}