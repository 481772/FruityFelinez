using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class DrinkMenuControl : MonoBehaviour
{
    public Button bubblyBoba, brainyBrew, fightingSpirit, cyberCyder, fizzyFertilizer, shrinkingSangria, talkativeTea, modestMocha, maryBlood, backButton;
    public static string DrinkName;

    public void BubblyBoba()
    {
        DrinkName = "Bubbly Boba";
    }
    public void BrainyBrew()
    {
        DrinkName = "Brainy Brew";
    }

    public void FightingSpirit()
    {
        DrinkName = "Fighting Spirit";
    }

    public void CyberCyder()
    {
        DrinkName = "Cyber Cyder";
    }

    public void FizzyFertilizer()
    {
        DrinkName = "Fizzy Fertilizer";
    }

    public void ShrinkingSangria()
    {
        DrinkName = "Shrinking Sangria";
    }

    public void TalkativeTea()
    {
        DrinkName = "Talkative Tea";
    }

    public void ModestMocha()
    {
        DrinkName = "Modest Mocha";
    }

    public void MaryBlood()
    {
        DrinkName = "Mary's Blood";
    }

    public void BackButton()
    {
        SceneManager.LoadScene("CustomerOneTalk");
        Debug.Log(DrinkName);
    }
}
