using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class MenuGameControl : MonoBehaviour
{
    //drinks and cats, with loops below saving them to the passed variables (  CatName  &  DrinkName  )
    public Button firstCat;
    public Button firstDrink;
    public Button secondCat;
    public Button secondDrink;
    public Button thirdCat;
    public Button thirdDrink;


   

    //the drink and cat chosen. to be thrown to customer screen and used for scoring/dynamic interface 
    public static string CatName;
    public static string DrinkName;

    //back to talking to x 
    public Button goBack; 

    //drinkname and catname set to 0 in character scene/code <-- what does this mean
    //eventually want to implement a scroll, some way to keep track of buttons, little card-like icons and a 
    //journal-like feel, as if the player/owner of the cafe was keeping a journal of recipies/cats

    //back to whatever customer we came from, might need conditionals and a pbulic static correspodnign to 
    //what number person we chose

    public void backToFirstCustomer()
    {
        Debug.Log(DrinkName);
        Debug.Log(CatName);
        SceneManager.LoadScene("CustomerOneTalk");
    }



    //drink button functions 
    public void FirstDrink()
    {
        DrinkName = "BrainBrew";
    }
    public void SecondDrink()
    {
        DrinkName = "Drink2";
    }
    public void ThirdDrink()
    {
        DrinkName = "Drink3";
    }

    //cat button functions
    public void FirstCat()
    {
        CatName = "Cat1";
    }
    public void SecondCat()
    {
        CatName = "Clover";
    }
    public void ThirdCat()
    {
        CatName = "Cat3";
    }
}