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
    public GameObject ArtChar1h;

    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice3a;
    public GameObject Choice3b;
    public GameObject Choice4a;
    public GameObject Choice4b;
    public GameObject Choice5a;
   
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
        ArtChar1h.SetActive(false);

        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        Choice5a.SetActive(false);
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
            Char1speech.text = "[Alright, this should be the place.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "You";
            Char1speech.text = "[Man it's really crowded. I can barely even hear myself think!]";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "You";
            Char1speech.text = "[At least the music is good...]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
			ArtChar1e.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "[Wait a minute... That's my target!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "[Ok, ok. Act cool.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "You";
            Char1speech.text = "[Just approach the bar like a normal person!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 8)
        {
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Hi, is this seat taken?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Hm?";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Nah. Even if it was, I highly doubt the person would care";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "You";
            Char1speech.text = "Alright then... Um...";
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
            Char2name.text = "Lianhua";
            Char2speech.text = "Pfft! Was that supposed to be a pickup line?";
        }
        else if (primeInt == 21)
        {
            Char1name.text = "You";
            Char1speech.text = "N-No! It was a genuine question!";
            Char2name.text = "";
            Char2speech.text = "";
        }
         else if (primeInt == 22)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Uh huh...";
        }
         else if (primeInt == 23)
        {
            Char1name.text = "You";
            Char1speech.text = "Honest!";
            Char2name.text = "";
            Char2speech.text = "";
        }
         else if (primeInt == 24)
        {
            Char1name.text = "You";
            Char1speech.text = "This is my first time going to a club so...";
            Char2name.text = "";
            Char2speech.text = "";
        }
         else if (primeInt == 25)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Psh, relax! I was just teasing.";
        }
         else if (primeInt == 26)
        {
            Char1name.text = "You";
            Char1speech.text = "O-Oh...";
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
            Char2name.text = "Lianhua";
            Char2speech.text = "First time?";
        }
        else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Man, I bet you were the sheltered kid growing up.";
        }
        else if (primeInt == 32)
        {
            Char1name.text = "You";
            Char1speech.text = "I wouldn't say that. I just didn't have the time to go partying is all.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You're a bookworm then?";
        }
        else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Grades more important than a social life?";
        }
        else if (primeInt == 35)
        {
            Char1name.text = "You";
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
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 41)
        {
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "[Ah man! that was horrible!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
		else if (primeInt == 42)
        {
            Char1name.text = "You";
            Char1speech.text = "[Maybe I should quit while I still have some dignity left...]";
            Char2name.text = "";
            Char2speech.text = "";
        }
		else if (primeInt == 43)
        {
            Char1name.text = "You";
            Char1speech.text = "[How embarrassing!]";
            Char2name.text = "";
            Char2speech.text = ".";
			// Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            Choice2a.SetActive(true);
        }

    //after choice 2a
		else if (primeInt == 50)
		{
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "What do I recommend?";
        }
        else if (primeInt == 51)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I mean... How well can you hold your alcohol?";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice3a.SetActive(true); 
            Choice3b.SetActive(true);
        }


//after choice 3a
		else if (primeInt == 70)
		{
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Riiiiiight.";
        }
        else if (primeInt == 71)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I totally believe that...";
        }
        else if (primeInt == 72)
		{
            Char1name.text = "You";
            Char1speech.text = "Ehe...";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt=89;
        }

//after choice 3b
		else if (primeInt == 80)
		{
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I don't doubt that.";
		}
        else if (primeInt == 81)
		{
            Char1name.text = "You";
            Char1speech.text = "ah-";
            Char2name.text = "";
            Char2speech.text = "";
            primeInt=89;
		}

//after both choices 3a/3b:
	    else if (primeInt == 90)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Hm...";
        }
        else if (primeInt == 91)
        {
            ArtChar1e.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I know just the drink";
        }
        else if (primeInt == 92)
        {
            Char1name.text = "You";
            Char1speech.text = "[So far so good. Don't mess this up!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 93)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "So... What made you want to finally try out the club?";
        }
        else if (primeInt == 94)
        {
            Char1name.text = "You";
            Char1speech.text = "Huh? Me? Uh well...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 95)
        {
            Char1name.text = "You";
            Char1speech.text = "I guess I was just curious.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 96)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Just curious?";
        }
        else if (primeInt == 97)
        {
            ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Not in search of a potential partner or anything?";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice4a.SetActive(true);
            Choice4b.SetActive(true);
        }

//after choice 4a
		else if (primeInt == 110)
		{
            ArtChar1c.SetActive(false);
			ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "HAHA!";
        }
        else if (primeInt == 111)
		{
            ArtChar1d.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Wait, seriously??";
        }
        else if (primeInt == 112)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I was just joking.";
            primeInt=129;
        }

//after choice 4b
		else if (primeInt == 120)
		{
            ArtChar1c.SetActive(false);
			ArtChar1d.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "HAHA!";
		}
        else if (primeInt == 121)
		{
            ArtChar1d.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Relax, I was just joking.";
            primeInt=129;
		}

//after both choices 4a/4b:
	    else if (primeInt == 130)
        {
            ArtChar1h.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Anyways, here's your drink.";
        }
else if (primeInt == 131)
        {
            Char1name.text = "You";
            Char1speech.text = "Wow, what is this?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 132)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "It's a Blue Hawaiian Mocktail.";
        }
        else if (primeInt == 133)
        {
            ArtChar1h.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Don't worry, there's no alcohol in it.";
        }
        else if (primeInt == 134)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Wouldn't want to ruin your first night at the club with a hangover.";
        }
else if (primeInt == 135)
        {
            Char1name.text = "You";
            Char1speech.text = "Oh... Thank you.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 136)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Don't mention it.";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice5a.SetActive(true);
        }

//after choice 5a
		else if (primeInt == 140)
		{
            ArtChar1b.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Huh?";
        }
else if (primeInt == 141)
		{
            Char1name.text = "You";
            Char1speech.text = "I MEAN-!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 142)
		{
            Char1name.text = "You";
            Char1speech.text = "You seem like you know what you're doing, so I thought...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 143)
		{
            ArtChar1a.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Ohhhh, I get it.";
        }
else if (primeInt == 144)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You like me, don't you?";
        }
else if (primeInt == 145)
		{
            Char1name.text = "You";
            Char1speech.text = "Y-yeah, something like that...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 146)
		{
            ArtChar1c.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
        }
else if (primeInt == 147)
		{
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Alright.";
        }
else if (primeInt == 148)
		{
            Char1name.text = "You";
            Char1speech.text = "Huh?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 149)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I said alright.";
        }
else if (primeInt == 150)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Come back tomorrow and ask the bartender for Lianhua";
        }
else if (primeInt == 151)
		{
            Char1name.text = "You";
            Char1speech.text = "Lianhua?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 152)
		{
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "My name.";
        }
else if (primeInt == 153)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You'll know the rest from there.";
        }
        else if (primeInt == 154)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Anyways, it was nice meeting you.";
        }
        else if (primeInt == 155)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "But I have to go now.";
        }
        else if (primeInt == 156)
		{
            ArtChar1a.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "H-Hang on! Wait-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 157)
		{
            Char1name.text = "You";
            Char1speech.text = "Aaaaand he's gone...";
            Char2name.text = "";
            Char2speech.text = "";
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
        Char1name.text = "You";
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
        Char1name.text = "You";
        Char1speech.text = "This is my first time at a club.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 29;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // second story choice for scene2b

    public void Choice2aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Um- What type of drink do you recommend?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 49;
        Choice2a.SetActive(false);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // third story choice for scene2b

	public void Choice3aFunt()
	{ 
		Char1name.text = "You";
		Char1speech.text = "Oh I drink alcohol like water!";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 69;
		Choice3a.SetActive(false);
		Choice3b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
	public void Choice3bFunct()
	{
		Char1name.text = "You";
		Char1speech.text = "I'd say I'm pretty much a lightweight.";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 79;
		Choice3a.SetActive(false);
		Choice3b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

// fourth story choice for scene2b

	public void Choice4aFunt()
	{ 
		Char1name.text = "You";
		Char1speech.text = "How did you know?!";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 109;
		Choice4a.SetActive(false);
		Choice4b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}
	public void Choice4bFunct()
	{
		Char1name.text = "You";
		Char1speech.text = "N-NO!!";
		Char2name.text = "";
		Char2speech.text = "";
		primeInt = 119;
		Choice4a.SetActive(false);
		Choice4b.SetActive(false);
		nextButton.SetActive(true);
		allowSpace = true;
	}

// fifth story choice for scene2b

    public void Choice5aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Can I see you again?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 139;
        Choice5a.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        GameHandler.LianhuaAbandoned = true;
        SceneManager.LoadScene("Scene1b");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene3b");
    }
}