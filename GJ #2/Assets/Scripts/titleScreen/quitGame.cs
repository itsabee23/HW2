using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
    public void doExitGame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
