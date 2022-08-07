using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement; 

public class CustomerOne : MonoBehaviour
{
    //the option buttons and what each button says, main text box, and a confirm button
    public TMP_Text rightText, leftText, mainTextBox, nextCustomerButtonText, confirmButtonText, customerName, chooseMenuTextBox;
    public Button optionRight, optionLeft, confirmSelection, toTheMenu, nextCustomer; 
    public static string optionChosen;

    public static string drinksOrCatsMenu;

    public static bool nextCustomerPressed; 


    string[] catArray = {"Luci", "Pixie", "Clover", "Roid", "Tom", "Pixie", "Tom", "Roid", "Clover", "Bubbles"};
    string[] drinkArray = {"Mary's Blood", "Cyber Cyder", "Brainy Brew", "Shrinking Sangria", "Talkative Tea", "Bubbly Boba", "Modest Mocha", "Fizzy Fertilizer", "Talkative Tea", "Fighting Spirit"};
    string[] customerArray = {"Amon", "A.C.E.", "Esther", "Magnus", "Ezra", "Basil", "Ondolanil Thaoruseus", "Jack", "Briar", "Calypso"};
    
    string[] firstCustomerText = {"It's been so long since I've visited the overworld, and yet it's stayed exactly the same. Well, this café is new at least. I only consume the finest food and drink, so hopefully you have something that cau suit my needs.", "I would ask for one of your more popular drinks, but I've had a pretty bad day, and I doubt any of your human stuff is strong enough.", "... Sorry, I was doing my homework. I think someone's cursed me! I'm so studious, yet I keep failing my sorcery classes. Got anything for me?", "Hello down there! Sorry about your roof... I wish I wasn't as... well... giant. It makes everything so difficult.", "*groan* \n (You/Narrator: They're not much for words, are they?)", "Sorry for all my tears, but I just lost my beloved cat yesterday. I wish there was a way to make me feel better, because the world feels so empty without my little Apple...", "It is I, the great Ondolanil Thaoruseus, ruler of the mighty lands! I have traveled far and wide searching for a drink that is as beautiful as I am. This place does not seem to have much promise, but serve me your best anyway, peasant!","Hello there, this café is very in-tree-guing! I'd love to have a refreshing treet to help me grow, wooden you think?", "The other day someone told me they liked my antlers, and I couldn't even say thank you because I'm so shy! I wish I could just get over it and talk to people. *under breath* Or at least talk to her...", "*huff* I've been away from the sea for so long, and I just found out that my boyfriend is cheating on me! He may be a pirate but he doesn't need to keep going back to his X."};
    string[] correctDrinkChosen = {"This drink is perfect. I can tell it is some pure blood.", "Ahhh... This is perfect. I've needed something like this for a while.", "Everything is making sense again! I actually get what's going on in class now, thank you so much.", "This is amazing! I can't believe I'm the same size as everything now, wow.", "What... happened? *gasp* I can talk?! This is crazy, thank you so much!", "I honestly don't feel as distraught anymore. Thank you so much!", "Wow, maybe I shouldn't be so pompous, I'm sure those around me don't enjoy it...", "I feel great! I can feel the energy in my leaves!", "Thank you so much! I feel like I can actually talk to people now, this is amazing!", "That stupid pirate deserves to feel my wrath! I swear I am going to shove that hook of his so far up his- Sorry, I think I got a bit carried away there."};
    string[] wrongDrinkChosen = {"Ew. No way am I drinking this.","This drink is definitely not strong enough for me. I need something made for us robots.","This drink is nice, but it's hard to enjoy it when I'm stressing out about school.","That's a nice drink, I guess. I would go now, but I wouldn't really fit through the door...","*grunt*","waaaaaaaa *continues crying and stuff*","This drink is abhorrent! Take it out of my sights immediately.","I don't feel very good...","Oh... thank you I guess.","Thanks, but I still don't know what to do about my boyfriend. Or ex-boyfriend now..."};


    string[] correctButtonOption = {"How was your drink?","So, what's it like being a robot?","Do you think you can handle your class now?","How does being smaller feel?","So, how are you doing?","I'm sorry for your loss. Is there anything else I can do to help?","I hope you enjoyed your drink!","Your jokes are very funny!","So, who's the lucky girl?","I hope he gets what he deserves, is there anything else I can do to make you feel better?"};
    string[] correctButtonReaction = {"Splendid. However, you have all these cats here, and so far none have even come near me. Are they scared? I may be the prince of hell, but even I'd like to have a furry partner in crime.","Well, it certainly has its perks, but most folks don't talk to me because of it. Being a robot is often a sad, solitary existence.","Yes, thank you! But even though I can understand everything we've learned now, it would take a lot of luck for me to be able to pass after the amount of tests I've failed.","It feels great! But still, I've always been so strong and large, even like this. We're at a cat café, but I don't want to touch any of the cats because they're not strong enough to handle it without getting hurt","Being able to actually talk feels great, I can't thank you enough! I only wish I had someone to practice this new skill with.","Thank you, I do feel a bit better now, but I still feel very lonely without her with me.","I really did, thank you so much. It really made me reconsider my world view and reevaluate my outlook on other people. I truly believe... eldenry... elffectiveness... that fool on a shelf....\n(You/Narrator: Does he ever stop talking??)","Why thank you! I would love to travel and share my jokes with the world, but I feel a little... rooted down. Sadly, most folks can't carry my weight. It really limits my transportation, so it's a real pine in the neck. I wish there was something strong enough to carry me around. Ah, don't mind me, I'm just getting all sappy now.","Oh! You heard that? Yeah, I wanted to ask her out, but I didn't know how. Now though, I'm going to ask her, and if I'm lucky enough, she'll say yes!","Well, I do wish I had something to remind me of home, before I met that stupid pirate that convinced me to explore the world outside of the sea."};

    string[] wrongButtonOption = {"Are you here to take me to hell?","Do you want me to get you some motor oil to drink instead or something?","You sure got your confidence back fast; I don't think even that drink can save you from an F.","You should get out of here now, before you damage the café any more.","You're not going to try and eat my brain or something, are you?","Are you done with all the waterworks now?","Well, if anything, you've certainly been a royal pain in the ass.","Your puns suck.","You really think she won't like me? Oh god, that's my worst nightmare!\n^Crying sprite or something","We can take you into the kitchen and you can help make our new sushi dishes!"};
    string[] wrongButtonReaction = {"What? No— well not right now at least. I just get sick of the food down there every once in a while. Speaking of which, it's almost time for my daily soul-torturing, so I better head out. See you soon!","How dare you assume all robots drink oil! Only the most crude machines rely on such basic substances. If that's all you think of me, maybe it's better if I leave.","Wow, thanks for your opinion. I'm going to go study more now.","Oh... yeah, you're probably right. I'll get out of here now I guess...","Even now that I can properly express myself, people always assume the worst. Maybe this wasn't even worth it...","sobbing crying yaknow the works","*GASP* How dare you! Just as I was starting to think about the feelings of those other than me, you have shown me that it does not matter anyway.","I might be going out on a limb here, but I think we got off on the wrong branch... Either way, I think it's about time I make like a tree and leaf.","Now go ask \"her\" out so she can reject you already.","OH MY GOD WTF IS WRONG WITH YOU AAAAAAA"};
    string[] whichButtonIsCorrect = {"left","right","right","right","right","left","left","right","left","left"};
    
    string[] correctCatChosen = {"Ooh... This cat is perfect! It seems like just the type to scratch people for no reason. Thank you!","This cat is amazing, I feel so welcome now. Thank you!","For some reason, I'm feeling really lucky! I think I'm going to talk to my professor and do my best to pass my classes, thank you!","This cat is so buff, I can pet it easily! Thank you!","(You/Narrator: They already seem deep in conversation with Tom!)","Aww, I love them! I feel much better now, thank you!","...\n(You/Narrator: Tom is talking so much that he can't get a word in edgewise. Finally!)","I can't be-leaf it, this cat is perfect! They're definitely strong enough to carry me around. This is tree-mendous, now I can share my jokes with the world!","Honestly, this cat makes me feel like I can do it! I'm going to go ask her, thank you!","Aw, they're perfect! Finally, a cat that will swim with me. Thank you!"};
    string[] wrongCatChosen = {"This cat looks like it would rather be anywhere else than here.","This cat is nice, but I don't think it likes me very much.","This is a nice cat, but I should probably go review my notes or something.","I probably shouldn't touch this cat, I don't want to hurt them.","It's nice to pet, but it's hard to practice speaking with this cat.","This cat is very nice and all, but they're nothing like my Apple...","What a nice cat! It reminds me of a creature I saw back when I was exploring the land of The Tyrant Niclaus...\n(You/Narrator: Looks like that didn't work...)","This cat is nice, but it's not like I can pet them or anything.","This cat is... cute. Thanks.","Normal cats don't usually like water, I don't think."};


    public static int numCustomers = 0; 

    // records what "level" of conversation, or how many times an option was chosen.
    //there are loops inside the whichLayer conditionals checking whether r or l chosen
                            //iewajrgjinwaegkngwad

    //sets the customer's preferred drink & cat

    //IF IT DOESNT WORK CHECK THE CATNAME/DRINKNAME, ITS TAKEN FROM Drink/CatMENUCONTROL 
    public static string CatName, DrinkName;

    //put it into update() to change sprites/convey how the game interprets the player's actions 
    public static string customerEmotion;

    //SHOULD BE CALLED FROM A DIFFERENT/NODE SCRIPT (as in a place the cusomter scenes branch off)
    //or could be called by subsequent code, might need two variables like secondCustPoints = thiscode.firstCustPoints +x
    public static int Points;

    public static bool pressedConfirmButton;
    public static bool pressedLOrRButton;
    public static bool lastCustomer = false;

    public static int whichLayer;

    public GameObject Demon;
    public GameObject Robot;
    public GameObject Witch;
    public GameObject Giant;
    public GameObject Zombie;
    public GameObject Fairy;
    public GameObject Elf;
    public GameObject Plant;
    public GameObject Antlers;
    public GameObject Mermaid;


    private SpriteRenderer sprender;

    //use the thing with nextfcustomer button to hide them 
    

    public void hideSprite(GameObject gObj)
    {
        sprender = gObj.GetComponent<SpriteRenderer>();
        sprender.enabled= false;
    }

    public void showSprite(GameObject gObj)
    {
        sprender = gObj.GetComponent<SpriteRenderer>();
        sprender.enabled= true;
    }

    public void HideButton(Button but)
    {
        but.gameObject.SetActive(false);
    }
    public void ShowButton(Button but)
    {
        but.gameObject.SetActive(true);
    }

    void Awake()
    {
        optionChosen = "";

        nextCustomerPressed = true;

        pressedConfirmButton = false;
        pressedLOrRButton = false;
        DontDestroyOnLoad(this.gameObject);
        fixSprite();
        checkDialogue();
       
        //by default hide and disable (for instance, by isntantiating and deleting) the buttons

        //i can try to make them hide by default in unity game and show in here, banking on scene alternation
        //to get them hidden again
    }


    void Start()
    {
        Debug.Log(numCustomers);
        hideSprite(Demon);
        hideSprite(Robot);
        hideSprite(Zombie);
        hideSprite(Witch);
        hideSprite(Plant);
        hideSprite(Fairy);
        hideSprite(Elf);
        hideSprite(Antlers);
        hideSprite(Giant);
        hideSprite(Mermaid);
        fixSprite();
    
        if ( whichLayer == 0 )
        {  
            if (DrinkMenuControl.DrinkName != "")
            {
                confirmButtonText.SetText("Confirm drink: "+ DrinkMenuControl.DrinkName);
            }
            else 
            {
                confirmButtonText.SetText("Pick a drink");
            }
        }
        if (whichLayer == 2)
        {
            if (CatMenuControl.CatName != "")
            {
                confirmButtonText.SetText("Confirm cat: "+ CatMenuControl.CatName);
            }
            else 
            {
                confirmButtonText.SetText("Pick a cat");
            }
        }
    }

    public void checkDialogue()
    {
        if (nextCustomerPressed == true)
        {
            
            customerName.SetText(customerArray[numCustomers]);
            //switch the sprite based on customernum
            //and the text at the very top (title)
            if ( whichLayer == 0 )
            {
                HideButton(optionRight);
                HideButton(optionLeft);
                ShowButton(toTheMenu);
                ShowButton(confirmSelection);
                mainTextBox.SetText(firstCustomerText[numCustomers]);
                //hide the buttons, set to drink
               

                drinksOrCatsMenu = "drinks";
                chooseMenuTextBox.SetText("drinks");

                if (pressedConfirmButton == true)
                {
                    if ( drinkArray[numCustomers] == DrinkMenuControl.DrinkName )
                    {
                        Debug.Log("thanks for drink text, with new text options");    
                        TitleGameControl.Points = TitleGameControl.Points + 1;
                        whichLayer = 1;
                        pressedConfirmButton = false;
                        DrinkMenuControl.DrinkName = "";
                        checkDialogue();
                    }
                    else
                    {
                        if (DrinkMenuControl.DrinkName == "")
                        {
                            Debug.Log("no drink chosen");
                            pressedConfirmButton = false;
                            checkDialogue();
                        }
                        //only pings when a nonempty option chosen, so feel free to make them angry
                        customerEmotion = "wrong drink";
                        mainTextBox.SetText(wrongDrinkChosen[numCustomers]);
                        pressedConfirmButton = false;
                        nextCustomerPressed = false;
                       
                       
                       DrinkMenuControl.DrinkName = "";
                    }
                }
                //no right/left to optionchosen 
            }
            else if ( whichLayer == 1 )
            {  
                ShowButton(optionRight);
                ShowButton(optionLeft);
                HideButton(toTheMenu);
                HideButton(confirmSelection);
                mainTextBox.SetText(correctDrinkChosen[numCustomers]);
                if ( whichButtonIsCorrect[numCustomers] == "right" )
                {
                    rightText.SetText(correctButtonOption[numCustomers]);
                    leftText.SetText(wrongButtonOption[numCustomers]);
                }
                else
                {
                    rightText.SetText(wrongButtonOption[numCustomers]);
                    leftText.SetText(correctButtonOption[numCustomers]);
                }
                if ( pressedLOrRButton == true )
                {
                    //BUTTON PRESS calls this thing becaues whichLayer =1 so wait until button press and the conditionals will go l or r
                    if ( optionChosen == whichButtonIsCorrect[numCustomers])
                    {
                        whichLayer = 2;
                        pressedLOrRButton = false;
                        checkDialogue();
                    }
                    else
                    {
                        customerEmotion = "irate";
                        mainTextBox.SetText(wrongButtonReaction[numCustomers]);
                        //write what happens when angry here
                        pressedLOrRButton = false;
                        nextCustomerPressed = false;
                        
                        


                        nextCustomer.gameObject.SetActive(true);
                    }
                }
            }
            else if ( whichLayer == 2 )
            {
                //negated left and right, text box is hint, called function after making choice. time to choose
                mainTextBox.SetText(correctButtonReaction[numCustomers]);
                ShowButton(toTheMenu);
                ShowButton(confirmSelection);
                HideButton(optionRight);
                HideButton(optionLeft);
        
                drinksOrCatsMenu = "cats";
                chooseMenuTextBox.SetText("cats");

                
                if ( pressedConfirmButton == true )
                {
                    if ( CatMenuControl.CatName == catArray[numCustomers] )
                    {
                        TitleGameControl.Points = TitleGameControl.Points + 2;
                        mainTextBox.SetText(correctCatChosen[numCustomers]);
                        //pause
                        pressedConfirmButton = false;
                        nextCustomerPressed = false;

                   

                        nextCustomer.gameObject.SetActive(true);
                       CatMenuControl.CatName = "";
                    }
                    else
                    {
                        if (CatMenuControl.CatName == "")
                        {
                            
                            Debug.Log("no cat chosen");
                            checkDialogue();
                        }
                        mainTextBox.SetText(wrongCatChosen[numCustomers]);
                        //pause1
                        pressedConfirmButton = false;
                        nextCustomerPressed = false;

              

                        nextCustomer.gameObject.SetActive(true);
                        CatMenuControl.CatName = "";
                    }
                    
                }
            }
        }
    }

    public void NextCustomer()
    { 
        
        nextCustomerButtonText.SetText("Next customer");


        nextCustomerPressed = true;

        CatMenuControl.CatName = "";
        DrinkMenuControl.DrinkName = "";

        whichLayer = 0;

        // if (customerArray[numCustomers]=="asdf")
        // {
        //     //new day... these loops should be else loops & have name of customer who marks day in condition
        //     //Debug.Log("Esther done = new day");
        // }
        // else if (customerArray[numCustomers]=="sad")
        // {
        //     //nwe day 
        //     //Debug.Log("basil done = new day");
        // }
        // else if (customerArray[numCustomers]=="asdga")
        // {
        //     //new day
        //     //Debug.Log("calypso done = new day");
        // }
        if ( customerArray[numCustomers]=="Calypso" )
        { //=9 before adding (after finishing(-good or bad end) mermaid)
            numCustomers = numCustomers + 1;
            fixSprite();
            checkDialogue();
            lastCustomer = true;
            //end scene
        }
        else if(lastCustomer == true)
        {
            Application.Quit();
        }
        {
            numCustomers = numCustomers + 1;
            fixSprite();
            checkDialogue();
        }
        nextCustomer.gameObject.SetActive(false);
    }

    public void fixSprite()
    {
        if (numCustomers == 0)
        {
            hideSprite(Mermaid);
            showSprite(Demon);
        }
        if (numCustomers == 1)
        {
            hideSprite(Demon);
            showSprite(Robot);
        }
        if (numCustomers == 2)
        {
            hideSprite(Robot);
            showSprite(Witch);
        }
        if (numCustomers == 3)
        {    
            hideSprite(Witch);
            showSprite(Giant);
        }
        if (numCustomers == 4)
        {
            hideSprite(Giant);
            showSprite(Zombie);
        }
        if (numCustomers == 5)
        {
            hideSprite(Zombie);
            showSprite(Fairy);
        }
        if (numCustomers == 6)
        {
            hideSprite(Fairy);
            showSprite(Elf);
        }
        if (numCustomers == 7)
        {
            hideSprite(Elf);
            showSprite(Plant);
        }
        if (numCustomers == 8)
        {
            hideSprite(Plant);
            showSprite(Antlers);
        }
        if (numCustomers == 9)
        {
            hideSprite(Antlers);
           showSprite(Mermaid);
        }
    }

    public void ButtonForNextCustomer()
    {
        nextCustomer.gameObject.SetActive(false);
        checkDialogue();
    }

    public void RightDrink()
    {
        mainTextBox.SetText("Everything is making sense again! I actually get what's going on in class now, thank you so much.");
        rightText.SetText("..."); 
        leftText.SetText("next");
    }

    public void confirmChoice()
    {
        pressedConfirmButton = true;
        if ( whichLayer == 0 ) 
        {
            if ( "" != DrinkMenuControl.DrinkName )
            {
                checkDialogue();
            }
        }
        else if ( whichLayer == 2 ) 
        {
            if ( "" != CatMenuControl.CatName )
            {
                checkDialogue();
            }  
        }
    }

    public void chooseRight()
    {
        optionChosen = "right";
        pressedLOrRButton = true;
        checkDialogue();
    }

    public void chooseLeft()
    {
        optionChosen = "left";
        pressedLOrRButton = true;
        checkDialogue();
    }

    public void OpenMenu()
    {
        if (drinksOrCatsMenu == "drinks")
        {
            SceneManager.LoadScene("DrinkMenu");
        }
        else
        {
            SceneManager.LoadScene("CatMenu");
        }
    }
    //call the update button functions and change the newright/left texts
    //points, whichLayer, drink and cat (called with periods), comments for emotions
    //reset values at the end
}
