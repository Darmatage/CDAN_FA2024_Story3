using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour
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
    public GameObject ArtBG2;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject Choice3;
    public GameObject Choice4a;
    public GameObject Choice4b;
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
        ArtChar1f.SetActive(false);
        ArtChar1g.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3.SetActive(false);
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
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
			ArtChar1g.SetActive(true);
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
            ArtChar1g.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "It is STILL a socially accepted slang!!";
        }
else if (primeInt == 8)
        {
            ArtChar1d.SetActive(false);
            ArtChar1b.SetActive(true);
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
            ArtChar1b.SetActive(false);
            ArtChar1g.SetActive(true);
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
            ArtChar1g.SetActive(false);
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
            ArtChar1g.SetActive(false);
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
			ArtChar1b.SetActive(false);
            ArtChar1g.SetActive(true);
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
            ArtChar1g.SetActive(false);
            ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I guess we'll have to hang out again!";
        }
        else if (primeInt == 48)
        {	
			ArtChar1b.SetActive(false);
            ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Yeah...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 49)
        {	
			ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
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
			ArtChar1b.SetActive(false);
            ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Har. Har. You'll see.";
        }
         else if (primeInt == 53)
        {	
			ArtChar1g.SetActive(false);
            ArtChar1b.SetActive(true);
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
            Char2speech.text = "AAAGGGHHHH!!!";
        }
       
        else if (primeInt == 59)
        {	
            DialogueDisplay.SetActive(false);
		    ArtBG2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 60)
        {	
            DialogueDisplay.SetActive(true);
		    
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "It's not what it looks like! I can explain!!";
        }
else if (primeInt == 61)
        {	
			
            Char1name.text = "You";
            Char1speech.text = "[Everyone could see he's a monster...Now's my chance.] \nUhh...";
            Char2name.text = "";
            Char2speech.text = "";

             // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }
        
        //after choice2a
else if (primeInt == 70)

        {	
            ArtBG2.SetActive(false);
            ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "W...What..?";
        }

        else if (primeInt == 71)
        {	
            
            Char1name.text = "You";
            Char1speech.text = "You are in violation of impersonating a human being.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 72)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "I'm taking you in.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 73)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I thought we were friends...you lied to me.";
        }
        else if (primeInt == 74)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "And you lied to the law. Let's go buddy.";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = (false);
            NextScene1Button.SetActive(true);
        }
 
 //after choice 2b
else if (primeInt == 80)
        {	
            ArtBG2.SetActive(false);
         ArtChar1a.SetActive(false);
         ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Thanks...It means a lot...";
        }
else if (primeInt == 81)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Sure...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 82)
        {	
         ArtChar1d.SetActive(false);
         ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Luckily I don't think anyone saw...";
        }

        else if (primeInt == 83)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Except me...";
            Char2name.text = "";
            Char2speech.text = "";
        }
         else if (primeInt == 84)
        {	
         ArtChar1a.SetActive(false);
         ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Right...Cat's out of the bag..";
        }
          else if (primeInt == 85)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "I don't think It was really in the bag to begin with...";
            Char2name.text = "";
            Char2speech.text = "";
        }

          else if (primeInt == 86)
        {	
         ArtChar1d.SetActive(false);
         ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "What?";
        }
          else if (primeInt == 87)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Nothing.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 88)
        {	
         ArtChar1a.SetActive(false);
         ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "*sigh* It's just...hard. I just want to be normal.";
        }
        else if (primeInt == 89)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I just want to work my job and go to the skatepark like everyone else.";
        }
        else if (primeInt == 90)
        {	
         ArtChar1d.SetActive(false);
         ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "*laughs* You know why I took up skating? No broken bones here.";
        }
        else if (primeInt == 91)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "*laughs*";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 92)
        {	
         ArtChar1g.SetActive(false);
         ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "It's true!";
        }
        else if (primeInt == 93)
        {	
         ArtChar1b.SetActive(false);
         ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "...";
        }
        else if (primeInt == 94)
        {	
         ArtChar1a.SetActive(false);
         ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Thank you for uh...understanding..";
        }
        else if (primeInt == 95)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Of course...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 96)
        {	
         ArtChar1f.SetActive(false);
         ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I hope we can still be friends after this...";
        }
        else if (primeInt == 97)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";

            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice3.SetActive(true); // function Choice3Funct()
        }
			
            //after choice3
else if (primeInt == 100)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "of course, did you think I'm gonna ditch you becuase you're a little more gelatinous than most?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 101)
        {	
         ArtChar1d.SetActive(false);
         ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "*laughs* You can never tell. A lot of people dislike Jell-O.";
        }
            else if (primeInt == 102)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "News to me.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 103)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Well, I guess this means you'll be forced to learn to skate then.";
        }
        else if (primeInt == 104)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Is it too late to change my mind?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 105)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "*laughs* Yes.";
        }
        else if (primeInt == 106)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Darn.";
            Char2name.text = "";
            Char2speech.text = "";

             // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice4a.SetActive(true); // function Choice4aFunct()
            Choice4b.SetActive(true); // function Choice4bFunct()
        }

        //after choice 4a
else if (primeInt == 130)
        {	
         ArtChar1g.SetActive(false);
         ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I don't wanna keep you! You must have work deadlines and all.";
        }
        else if (primeInt == 131)
        {	
         ArtChar1d.SetActive(false);
         ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Janitors don't really have to worry about that stuff.";
        }
        else if (primeInt == 132)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "Deadlines can wait. I'm focused on more important things.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 133)
        {	
         ArtChar1f.SetActive(false);
         ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Like?";
        }
        else if (primeInt == 134)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "You.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 135)
        {	
         ArtChar1a.SetActive(false);
         ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "O-Oh! What??";
        }
        else if (primeInt == 136)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "You've made a total mess of my heart! But- maybe you could fix that?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 137)
        {	
         ArtChar1c.SetActive(false);
         ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Well...If anyone is qualified for that...it's me.";
        }
        else if (primeInt == 138)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "My thoughts exactly.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 139)
        {	
         ArtChar1f.SetActive(false);
         ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Radical.";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = (false);
            NextScene2Button.SetActive(true);
        }

//after choice 4a

else if (primeInt == 150)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I guess a janitor never really understands that stuff.";
        }
        else if (primeInt == 151)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Stains and spills don't really have deadlies.";
        }
else if (primeInt == 152)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "*laughs* Maybe I should become a janitor.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 153)
        {	
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "I have a feeling you'd be good at it.";
        }
        else if (primeInt == 154)
        {	
         
            Char1name.text = "You";
            Char1speech.text = "I have a feeling you're right. See you around Joey.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 155)
        {	
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Joey";
            Char2speech.text = "Catch you later dude!";

            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = (false);
            NextScene3Button.SetActive(true);
        }
            
        
         

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
public void Choice2aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "[click!] Ah ha! You're under arrest monster!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 69;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "*You offer your hand, helping pull him up.*";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 79;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice3Funct()
    {
        Char1name.text = "You";
        Char1speech.text = "...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice2a.SetActive(false);
        Choice3.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice4aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Huh- I guess time really does fly when you're having fun.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 129;
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        Choice3.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice4bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Well...I guess I better start heading back, deadlines and all.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 149;
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void SceneChange1()
    {
        GameHandler.JoeyArrested = true;
        SceneManager.LoadScene("Scene1b");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("SceneLose_JoeyRomance");
    }
    public void SceneChange3()
    {
        GameHandler.JoeyAbandoned = true;
        SceneManager.LoadScene("Scene1b");
    }
}