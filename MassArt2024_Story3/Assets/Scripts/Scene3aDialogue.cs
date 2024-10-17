using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour{

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
            Char1name.text = "You";
            Char1speech.text = "Woah..";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Isn't it the best??";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "You";
            Char1speech.text = "When you said it'd be cool, I wasn't actually expecting it to be...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1b.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Hey! You doubt my judgement?";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Says the guy who said radical in the car unironically.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1a.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "It is STILL a socially accepted slang!!";
        }
else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I will CONTINUE to bring it back.";
        }
else if (primeInt == 9)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Sure...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1d.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Well, wanna skate?";
 
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
            Char2name.text = "Joey";
            Char2speech.text = "Who says you're gonna fall?";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "You";
            Char1speech.text = "Who says I won't on purpose?";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt=39;
        }


        // after choice 1b
       
       else if (primeInt == 30)
         {
            ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "LET'S DO IT!!!";
            primeInt=39;
        }
         

	//after both choices:

      else if (primeInt == 40)
        {
            ArtChar1b.SetActive(false);
            ArtChar1c.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "[later]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 41)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "Oh man- I'm never getting on wheels again";
            Char2name.text = "";
            Char2speech.text = "";
        }

         else if (primeInt == 42)
        {	
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "*laughing* Did you seriously think that jumping on it was a good idea??";
        }

        else if (primeInt == 43)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "well, EXCUSE me for thinking it would be like a fun blast-off.";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 44)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "I can already feel it bruising...";
            Char2name.text = "";
            Char2speech.text = "";
		
        }
	    else if (primeInt == 45)
        {	
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Well! Something to remember the experience by.";
        }
	    else if (primeInt == 46)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "Yeah- Till it heals...";
            Char2name.text = "";
            Char2speech.text = "";
        }
       else if (primeInt == 47)
        {		
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I guess we'll have to hang out again!";
        }
        else if (primeInt == 48)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "Yeah...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 49)
        {	
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Hey! Wanna see this new trick I'm working on?";
        }
       else if (primeInt == 50)
        {	
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I think I'm on the verge of CRUSHING it.";
        }
        else if (primeInt == 51)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "More like crushing some poor kid who gets in the way.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 52)
        {	
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Har. Har. You'll see.";
        }
         else if (primeInt == 53)
        {	
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Alright. Be ready to eat your words!!!";
        }
        else if (primeInt == 54)
        {	
			ArtChar1b.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "Oh boy-";
            Char2name.text = "";
            Char2speech.text = "";
        }

         else if (primeInt == 55)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "[Oh! he's actually not bad...]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 56)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "[I hope he sees that guy that just dropped in- Uh oh.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
         else if (primeInt == 57)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "JOEY!! LOOK OUT FOR THE-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 58)
        {	
			
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "AGHHH!!!";
        }
			// Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(true);
            allowSpace = (true);
            NextScene1Button.SetActive(false);
        
         

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    
    public void Choice1aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Only if it means means you'll catch me when I fall.";
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
        Char1name.text = "You";
        Char1speech.text = "Hell yeah!!";
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
        SceneManager.LoadScene("Scene3b");
    }
}