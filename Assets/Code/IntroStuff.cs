using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroStuff : MonoBehaviour
{
    public Button getStarted;
    public void GetStarted()
    {
        SceneManager.LoadScene("CustomerOneTalk");
    }
}
