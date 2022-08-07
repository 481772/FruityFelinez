using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;


public class CatMenuControl : MonoBehaviour
{
    public Button bubbles, haven, tom, clover, roid, luci, pixie, backButton;
    public static string CatName;

    public void Bubbles()
    {
        CatName = "Bubbles";
    }

    public void Haven()
    {
        CatName = "Haven";
    }

    public void Tom()
    {
        CatName = "Tom";
    }

    public void Clover()
    {
        CatName = "Clover";
    }

    public void Roid()
    {
        CatName = "Roid";
    }

    public void Luci()
    {
        CatName = "Luci";
    }

    public void Pixie()
    {
        CatName = "Pixie";
    }

    public void BackButton()
    {
        SceneManager.LoadScene("CustomerOneTalk");
        Debug.Log(CatName);
    }
}
