using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShockScreen : MonoBehaviour
{
    public Image white_Screen;
    public float time;

    FeedbackManager s_FeedbackManager;

    public int flash;

    private void Start()
    {
        s_FeedbackManager = FindObjectOfType<FeedbackManager>();
    }

    //--------BEST FEEDBACK TO USE--------//
    /*
     * Pause screen with ONE flash
     */
    public void FlashScreen()
    {
        //***FLASHING SCREEN***//
        //--WHAT IT DOES--//
        /* A short flash appear upon death
        //Research note//
        /*
         * Making it pure white hurts the eye.The sudden change to a intense colour the human eyes are 
         * forced to rapidly adjust to changing light output, which stresses the eye muscles.
         ***SOLUTION***
         * Need to change colour to a less intense colour(NO STRONG AND BRIGHT COLOUR)and tone down alpha to reduce eye pain
         */
        //white_Screen.color = new Color(.6f, .6f, .6f, 0.75f);
        //Invoke("ClearScreen", time);

        /////////////////////////////////////////
        //***MULTIPLE FLASHING***//
        //--WHAT IT DOES--//
        /*Flash multiple time upon death of enemy
        //Research note//
        /* Looks cool but just as effective as flashing once. Plus multiple flashing can cause the player to 
         * get distracted. Also seizure(imagine have multiple enemy in screen and eliminating them one by one within short
         * interval. I dont like Zouk)
         ***SOLUTION***
         *DON'T USE THIS PLEASE
         */

        white_Screen.color = new Color(.6f, .6f, .6f, 0.75f);
        Invoke("ClearScreen", time);

    }
    public void PauseScreen()
    {
        /////////////////////////////////////////
        //***Short Pause***//
        //Research note//
        /*
         * Making it pure white hurts the eye.The sudden change to a intense colour the human eyes are 
         * forced to rapidly adjust to changing light output, which stresses the eye muscles.
         ***SOLUTION***
         * Need to change colour to a less intense colour(NO STRONG AND BRIGHT COLOUR)and tone down alpha to reduce eye pain
         */
        Time.timeScale = 0.1f;
        Invoke("ResumeScreen", time);
    }
    void ResumeScreen()
    {
        //Pause Screen
        Time.timeScale = 1f;
        //With flash
        if (s_FeedbackManager.FlashScreenActivate)
        {
            FlashScreen();
        }
    }
    public void ClearScreen()
    {

        //Single Flash
        white_Screen.color = Color.clear;

        //Multiple Flash
        /*white_Screen.color = Color.clear;
        if (flash < 3)
        {
            flash++;
            Invoke("WhiteScreen", time);
        }
        else
            flash = 0;*/
    }
}
