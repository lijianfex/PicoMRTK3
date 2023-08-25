using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAppManager : MonoBehaviour
{
    public void ExitApp()
    {
        if(Application.isPlaying)
            Application.Quit();
    }
}
