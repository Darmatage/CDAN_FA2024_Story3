using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1bDialogue : MonoBehaviour
{
    // These are the script variables.
    // For more character images / buttons, copy & renumber the variables:
    public int primeInt = 1;        // This integer drives game progress!
    public TMP_Text Char1name;
    public TMP_Text Char1speech;
    public TMP_Text Char2name;
    public TMP_Text Char2speech;
    //public TMP_Text Char3name;
    //public TMP_Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1a;
    public GameObject ArtChar1b;
    public GameObject ArtChar1c;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    //public GameObject NextScene1Button;
    //public GameObject NextScene2Button;
	//public GameObject NextScene3Button;

    //open the file folders:
	public GameObject OpenJoeyButton;
    public GameObject OpenLianhuaButton;
	public GameObject OpenVanessaButton;

    //display the investigate buttons:
	public GameObject investigateJoey;
    public GameObject investigateLianhua;
	public GameObject investigateVanessa;

    //display the arrested labels:
	public GameObject arrestedJoeyLabel;
    public GameObject arrestedLianhuaLabel;
	public GameObject arrestedVanessaLabel;

	//display the EndGame Buttons:
	public GameObject endPromotionButton;
    public GameObject endTerminationButton;

    public GameObject nextButton;
    public AudioSource SFX_pageflip;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        //NextScene1Button.SetActive(true);
        //NextScene2Button.SetActive(true);
		//NextScene3Button.SetActive(true);
        nextButton.SetActive(true);

	//investigation buttons (hide when case is abandoned)
		if(GameHandler.JoeyAbandoned == false){investigateJoey.SetActive(true);}
		else {investigateJoey.SetActive(false);}

		if(GameHandler.LianhuaAbandoned == false){investigateLianhua.SetActive(true);}
		else {investigateLianhua.SetActive(false);}

		if(GameHandler.VanessaAbandoned == false){investigateVanessa.SetActive(true);}
		else {investigateVanessa.SetActive(false);}

	//arrested labels:
		if(GameHandler.JoeyArrested == false){arrestedJoeyLabel.SetActive(false);}
		else {arrestedJoeyLabel.SetActive(true);}

		if(GameHandler.LianhuaArrested == false){arrestedLianhuaLabel.SetActive(false);}
		else {arrestedLianhuaLabel.SetActive(true);}

		if(GameHandler.VanessaArrested == false){arrestedVanessaLabel.SetActive(false);}
		else {arrestedVanessaLabel.SetActive(true);}
        
	//End Game Buttons:
		// if all paths finished:
		if ((GameHandler.JoeyArrested || GameHandler.JoeyAbandoned)
		&&(GameHandler.LianhuaArrested || GameHandler.LianhuaAbandoned)
		&&(GameHandler.VanessaArrested || GameHandler.VanessaAbandoned)){
			// if player arrested two players, Start end-Promotion:
			if ((GameHandler.JoeyArrested && GameHandler.LianhuaArrested)
			||(GameHandler.JoeyArrested && GameHandler.VanessaArrested)
			||(GameHandler.LianhuaArrested && GameHandler.VanessaArrested)){
				endPromotionButton.SetActive(true);
				endTerminationButton.SetActive(false);
				nextButton.SetActive(false);
			} 
			// Start end-Termination
			else {
				endPromotionButton.SetActive(false);
				endTerminationButton.SetActive(true);
				nextButton.SetActive(false);
			}
		} 
		// Game Not Over:
		else {
			endPromotionButton.SetActive(false);
			endTerminationButton.SetActive(false);
		}
    }

    // Use the spacebar as a faster "Next" button:
    void Update()
    {
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }
        }
    }


    //Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
    public void Next()
    {
        primeInt += 1;
        if (primeInt == 1)
        {
            // audioSource1.Play();
        }
        else if (primeInt == 2)
        {
            
            DialogueDisplay.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Huh. OK. Three files, just as promised.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "You";
            Char1speech.text = "Let's take a look.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
			DialogueDisplay.SetActive(false);
			nextButton.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }
        
		


//when you come back to this scene from Joey:
        else if (primeInt == 10)
        {
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "That is protocol, yes.";
        }
  else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "But unfortunately we're short staffed at the moment and these cases are urgent. ";
        }
  else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "You're the only one available.";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 20)
        {
            ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "You're lucky I'm choosing you at all for this assignment rookie";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Right... Yes ma'am. Sorry.";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }

        // after choice 1b
        else if (primeInt == 30)
        {	ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Woah there rookie, let's tone it down a bit.";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh...right.";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }

	//after both choices:
	    else if (primeInt == 40)
        {
			ArtChar1c.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Whatever.";
        }
else if (primeInt == 41)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Here are your files.";
        }
		else if (primeInt == 42)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Choose one to start off with.";
        }
		else if (primeInt == 43)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "You can choose your next case once you're done with your first.";
			// Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            //NextScene1Button.SetActive(true);
        }


        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Uh...Great! Totally no pressure!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 19;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "I won't let you down!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

//Open Joey File:
    public void OpenJoey()
    {
        SFX_pageflip.Play();
        ArtChar1a.SetActive(true);
		TurnOffFileOpenButtons();
    }
//Open Lianhua File:
    public void OpenLianhua()
    {
        SFX_pageflip.Play();
        ArtChar1b.SetActive(true);
		TurnOffFileOpenButtons();
    }
//Open Vanessa File:
	public void OpenVanessa()
    {
        SFX_pageflip.Play();
        ArtChar1c.SetActive(true);
		TurnOffFileOpenButtons();
    }

//investigate Joey:
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2a");
    }
//investigate Lianhua:
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
//investigate Vanessa:
	public void SceneChange3()
    {
        SceneManager.LoadScene("Scene2c");
    }


	public void TurnOffFileOpenButtons(){
		OpenJoeyButton.SetActive(false);
    	OpenLianhuaButton.SetActive(false);
		OpenVanessaButton.SetActive(false);
	}

	public void TurnOnFileOpenButtons(){
		OpenJoeyButton.SetActive(true);
    	OpenLianhuaButton.SetActive(true);
		OpenVanessaButton.SetActive(true);
	}

//End Game: Promotion:
    public void EndSceneChange1(){
        SceneManager.LoadScene("Scene4a");
    }
//End Game: Termination:
	public void EndSceneChange2(){
        SceneManager.LoadScene("Scene4b");
    }

}