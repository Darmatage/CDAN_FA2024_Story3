using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2cDialogue : MonoBehaviour
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
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject NextScene3Button;
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
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
            Char1name.text = "You";
            Char1speech.text = "(Nice park. Now, where is the suspect, Vanessa?)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "You";
            Char1speech.text = "(Ah, just follow the crowd!)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 4)
        {
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Hey stranger! Here to get my autograph? I'm giving out exclusive posters!";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Yep! I think I'll take a poster too!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I sure do love music! Especially since I'm an artist ahaha!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            ArtChar1b.SetActive(false);
            ArtChar1a.SetActive(true);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Who are your favorite bands?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 8)
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


        //after choice 1a:

        else if (primeInt == 30)
        {
            ArtChar1c.SetActive(true);
            ArtChar1b.SetActive(false);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Why do you want my autograph then?";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Are you familiar with my music?";
        }

        else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }
        else if (primeInt == 20)
        {
            ArtChar1b.SetActive(true);
            ArtChar1a.SetActive(false);    
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Oh joy!";
        }

        else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Would you like to come to my concert this friday?";
        }

        else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "It should be spectacular!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
          else if (primeInt == 23)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }  
         
         else if (primeInt == 40)
        {
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I appreciate your honesty stranger!";
        }

        else if (primeInt == 41)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Would you like to come to my concert this friday?";
        }

        else if (primeInt == 42)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "It should be spectacular!";
            nextButton.SetActive(false);
            allowSpace = false;

        }
 
        else if (primeInt == 43)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }  
         
        else if (primeInt == 50)
        {
            ArtChar1b.SetActive(false);
            ArtChar1d.SetActive(true);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Liar!";
        }
        else if (primeInt == 51)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Keep your story straight!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        else if (primeInt == 52)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene3Button.SetActive(true);
        }  



        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Oh, I love SO many bands!";
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
        Char1speech.text = "Um, I don't listen to a lot of music...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Not really but I recognize you.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 39;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "I am familiar with your music(LIE).";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 49;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    //go to concert
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene3c");
    }

    //abadon file
    public void SceneChange2()
    {
        GameHandler.VanessaAbandoned = true;
        SceneManager.LoadScene("Scene1b");
    }

}