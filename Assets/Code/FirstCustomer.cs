using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class FirstCustomer : MonoBehaviour
{
    //need more customer x buttons
    public Button customerOneButton;
    public Button customerTwoButton;

    void Start()
    {
        //for the conditional in CustomerGameControl, which asks that the user puts fields in for both
        MenuGameControl.CatName = "";
        MenuGameControl.DrinkName = "";
    }

    //The name of the function shoudl change 
    public void TalkToCustomerOne()
    {
        //we change this part to suit however many customers there are
        SceneManager.LoadScene("CustomerOneTalk");
    }
}


//unsure how days will proceed; buttons need to be removed, a specific one, and random/definite ones chosen...