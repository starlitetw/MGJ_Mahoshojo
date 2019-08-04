using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchingScene : MonoBehaviour
{
    public string Scene;
    public void SwitchScene() 
    {
        SceneManager.LoadScene(Scene);
    }
}
