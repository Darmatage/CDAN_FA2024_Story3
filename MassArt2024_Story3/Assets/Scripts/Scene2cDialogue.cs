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
    public GameObject Choice3a;
    public GameObject Choice3b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    //public GameObject NextScene3Button;
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
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        //NextScene3Button.SetActive(false);
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
            Char1speech.text = "[Nice park. Now, where is the suspect, Vanessa?]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "You";
            Char1speech.text = "[Ah, just follow the crowd!]";
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
            Char1name.text = "You";
            Char1speech.text = "Yep! I think I'll take a poster too!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "This is cool!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
    
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Wow thanks, stranger!";
            //gameHandler.AddPlayerStat(1);
        }

         else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I love giving out items to my fans!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 9)
        {
            ArtChar1b.SetActive(false);
            ArtChar1a.SetActive(true);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Have you heard my new single yet?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 10)
        {
            Char1name.text = "You";
            Char1speech.text = "Umm... Was it...";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }



          //after choice 1a:
        else if (primeInt == 20)
        {
         GameHandler.VanessaLove += 1;   
            ArtChar1b.SetActive(true);
            ArtChar1a.SetActive(false);    
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Oh joy!";
        }

         else if (primeInt == 21)
        {
            ArtChar1b.SetActive(true);
            ArtChar1a.SetActive(false);    
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Did you like it?";
        }

       else if (primeInt == 22)
        {  
            Char1name.text = "YOU";
            Char1speech.text = "Yes. it was very...loud.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 23)
        {  
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I'm so glad you liked it!";
        }

        else if (primeInt == 24)
        {  
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I hope..";
        }


       
        else if (primeInt == 25)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Would you like to come to my concert this friday?";
        }

        else if (primeInt == 26)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "It should be spectacular!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
          else if (primeInt == 27)
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
         
        //after choice 1b:
        else if (primeInt == 30)
        {
            GameHandler.VanessaLove -= 1;
            ArtChar1c.SetActive(true);
            ArtChar1b.SetActive(false);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "No, that's not a song I created.";
        }

        else if (primeInt == 31)
        {
            ArtChar1c.SetActive(true);
            ArtChar1b.SetActive(false);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I don't even think that is a song that exists...";
        }

         else if (primeInt == 32)
        {
            ArtChar1c.SetActive(true);
            ArtChar1b.SetActive(false);   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "...";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Are you even familiar with my music?";
        }

        else if (primeInt == 34)
        {
            Char1name.text = "You";
            Char1speech.text = "Oh! Uh...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }

//after choice 2a:
         else if (primeInt == 40)
        {
          ArtChar1c.SetActive(false);
         ArtChar1a.SetActive(true);  
         GameHandler.VanessaLove += 1; 
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
            Char2speech.text = "Introducing people to my music is one of my favorite things to do!";
        }

        else if (primeInt == 42)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Are you a fan of pop?";
        }

        else if (primeInt == 43)
        {
            
            Char1name.text = "YOU";
            Char1speech.text = "Sure am!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 44)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "So it's settled!";
        }

        else if (primeInt == 45)
        {
            
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Would you like to come to my concert this friday?";
        }

        else if (primeInt == 46)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "It should be spectacular!";
        }
   
        else if (primeInt == 47)
        {
            Char1name.text = "You";
            Char1speech.text = "Lemme think about it...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }
         

//after choice 2b:         
         else if (primeInt == 50)
        {
            GameHandler.VanessaLove -= 1; 
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "You're weirding me out, stranger...";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice3a.SetActive(true); // function Choice3aFunct()
            Choice3b.SetActive(true); // function Choice3bFunct()
        }


//after choice 3a:
        else if (primeInt == 60)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Fair enough, I get that a lot.";
           
        }

        else if (primeInt == 61)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I welcome you to join my concert this friday.";
        }

        else if (primeInt == 62)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "It should be fun.";
            //hide next button, show scene change buttons:
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
        }

//choice 3b:
          else if (primeInt == 70)
        {
            GameHandler.VanessaLove -= 1; 
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "...";
        }

        else if (primeInt == 71)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Well, I don't know why you lied this far, however I appreciate your honesty.";
        }

         else if (primeInt == 72)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I do have to make time for my real fans though.";
        }

         else if (primeInt == 73)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "See you around, stranger!";
            //hide next button, show abandon suspect button
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
        Char1speech.text = "Melody Magic?";
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
        Char1speech.text = "Alien-Song...?- Uh I mean- [Crap.]";
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
        Char1speech.text = "To be honest, not really. It was just a guess.";
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
        Char1speech.text = "Sure am! Haha...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 49;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

     public void Choice3aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Who's weird? You're weird...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 59;
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void Choice3bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Yeah, I actually don't know your music. I'm sorry.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 69;
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    //go to concert
    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene3c");
    }

    //abandon file
    public void SceneChange2()
    {
        GameHandler.VanessaAbandoned = true;
        SceneManager.LoadScene("Scene1b");
    }


}