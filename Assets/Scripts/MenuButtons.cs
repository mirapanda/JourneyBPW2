using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject ChoiceStart;
    public GameObject ChoiceQuit;

    public int ChoiceMade;

    public void ChoiceOptionStart()
    {
        SceneManager.LoadScene(1);
        ChoiceMade = 1;
    }

    public void ChoiceOptionQuit()
    {
        Application.Quit();
        ChoiceMade = 2;
    }
}