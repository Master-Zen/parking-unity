﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Routes : MonoBehaviour {

    public void LoadScene(string scene)
    {
        Application.LoadLevel(scene);
    }
    public void ClickExit()
    {
        Application.Quit();
    }
}
