using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

//could add enter a name screen here and at the end, for extra reward/sadness
using TMPro;

public class TitleGameControl : MonoBehaviour
{
    public static int Points;

    public Button startGame;

    // Start is called before the first frame update. and i had to keep track of the variables (excluding buttons)
    void Start()
    {
        Points = 0;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }

}
