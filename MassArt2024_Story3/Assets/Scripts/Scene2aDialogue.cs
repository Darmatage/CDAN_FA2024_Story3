using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour
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
    public GameObject ArtChar1h;
    //public GameObject ArtChar2;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject Choice3;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
	/*
    public GameObject NextScene3Button;
    public GameObject NextScene4Button;
	*/
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
        ArtChar1h.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		/*
		NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
		*/
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

			//secret debug code
			if (Input.GetKeyDown("p"))
            {
                //Previous();
				primeInt -= 2;
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
            Char1speech.text = "I gotta stay focused. The target supposedly works here...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "*whistling*";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            
            Char1name.text = "You";
            Char1speech.text = "Oh- uh...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "You";
            Char1speech.text = "Hello?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "AGH!";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh- your um- your...eyes fell...uh nevermind.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Sorry about that! You sure gave me a spook there!";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "You";
            Char1speech.text = "Sorry! I didn't mean to sneak up on you like that!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "No worries man! As a janitor, after-hours freaky figures tend to be the ushe.";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "What can I do for ya?";

            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a
        else if (primeInt == 20)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "No worries dude! The exit is straight down the way you came!";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Weird that you missed it!";
        }
        else if (primeInt == 22)
        {
            Char1name.text = "You";
            Char1speech.text = "Yeah...weird";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
              // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            Choice3.SetActive(true);

        }

        //after choice3

        else if (primeInt == 100)
		{
            
                Char1name.text = "You";
                Char1speech.text = "You look really familiar...have we met?";
                Char2name.text = "";
                Char2speech.text = "";

		}
         else if (primeInt == 101)
		{
            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "Mmmmm- Not that my slimy- I MEAN HUMAN EYES recall?";

		}
         else if (primeInt == 102)
		{
            
                Char1name.text = "You";
                Char1speech.text = "YES!! We met at that faculty thing last year!";
                Char2name.text = "";
                Char2speech.text = "";

		}
 else if (primeInt == 103)
		{
            
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "...";
                 primeInt = 36;

		}



        // after choice 1b
        else if (primeInt == 30)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Right on! That's me!";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I hate to leave my adoring fans waiting.";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "YOU";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Kidding.";
        }
        else if (primeInt == 34)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Right...Well. I wasn't sure if you'd remember me!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 35)
        {
            Char1name.text = "You";
            Char1speech.text = "We met at that faculty thing remember?!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 36)
        {
            ArtChar1c.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "...";
        }
        else if (primeInt == 37)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "RIIIGGGHHTTT!! I remember you!";

        }
        else if (primeInt == 38)
        {
            Char1name.text = "You";
            Char1speech.text = "I was the one wearing the- uh...clothes!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 39)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "OMG! I think I was also wearing clothes that day!";

        }
        else if (primeInt == 40)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I mean everyday...like all humans do...";
        }

        else if (primeInt == 41)
        {
            Char1name.text = "You";
            Char1speech.text = "Humans do indeed wear clothes.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 42)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "They sure do! Psh- humans, what a bunch.";
        }
        else if (primeInt == 43)
        { 
           Char1name.text = "You";
           Char1speech.text = "Yeah...so, um- anyways.";
           Char2name.text = "";
           Char2speech.text = "";
		}
        else if (primeInt == 44)
        { 
           Char1name.text = "You";
           Char1speech.text = "[I've gotta loosen him up...]";
           Char2name.text = "";
           Char2speech.text = "";

			// Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true);
            Choice2b.SetActive(true);
		}

	//after choice 2a
		else if (primeInt == 50)
		{

            ArtChar1c.SetActive(false);
            ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "OH! Did you? Cuz I don't- I don't think. Are you sure?";
            }
            else if (primeInt == 51)
            {
                
                Char1name.text = "You";
                Char1speech.text = "It's ok if you lost it, I'll just borrow yours.";
                Char2name.text = "";
                Char2speech.text = "";
            }
            else if (primeInt == 52)
            {
                ArtChar1b.SetActive(false);
                ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "...";
            }
            else if (primeInt == 53)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "I uh...I don't have a phone...";
            }
            else if (primeInt == 54)
            {
                Char1name.text = "You";
                Char1speech.text = "Oh...";
                Char2name.text = "";
                Char2speech.text = "";
            }
  else if (primeInt == 55)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "BUT UM!! That's not to say- I mean I don't!! We could uh.";
            }


           else if (primeInt == 56)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "Still, hang out or something soemtime?";
     
            }

           else if (primeInt == 57)
            {
                Char1name.text = "You";
                Char1speech.text = "Like a date?";
                Char2name.text = "";
                Char2speech.text = "";
            }

           else if (primeInt == 58)
            {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "YEAH!! Or no..? Or whatever!!";

            }
          else if (primeInt == 59)
            {
                Char1name.text = "You";
                Char1speech.text = "Sure, a date then.";
                Char2name.text = "";
                Char2speech.text = "";
            }

		else if(primeInt == 60)
            {
                Char1name.text = "You";
                Char1speech.text = "Pick you up after your work on friday? You pick where?";
                Char2name.text = "";
                Char2speech.text = "";
            }
	else if (primeInt == 61)
	{
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "Y-yeah!! YEAH!! That'd be awesome! I can't wait!";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
           NextScene2Button.SetActive(true);
	}

	//after choice 2b
		else if (primeInt == 70)
		{
                Char1name.text = "You";
                Char1speech.text = "We should hang out more!";
                Char2name.text = "";
                Char2speech.text = "";

		}
else if (primeInt == 71)
		{
            ArtChar1c.SetActive(false);
            ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "What? Really? You think?";

		}

else if (primeInt == 72)
		{
                Char1name.text = "You";
                Char1speech.text = "Sure! Why not! I mean- you had fun that night, didn't you?";
                Char2name.text = "";
                Char2speech.text = "";

		}

else if (primeInt == 73)
		{
            ArtChar1d.SetActive(false);
            ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "T..uh. Yeah toally!!";

		}

else if (primeInt == 74)
		{
                Char1name.text = "You";
                Char1speech.text = "So why not?";
                Char2name.text = "";
                Char2speech.text = "";

		}

else if (primeInt == 75)
		{
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "You're straight on!! Listen, I got the coolest spot.";

		}

        else if (primeInt == 76)
		{
                Char1name.text = "You";
                Char1speech.text = "Deal. I'll pick you up on Friday. You show the way.";
                Char2name.text = "";
                Char2speech.text = "";

		}
         else if (primeInt == 77)
		{
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "SWEET!! You'll totally dig it. Though I'm curious...do you skate?";

		}
  else if (primeInt == 78)
		{
                Char1name.text = "You";
                Char1speech.text = "Uhhh...";
                Char2name.text = "";
                Char2speech.text = "";

		}
  else if (primeInt == 79)
		{
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "You know what, don't sweat it pro or no you'll have the best time bro.";

		}

else if (primeInt == 80)
		{
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Joey";
                Char2speech.text = "WAIT!! THAT RHYMED!!!";

		}

        else if (primeInt == 81)
		{
                Char1name.text = "You";
                Char1speech.text = "It sure did...";
                Char2name.text = "";
                Char2speech.text = "";

// Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
           NextScene2Button.SetActive(true);
		}
        

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Uh...I'm actually just a little lost...";
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
        Char1speech.text = "I was actually looking for you! \nYou're Joey right?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


	// second story choice for scene1a

	public void Choice2aFunt()
	{ 
		Char1name.text = "YOU";
		Char1speech.text = "I believe I gave you my phone number that night?";
		Char2name.text = "";
		Char2name.text = "";
		primeInt = 49;
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
	public void Choice2bFunct()
	{
		Char1name.text = "YOU";
		Char1speech.text = "I had a really good time with you that night!";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 69;
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
public void Choice3Funct()
	{
		Char1name.text = "YOU";
		Char1speech.text = "Uhhh..Wait!!";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 99;
		Choice2a.SetActive(false);
		Choice3.SetActive(false);
        NextScene1Button.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}


    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene1b");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3a");
    }
/*
    public void SceneChange3()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void SceneChange4()
    {
        SceneManager.LoadScene("Scene2b");
    }
*/

}







