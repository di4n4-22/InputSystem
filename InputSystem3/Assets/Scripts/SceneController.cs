using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void OpenMainScene()
    {
        throw new NotImplementedException();
    }

    public void OpenGameScene()
    {
        SceneManager.LoadScene(0);
    }
    
}
