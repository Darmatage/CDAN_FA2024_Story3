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
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject Choice3a;
    public GameObject Choice3b;
    public GameObject Choice4a;
    public GameObject Choice4b;
    public GameObject Choice5a;
    public GameObject Choice5b;
    public GameObject Choice6a;
    public GameObject Choice6b;

    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject NextScene3Button;
    public GameObject NextScene4Button;
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
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        Choice5a.SetActive(false);
        Choice5b.SetActive(false);
        Choice6a.SetActive(false);
        Choice6b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
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
            Char1speech.text = "[OK. I'm at the club. The bartender said Lianhua is in the back.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "You";
            Char1speech.text = "[Huh. Even their private rooms are filled with neon lights.]";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You actually came.";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Color me surprised.";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "Well it would be rude of me to stand you up after I literally asked to see you again.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
			ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true); // turn on bored
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Yeah, that's true.";
        }
 else if (primeInt == 8)
        {
            Char1name.text = "You";
            Char1speech.text = "Um...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 9)
        {
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 10)
        {
            Char1name.text = "You";
            Char1speech.text = "[Come on dumbass! Say something!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 11)
        {
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "So, Lianhua, what do you do for a living?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I'm a bartender.";
        }
else if (primeInt == 13)
        {
            Char1name.text = "You";
            Char1speech.text = "Really?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 14)
        {
            Char1name.text = "You";
            Char1speech.text = "Then shouldn't you be...?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Working?";
        }
else if (primeInt == 16)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I only work on weekends.";
        }
else if (primeInt == 17)
        {
            Char1name.text = "You";
            Char1speech.text = "Huh... Where do you work? I don't recall ever seeing you around here.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 18)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
        }
else if (primeInt == 19)
        {
            ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Ha... you caught me.";
        }
else if (primeInt == 20)
        {
            Char1name.text = "You";
            Char1speech.text = "Huh?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 21)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I'm actually the owner of this club.";
        }
else if (primeInt == 22)
        {
            Char1name.text = "You";
            Char1speech.text = "HUUUHHH?!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 23)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Is it really that surprising?";
        }
else if (primeInt == 24)
        {
            Char1name.text = "You";
            Char1speech.text = "N-No! It's just I didn't expect to meet the owner of this place on my first visit!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 25)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Haha, Lucky you!";
        }
else if (primeInt == 26)
        {
            Char1name.text = "You";
            Char1speech.text = "What made you open a club?";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 27)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Funny story actually.";
        }
else if (primeInt == 28)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I opened a restaurant at first.";
        }
else if (primeInt == 29)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "But then it kinda evolved from there.";
        }
else if (primeInt == 30)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I never really intended for it to be a club. It just happened.";
        }
else if (primeInt == 31)
        {
            Char1name.text = "You";
            Char1speech.text = "Wow...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 32)
        {
            Char1name.text = "You";
            Char1speech.text = "That's a major change.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Yeah, time's changed.";
        }
else if (primeInt == 34)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I'm just happy to provide some people with a safe space.";
        }
else if (primeInt == 35)
        {
            Char1name.text = "You";
            Char1speech.text = "That's... actually really nice.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 36)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I try.";
        }


 else if (primeInt == 37)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "So, what do you do for a living?";
        }
 else if (primeInt == 38)
        {
            Char1name.text = "You";
            Char1speech.text = "Oh, I work for the... police department.";
            Char2name.text = "";
            Char2speech.text = "";
        }
 else if (primeInt == 39)
        {
            ArtChar1b.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Are you an officer?";
        }
 else if (primeInt == 40)
        {
            Char1name.text = "You";
            Char1speech.text = "No more like a detective.";
            Char2name.text = "";
            Char2speech.text = "";
        }
 		else if (primeInt == 41)
        {
			ArtChar1a.SetActive(false);
			ArtChar1c.SetActive(true); //turn on flirty
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Damn, got any crazy cases you can share?";
        }
        else if (primeInt == 42)
        {
            Char1name.text = "You";
            Char1speech.text = "Hmmm...";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off the "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }

        // after choice 1a 50
        else if (primeInt == 50)
        {
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 51)
        {
            Char1name.text = "You";
            Char1speech.text = "[Shoot! I totally forgot this is one of my first few cases!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 52)
        {
            Char1name.text = "You";
            Char1speech.text = "[I don't have any stories to share!]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 53)
        {
            Char1name.text = "You";
            Char1speech.text = "[Too late now- I'll just referance my other cases.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 54)
        {
            Char1name.text = "You";
            Char1speech.text = "I was in hot pursuit of this one criminal.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 55)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Uh huh.";
        }
        else if (primeInt == 56)
        {
            Char1name.text = "You";
            Char1speech.text = "I almost had him!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 57)
        {
            Char1name.text = "You";
            Char1speech.text = "But then he slipped out of my grasp.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 58)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "What a slimy fellow...";
        }
        else if (primeInt == 59)
        {
            Char1name.text = "You";
            Char1speech.text = "Yeah! He was really slimy!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 60)
        {
            ArtChar1a.SetActive(false);
			ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
        }
        else if (primeInt == 61)
        {
            Char1name.text = "You";
            Char1speech.text = "[Was that too boring?]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 62)
        {
            Char1name.text = "You";
            Char1speech.text = "[Let's try a different story.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 63)
        {
            Char1name.text = "You";
            Char1speech.text = "Then there was this, uh, girl!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 64)
        {
            Char1name.text = "You";
            Char1speech.text = "Her case was a bit more difficult.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 65)
        {
            Char1name.text = "You";
            Char1speech.text = "But I managed, and brought her to justice!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 66)
        {
            Char1name.text = "You";
            Char1speech.text = "Shame that she was, um, this popular singer.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 67)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Popular singer huh?";
        }
        else if (primeInt == 68)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I bet she was out of this world.";
        }
        else if (primeInt == 69)
        {
            Char1name.text = "You";
            Char1speech.text = "Mhm, her music was quite alien to me though-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 70)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Alien?";
        }
        else if (primeInt == 71)
        {
            Char1name.text = "You";
            Char1speech.text = "Yeah! I've never heard anything like it before.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 72)
        {
            Char1name.text = "You";
            Char1speech.text = "She even looked a bit weird too.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 73)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Like she was an alien?";
        }
        else if (primeInt == 74)
        {
            Char1name.text = "You";
            Char1speech.text = "No actually, it turns out she WAS an alien.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 75)
        {
            Char1name.text = "You";
            Char1speech.text = "That's why I had to arrest her-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        
        else if (primeInt == 76)
        {
			ArtChar1c.SetActive(false);
			ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Oh, really...";
        }
		else if (primeInt == 77)
        {
            Char1name.text = "You";
            Char1speech.text = "AH- Wait! I can explain!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 78)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "What? That you hunt monsters?";
        }
        else if (primeInt == 79)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "No thanks, I think you said enough.";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        // after choice 1b
        else if (primeInt == 90)
        {
            ArtChar1c.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Aw, that's a shame.";
        }
else if (primeInt == 91)
        {
            Char1name.text = "You";
            Char1speech.text = "Yeah...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 92)
        {
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 93)
        {
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You know, you're kinda bad at this.";
        }
else if (primeInt == 94)
        {
            Char1name.text = "You";
            Char1speech.text = "H-Huh?!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 95)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Making conversation, I mean.";
        }
else if (primeInt == 96)
        {
            Char1name.text = "You";
            Char1speech.text = "Oh! Yeah! Totally!";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 97)
        {
            Char1name.text = "You";
            Char1speech.text = "[Phew, I thought he figured me out for a second there...]";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 98)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Anyways, why did you ask to see me again?";
        }
else if (primeInt == 99)
        {
            Char1name.text = "You";
            Char1speech.text = "Well... I just wanted to get to know you more.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 100)
        {
            Char1name.text = "You";
            Char1speech.text = "I wasn't lying when I said I found you interesting.";
            Char2name.text = "";
            Char2speech.text = "";
        }
else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
        }
else if (primeInt == 102)
        {
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Well you're doing a bad job at it.";
        }
else if (primeInt == 103)
        {
            Char1name.text = "You";
            Char1speech.text = "Wh- Ok smartass.";
            Char2name.text = "";
            Char2speech.text = "";
             // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); 
            Choice2b.SetActive(true);
        }

//after choice 2a
		else if (primeInt == 110)
		{
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Triangle. My turn, do you like men?";
        }
        else if (primeInt == 111)
		{
            Char1name.text = "You";
            Char1speech.text = "WHA-?!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 112)
		{
            ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Haha! Kidding!";
        }
        else if (primeInt == 113)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "It's actually circles.";
        }
        else if (primeInt == 114)
		{
            Char1name.text = "You";
            Char1speech.text = "That's...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 115)
		{
            Char1name.text = "You";
            Char1speech.text = "Ok...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 116)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Alright, alright, I'll stop now.";
        }
        else if (primeInt == 117)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "It's blue.";
        }
        else if (primeInt == 118)
		{
            Char1name.text = "You";
            Char1speech.text = "Really? Mine too!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 119)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Ha, no way.";
        }
        else if (primeInt == 120)
		{
            Char1name.text = "You";
            Char1speech.text = "Honest! It's a popular color after all.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 121)
		{
            ArtChar1b.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Wow, are you calling me unoriginal?";
        }
        else if (primeInt == 122)
		{
            Char1name.text = "You";
            Char1speech.text = "No! I didn't mean it like that-";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 123)
		{
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 124)
		{
            Char1name.text = "You";
            Char1speech.text = "You're messing with me again, aren't you?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 125)
		{
            ArtChar1e.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Guilty as charged~";
            primeInt=149;
        }
       
//after choice 2b
		else if (primeInt == 130)
		{
            ArtChar1e.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Pfft, that's the best you got?";
		}
        else if (primeInt == 131)
		{
            Char1name.text = "You";
            Char1speech.text = "Come on, just answer the question.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 132)
		{
            ArtChar1c.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Alright, alright.";
		}
        else if (primeInt == 133)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I guess birds.";
		}
        else if (primeInt == 134)
		{
            Char1name.text = "You";
            Char1speech.text = "Any in particular?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 135)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Not really. They're all interesting in their own way.";
		}
        else if (primeInt == 136)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "What about you?";
		}
        else if (primeInt == 137)
		{
            Char1name.text = "You";
            Char1speech.text = "Hmm...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 138)
		{
            Char1name.text = "You";
            Char1speech.text = "Definitely foxes!";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 139)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Foxes?";
		}
        else if (primeInt == 140)
		{
            Char1name.text = "You";
            Char1speech.text = "Mhm! I think they're cute!";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 141)
		{
            Char1name.text = "You";
            Char1speech.text = "And super fluffy too!";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 142)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I see...";
            primeInt=149;
		}

//after both choices 2a/2b:
	    else if (primeInt == 150)
        {
            Char1name.text = "You";
            Char1speech.text = "[He seems a bit more relaxed now.]";
            Char2name.text = "";
            Char2speech.text = "";
        }
    else if (primeInt == 151)
        {
            Char1name.text = "You";
            Char1speech.text = "[This is my chance...]";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice3a.SetActive(true); 
            Choice3b.SetActive(true);
        }

//after choice 3a
		else if (primeInt == 160)
		{
            ArtChar1c.SetActive(false);
            ArtChar1b.SetActive(false);
			ArtChar1f.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
		}
        else if (primeInt == 161)
		{
            Char1name.text = "You";
            Char1speech.text = "You are in violation of impersonating a human being. I'm taking you in.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 162)
		{
            ArtChar1f.SetActive(false);
			ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You seem to be forgetting a major detail, <i>Detective.<i>";
		}
        else if (primeInt == 163)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "The door is locked.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
		}
        

//after choice 3b
		else if (primeInt == 170)
		{
            ArtChar1c.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Nah, they're still terrible.";
		}
        else if (primeInt == 171)
		{
            Char1name.text = "You";
            Char1speech.text = "Oh come on!";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 172)
		{
            Char1name.text = "You";
            Char1speech.text = "As if you're any better than me.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 173)
		{
            ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I'd like to think I'm more skilled at conversation than you.";
		}
        else if (primeInt == 174)
		{
            ArtChar1c.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Sure, sure.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 175)
		{
            Char1name.text = "You";
            Char1speech.text = "You just sit in this room and hide from the world, don't you?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 176)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Maybe.";
		}
        else if (primeInt == 177)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "But it's also where I go to recharge when things get too loud out there.";
		}
        else if (primeInt == 178)
		{
            Char1name.text = "You";
            Char1speech.text = "I can see the appeal. It's pretty peaceful in here.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 179)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Exactly. Sometimes you just need a moment away from all the chaos, you know?";
		}
        else if (primeInt == 180)
		{
            Char1name.text = "You";
            Char1speech.text = "Yeah, I totally get that.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 181)
		{
            Char1name.text = "You";
            Char1speech.text = "So... what do you usually do when you're here alone?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 182)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Well, it depends.";
		}
        else if (primeInt == 183)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Sometimes I'll read, or just sit and think.";
		}
        else if (primeInt == 184)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "It's kind of nice to just exist for a bit.";
		}
        else if (primeInt == 185)
		{
            Char1name.text = "You";
            Char1speech.text = "Yeah, I guess everyone needs that.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 186)
		{
            Char1name.text = "You";
            Char1speech.text = "What about today? What's on the agenda?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 187)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Hm, today's a bit different. I've got something planned.";
		}
        else if (primeInt == 188)
		{
            Char1name.text = "You";
            Char1speech.text = "Oh?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 189)
		{
            Char1name.text = "You";
            Char1speech.text = "Now you've got me curious.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 190)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "It's not anything big.";
		}
        else if (primeInt == 191)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "But I think you'll like it.";
		}
        else if (primeInt == 192)
		{
            Char1name.text = "You";
            Char1speech.text = "Alright, what is it?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 193)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You'll see.";
		}
        else if (primeInt == 194)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "But first, you have to promise me you won't freak out.";
		}
        else if (primeInt == 195)
		{
            Char1name.text = "You";
            Char1speech.text = "That sounds suspicious already.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 196)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "No tricks, I promise.";
		}
        else if (primeInt == 197)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Just... close your eyes.";
		}
        else if (primeInt == 198)
		{
            Char1name.text = "You";
            Char1speech.text = "Ok...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        //Reveals his true form
        else if (primeInt == 199)
		{
            Char1name.text = "You";
            Char1speech.text = "Oh my god...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice4a.SetActive(true); 
            Choice4b.SetActive(true);
		}
        
//after choice 4a
		else if (primeInt == 210)
		{
            ArtChar1b.SetActive(false);
			ArtChar1g.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "What did you just say?...";
		}
        else if (primeInt == 211)
		{
            Char1name.text = "You";
            Char1speech.text = "Um...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 212)
		{
            Char1name.text = "You";
            Char1speech.text = "You're a... Kitsune?...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 213)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
		}
        else if (primeInt == 214)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "How unfortunate.";
		}
        else if (primeInt == 215)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "And to think I was starting to like you.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
		}

//after choice 4b
		else if (primeInt == 220)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Pfft! Haha!";
		}
        else if (primeInt == 221)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You're an interesting human!";
		}
        else if (primeInt == 222)
		{
            Char1name.text = "You";
            Char1speech.text = "In a good way, right?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 223)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Pfft- Okay look.";
		}
        else if (primeInt == 224)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I know you're a monster hunter.";
		}
        else if (primeInt == 225)
		{
            Char1name.text = "You";
            Char1speech.text = "!?!";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 226)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "So here's a tip.";
		}
        else if (primeInt == 227)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "If you wanna arrest me,";
		}
        else if (primeInt == 228)
		{
            ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I might let you~";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice5a.SetActive(true); 
            Choice5b.SetActive(true);
		}
        
//after choice 5a
		else if (primeInt == 230)
		{
            Char1name.text = "You";
            Char1speech.text = "You really didn't put up a fight.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 231)
		{
            Char1name.text = "You";
            Char1speech.text = "With me handcuffing you and all...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 232)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I'm a man of my word.";
		}
        else if (primeInt == 233)
		{
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
		}


//after choice 5b
		else if (primeInt == 240)
		{
            Char1name.text = "You";
            Char1speech.text = "I can't do that...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 241)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Oh~?";
		}
        else if (primeInt == 242)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Why the sudden change in heart?";
		}
        else if (primeInt == 243)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I'm giving you an easy way out after all.";
		}
        else if (primeInt == 244)
		{
            ArtChar1c.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "But you didn't do anything wrong...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 245)
		{
            Char1name.text = "You";
            Char1speech.text = "I'll feel guilty if I do...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 246)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Hmm...";
		}
        else if (primeInt == 247)
		{
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Debatable.";
		}
        else if (primeInt == 248)
		{
            Char1name.text = "You";
            Char1speech.text = "H-Huh?!";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 249)
		{
            Char1name.text = "You";
            Char1speech.text = "You want to get arrested or something??";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 250)
		{
            ArtChar1e.SetActive(false);
			ArtChar1a.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Not what I meant.";
		}
        else if (primeInt == 251)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "What I mean is that not every monster is innocent.";
		}
        else if (primeInt == 252)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "I would know. I'm one of them.";
		}
        else if (primeInt == 253)
		{
            Char1name.text = "You";
            Char1speech.text = "But you're just minding your own business.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 254)
		{
            Char1name.text = "You";
            Char1speech.text = "It was me who essentially barged into your life, trying to arrest you for just existing...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 255)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
		}
         else if (primeInt == 256)
		{
            ArtChar1a.SetActive(false);
			ArtChar1e.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "<i>Sigh</i>";
		}
         else if (primeInt == 257)
		{
            ArtChar1e.SetActive(false);
			ArtChar1b.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "You are indeed an interesting human.";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice6a.SetActive(true); 
            Choice6b.SetActive(true);
		}

//after choice 6a
		else if (primeInt == 260)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Because it's true~";
		}
        else if (primeInt == 261)
		{
            Char1name.text = "You";
            Char1speech.text = "Hm";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 262)
		{
            Char1name.text = "You";
            Char1speech.text = "Debatable.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 263)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Pfft! Using my words against me now are we?";
		}
        else if (primeInt == 264)
		{
            Char1name.text = "You";
            Char1speech.text = "Consider this payback for putting me through the wringer.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 265)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Alright alright, my bad~";
		}
        else if (primeInt == 266)
		{
            Char1name.text = "You";
            Char1speech.text = "Haha.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 267)
		{
            Char1name.text = "You";
            Char1speech.text = "I'll see you around?";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 268)
		{
            ArtChar1b.SetActive(false);
			ArtChar1c.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "With your line of work? I hope not.";
		}
        else if (primeInt == 269)
		{
            Char1name.text = "You";
            Char1speech.text = "Haha! Fair enough.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene4Button.SetActive(true);
		}

//after choice 6b
		else if (primeInt == 280)
		{
            Char1name.text = "You";
            Char1speech.text = "You know, now that I think about it, I never gave you my name.";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 281)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Guess not...";
		}
        else if (primeInt == 282)
		{
            Char1name.text = "You";
            Char1speech.text = "Don't worry though, you can just call me 'yours'~";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 283)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
		}
        else if (primeInt == 284)
		{
            Char1name.text = "You";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
		}
        else if (primeInt == 285)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "...";
		}
        else if (primeInt == 286)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Well damn!!";
		}
        else if (primeInt == 287)
		{
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Lianhua";
            Char2speech.text = "Ok! Take me out to dinner first!";
             nextButton.SetActive(false);
            allowSpace = (false);
            NextScene3Button.SetActive(true);
		}






        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        ArtChar1c.SetActive(false);
		ArtChar1a.SetActive(true);
        Char1name.text = "You";
        Char1speech.text = "Well there was this one time...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 49;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "I got nothing at the moment.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 89;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // second story choice for scene3b

public void Choice2aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "What's your favorite color?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 109;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "What's your favorite animal?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 129;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

// third story choice for scene3b

public void Choice3aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "You're under arrest monster!!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 159;
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice3bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "So, did I convince you of my <i>amazing</i> social skills?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 169;
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


// fourth story choice for scene3b

public void Choice4aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "You're a kitsune?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 209;
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice4bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "You're so fluffy!!!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 219;
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

// fifth story choice for scene3b

public void Choice5aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 229;
        Choice5a.SetActive(false);
        Choice5b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice5bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "I...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 239;
        Choice5a.SetActive(false);
        Choice5b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    // sixth story choice for scene3b

public void Choice6aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "You said that already";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 259;
        Choice6a.SetActive(false);
        Choice6b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice6bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "I guess so.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 279;
        Choice6a.SetActive(false);
        Choice6b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void SceneChange1()
    {
        SceneManager.LoadScene("SceneLose_LianhuaDeath");
    }
    public void SceneChange2()
    {
        GameHandler.LianhuaArrested = true;
        SceneManager.LoadScene("Scene1b");
    }
    public void SceneChange3()
    {
        SceneManager.LoadScene("SceneLose_LianhuaRomance");
    }
    public void SceneChange4()
    {
        GameHandler.LianhuaAbandoned = true;
        SceneManager.LoadScene("Scene1b");
    }
}