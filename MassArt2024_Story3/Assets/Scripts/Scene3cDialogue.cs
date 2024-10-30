using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3cDialogue : MonoBehaviour
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
    public GameObject ArtChar1h;

    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject Choice3a;
    public GameObject Choice3b;
    public GameObject Choice4a;
    public GameObject Choice4b;

    public GameObject Photoflash;

    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject NextScene3Button;
    public GameObject NextScene4Button;
    public GameObject nextButton;
    //public AudioSource audioSource1;
    private bool allowSpace = true;

    // Set initial visibility. Added images or buttons need to also be SetActive(false);
    void Start(){
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar1d.SetActive(false);
		ArtChar1e.SetActive(false);
        ArtChar1f.SetActive(false);
        ArtChar1h.SetActive(false);

        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);

        Photoflash.SetActive(false);

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
            ArtChar1a.SetActive(true);
            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "You made it! I'm so happy you made it!";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "The show was incredible!! The lights- The ambience-";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Did you enjoy the show, stranger?";
        }
        
        else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "It was amazing!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Oh joy! Wasn't it just fantastic?";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "What was your favorite song- I must know!";
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
         GameHandler.VanessaLove -= 1;
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "...were you not paying attention to my show?";
        }
        else if (primeInt == 21)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "That is not a song I performed...";
        }
        else if (primeInt == 22)
        {
            //gameHandler.AddPlayerStat(1);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I guess my show was not as show-stopping as I thought.";
        }
        else if (primeInt == 23)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "*hangs head low*";
        }
        else if (primeInt == 24)
        {
            ArtChar1c.SetActive(false);
            ArtChar1e.SetActive(true);  
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Oh no! My mask fell! Don't look at me! I'm hideous!";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice1aFunct()
            Choice2b.SetActive(true); // function Choice1bFunct()
        }

 //after choice 1b       
        else if (primeInt == 30)
        {    
        GameHandler.VanessaLove += 1;
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "That is my favorite song too!";
        }
         else if (primeInt == 31)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Oh I am just so happy that you enjoyed the show!";
        }
         else if (primeInt == 32)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "My show was amazing afterall! I was actually worried haha.";
        }
         else if (primeInt == 33)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "*Jumps for joy*";
        }
         else if (primeInt == 34)
        {
           ArtChar1a.SetActive(false);
           ArtChar1e.SetActive(true);  
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Oh no! My mask fell! Don't look at me! I'm hideous!";
             nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice1aFunct()
            Choice2b.SetActive(true); // function Choice1bFunct()
        }

  // afte choice 2a      
         else if (primeInt == 40)
        {
            Photoflash.SetActive(false);
         GameHandler.VanessaLove -= 1;   
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "What?!";
            // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(true);
            allowSpace = false;
        }

        else if (primeInt == 41)
        {
            ArtChar1h.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I actually trusted you! How could you?";
        }
          else if (primeInt == 42)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "You're making a huge mistake please don't do this!";
        }
         else if (primeInt == 43)
        {
            Char1name.text = "You";
            Char1speech.text = "Quiet! You have the right to remain silent.";
            Char2name.text = "";
            Char2speech.text = "";
        // Turn off the "Next" button, turn on "Scene" button/s
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
       
    //after choice 2b
       else if (primeInt == 50)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Yes I'm fine, I guess. A little frazzled";
        }

        else if (primeInt == 51)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Why am I still here? I thought I'd be a goner..";
        }
        else if (primeInt == 52)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Why didn't you arrest me?";
        }
    else if (primeInt == 53)
        {
            Char1name.text = "You";
            Char1speech.text = "ummm...";
            Char2name.text = "";
            Char2speech.text = "";
        }
     
     else if (primeInt == 54)
        {
            Char1name.text = "You";
            Char1speech.text = "You're pretty I guess...";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 55)
        {
         GameHandler.VanessaLove += 1;  
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "You think I'm pretty?";
        }
        else if (primeInt == 56)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "No one has ever said that to me before...";
         }
        else if (primeInt == 57)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "...";
         }
         else if (primeInt == 58)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I know I come off as super confident, but I'm pretty actually insecure.";
         }

          else if (primeInt == 59)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Could've fooled me.";
            Char2name.text = "";
            Char2speech.text = "";
         }
        else if (primeInt == 60)
        {
           
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Haha yeah...";
        }
        else if (primeInt == 61)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "What is pretty about me?";
            nextButton.SetActive(false);
            allowSpace = false;
            Choice3a.SetActive(true); // function Choice1aFunct()
            Choice3b.SetActive(true); // function Choice1bFunct()
        }
        

 // after choice 3a       
         else if (primeInt == 80)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "My eye?!";
        }
          else if (primeInt == 81)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "That can't be true I've only ever gotten made fun of for my eye. ";
        }

         else if (primeInt == 82)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Are you really sure? ";
        }
         else if (primeInt == 83)
       {
            Char1name.text = "You";
             Char1speech.text = "Yes, I'm sure.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 84)
       {
            Char1name.text = "";
             Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "...";
        }

        else if (primeInt == 85)
       {
          GameHandler.VanessaLove -= 1; 
            Char1name.text = "";
             Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "But that can't be true.";
        }
         else if (primeInt == 86)
       {
            Char1name.text = "";
             Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "My eye is hideous!";
        }

          else if (primeInt == 87)
        {
            Char1name.text = "";
             Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "You must be trying to lower my guard!";
        }
            else if (primeInt == 88)
        {
            Char1name.text = "";
             Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I can't let you out alive!";
        }
            else if (primeInt == 89)
        {
            Char1name.text = "You";
            Char1speech.text = "[Oh no what do I do?]";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 90)
        {
            Char1name.text = "You";
            Char1speech.text = "[She's going to kill me!]";
            Char2name.text = "";
            Char2speech.text = "";
        }

            else if (primeInt == 91)
        {
            Char1name.text = "You";
            Char1speech.text = "[I guess I have no choice to arrest her now...]";
            Char2name.text = "";
            Char2speech.text = "";
        }
     else if (primeInt == 92)
        {
            Char1name.text = "You";
            Char1speech.text = "[Hopefully I can forgive myself someday...]";
            Char2name.text = "";
            Char2speech.text = "";
        }
    else if (primeInt == 93)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "What are you doing? You're a cop?!";
        }
    else if (primeInt == 94)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I knew you were lying!";
        }

        else if (primeInt == 95)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "You humans are all the same!";
        }
     else if (primeInt == 96)
        {
            Char1name.text = "You";
            Char1speech.text = "You have the right to remain silent!";
            Char2name.text = "";
            Char2speech.text = "";
            //hide next button
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }


          else if (primeInt == 100)
        {
            ArtChar1e.SetActive(false);
            ArtChar1f.SetActive(true);
            GameHandler.VanessaLove += 1;
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "My signature laid back look!";
        }

        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Keep this between us but it actually takes 2 hours to perfect the look.";
        }
            else if (primeInt == 102)
        {
            Char1name.text = "You";
            Char1speech.text = "Haha well it looks great.";
            Char2name.text = "";
            Char2speech.text = "";
        }

            else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Haha, thank you stranger!";
        }

           else if (primeInt == 104)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Good thing you didn't say my eye because I would have NOT believed you.";
        }

        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I hate it when people lie and call my eye pretty. I know it is hideous.";
        }

    else if (primeInt == 106)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "I will never forget this, stranger...";
        }


         else if (primeInt == 107)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Vanessa";
            Char2speech.text = "Say, would you like to sing a duet with me?";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
            NextScene2Button.SetActive(true);
            NextScene3Button.SetActive(true);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
    public void Choice1aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Catching stars was great!";
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
        Char1speech.text = "Sing with me really resonated with me!";
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
        ArtChar1h.SetActive(true);
        StartCoroutine(FadeOut(Photoflash));
        Photoflash.SetActive(true);
        Char1name.text = "You";
        Char1speech.text = "You are coming with me, monster!";
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
        Char1name.text = "You";
        Char1speech.text = "Are you okay?";
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
        Char1name.text = "You";
        Char1speech.text = "I like the way you did your hair today.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
 public void Choice3bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Your eye really brings out all your features.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 79;
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void SceneChange1()
    {
        GameHandler.VanessaAbandoned = true;
        SceneManager.LoadScene("Scene1b");
    }
    public void SceneChange2()
    {
        GameHandler.VanessaArrested = true;
        SceneManager.LoadScene("Scene1b");
    }
        
    public void SceneChange3()
    {
        SceneManager.LoadScene("SceneLose_VanessaDuet");
    }

IEnumerator FadeIn(GameObject fadeImage){
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage){
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(2.5f, 2.5f, 2.5f, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(2.5f, 2.5f, 2.5f, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }


}
