using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour
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
            Char1speech.text = "Alright, this should be the place.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Man it's really crowded. I can barely even hear myself think!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "At least the music is good...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
			ArtChar1e.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Wait a minute... That's my target!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Ok, ok. Act cool.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Just approach the bar like a normal person!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 8)
        {
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Hi, is this seat taken?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Hm?";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Nah. Even if it was, I highly doubt the person would care";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Alright then...";
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
            ArtChar1a.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Pfft! Was that supposed to be a pickup line?";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "YOU";
            Char1speech.text = "N-No! It was a genuine question!";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }
         else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Uh huh...";
			primeInt=39;
        }
         else if (primeInt == 23)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Honest!";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }
         else if (primeInt == 24)
        {
            Char1name.text = "YOU";
            Char1speech.text = "This is my first time going to a club so...";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }

        // after choice 1b
        else if (primeInt == 30)
        {	ArtChar1a.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "First time?";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Man, I bet you were the sheltered kid growing up.";
			primeInt=39;
        }
        else if (primeInt == 32)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I wouldn't say that. I just didn't have time to go partying is all.";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }
        else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "You're a bookworm then?";
			primeInt=39;
        }
        else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "LIANHUA";
            Char2speech.text = "Grades more important than a social life?";
			primeInt=39;
        }
        else if (primeInt == 35)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I guess...";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }

	//after both choices:
	    else if (primeInt == 40)
        {
			ArtChar1c.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = ".";
        }
else if (primeInt == 41)
        {
            Char1name.text = "YOU";
            Char1speech.text = "[Ah man! that was horrible!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
		else if (primeInt == 42)
        {
            Char1name.text = "YOU";
            Char1speech.text = "[Maybe I should quit while I still have some dignity left...]";
            Char2name.text = "";
            Char2speech.text = "";
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
        Char1speech.text = "So... Do you come here often?";
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
        Char1speech.text = "This is my first time at a club.";
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
        SceneManager.LoadScene("Scene2a");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2b");
    }
}