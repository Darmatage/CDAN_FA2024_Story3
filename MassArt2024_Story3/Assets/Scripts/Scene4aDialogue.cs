using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour
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
    public GameObject ArtChar1d;
    public GameObject ArtChar1e;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
            Char1name.text = "YOU";
            Char1speech.text = "Alright! That's the last of 'em!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Phew- Who knew hunting monsters would be so difficult.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Maybe I can go on vacation after this...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
			ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Hey Boss! I did as you asked.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar1a.SetActive(false);
            ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Already?";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yep!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 8)
        {
            ArtChar1e.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "That was quick...";
        }
else if (primeInt == 9)
        {
            ArtChar1a.SetActive(false);
            ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Not even our best workers can hunt down monsters that quick.";
        }
        else if (primeInt == 10)
        {
			ArtChar1e.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Let alone three...";
        }
  else if (primeInt == 11)
        {
            ArtChar1a.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Unless they've been slacking off this entire time.";
        }
  else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "I swear if they're dating the targets I'll-!";
        }
       else if (primeInt == 13)
        {
            Char1name.text = "You";
            Char1speech.text = "So...Um...";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 14)
        {
            
            Char1name.text = "You";
            Char1speech.text = "Can I go on vacation?";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 15)
        {
            ArtChar1c.SetActive(false);
            ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "What?";
        }
       else if (primeInt == 16)
        {
            Char1name.text = "You";
            Char1speech.text = "You know...I worked soooo hard...";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 17)
        {
            Char1name.text = "You";
            Char1speech.text = "I deserve a vacation, don't you think?";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 18)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "You...";
        }
       else if (primeInt == 19)
        {
            ArtChar1e.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Unbelieveable.";
        }
       else if (primeInt == 20)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "And here I was...about to give you a promotion.";
        }
       else if (primeInt == 21)
        {
            Char1name.text = "You";
            Char1speech.text = "Promotion??";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Oh well, I'll just give it to a different employee.";
        }
       
        else if (primeInt == 23)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Have a good vacation~";

            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 30)
        {
            ArtChar1b.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "I'll take that promotion, thank you very much.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 31)
        {
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Hm...";
        }
        else if (primeInt == 32)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "I expect to see your report on my desk tomorrow morning.";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "You";
            Char1speech.text = "Aw man...";
            Char2name.text = "";
            Char2speech.text = "";
			//primeInt=39;

// Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        // after choice 1b
        else if (primeInt == 40)
        {	
            ArtChar1b.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Huh?";
        }
        else if (primeInt == 41)
        {	
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "What ABOUT me?";
        }
        else if (primeInt == 42)
        {	
            Char1name.text = "You";
            Char1speech.text = "Aren't you going on vacation too?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 43)
        {	
            Char1name.text = "You";
            Char1speech.text = "You've worked just as hard as me Boss.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 44)
        {	
            Char1name.text = "You";
            Char1speech.text = "So therefore, you deserve one as much as me.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 45)
        {	
            ArtChar1e.SetActive(false);
			ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Oh...";
        }
        else if (primeInt == 46)
        {	
            ArtChar1d.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "I can't possiby...";
        }
        else if (primeInt == 47)
        {	
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "There's so much to do...Monsters to capture.";
        }
        else if (primeInt == 48)
        {	
            ArtChar1a.SetActive(false);
			ArtChar1d.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "I'm sure monsters go on vacation too~";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 49)
        {	
            
            Char1name.text = "You";
            Char1speech.text = "Consider it a work trip.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 50)
        {	
            ArtChar1d.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Oh... Well...alright...";
        }
        else if (primeInt == 51)
        {	
            
            Char1name.text = "You";
            Char1speech.text = "Fine by me beautiful-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 52)
        {
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Watch it rookie.";
			//primeInt=59;
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

	//after both choices:
    /*
	    else if (primeInt == 60)
        {
			ArtChar1c.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Whatever.";
        }
else if (primeInt == 61)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Here are your files.";
        }
		else if (primeInt == 62)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Choose one to start off with.";
        }
		else if (primeInt == 63)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "You can choose your next case once you're done with your first.";
			
        }
*/

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Now hang on! Let's not be rash here!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "What about you?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 39;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("SceneWin");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("SceneLose_BossRomance");
    }
}