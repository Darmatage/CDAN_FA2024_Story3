using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour
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
    public GameObject ArtChar1f;
	public GameObject ArtChar1g;

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
		ArtChar1f.SetActive(false);
		ArtChar1g.SetActive(false);

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
            Char1speech.text = "OK. I'm at the club. The bartender said Lianhua is in the back.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Huh. Even their private rooms are filled with neon lights";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "You actually came.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Color me surprised.";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "Well it would be rude of me to stand you up after I literally asked to see you again";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
			ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true); // turn on bored
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Yeah, that's true";
        }


 else if (primeInt == 8)
        {
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "So, what do you do for a living";
        }
 else if (primeInt == 9)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh, I work for the... police department";
            Char2name.text = "";
            Char2speech.text = "";
        }
 else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Are you an Officer?";
        }
 else if (primeInt == 11)
        {
            Char1name.text = "YOU";
            Char1speech.text = "No more like a detective.";
            Char2name.text = "";
            Char2speech.text = "";
        }
 		else if (primeInt == 12)
        {
			ArtChar1a.SetActive(false);
			ArtChar1c.SetActive(true); //turn on flirty
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Damn, got any crazy cases you can share?";
        }
        else if (primeInt == 13)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Hmmm...";
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
			ArtChar1c.SetActive(false);
			ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Oh, REALLY...";
        }
		else if (primeInt == 21)
        {
            Char1name.text = "YOU";
            Char1speech.text = "AH- Wait! I can explain!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "No, I think you said enough.";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        // after choice 1b
        else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Oh, you're no fun...";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I am arresting the right person now!.";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Well there was this one time...";
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
        Char1speech.text = "I got nothing at the moment.";
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
        SceneManager.LoadScene("SceneLose");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("SceneWin");
    }
}