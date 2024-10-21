using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour
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
            Char1speech.text = "Whew. First day. I'm nervous.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "At least I won't have to hunt monsters on my first day!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "You wanted to see me Boss?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Boss";
            Char2speech.text = "Yes, I have an assignment for you.";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Already?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I mean- if it's not presumptuous of me. I just started!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Shouldn't I be doing some grunt work or some training before taking on a case?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 9)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Maybe shadow someone even...?";
            Char2name.text = "";
            Char2speech.text = "";
        }
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
            NextScene1Button.SetActive(true);
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

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene1b");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene1b");
    }
}