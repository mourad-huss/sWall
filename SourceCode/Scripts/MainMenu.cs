﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    //Main menu class for now has 3 buttons, play, options and how to play.
    //It will create a new instace of class 'Game' when play, Game keeps track of the score and rounds.
    

    /********************************************/
    /********  Public Variables  ****************/
    /********************************************/
    public Button play;//Play button that start the game when pressed
    public Button options;//Options button that bring up an options menu to change gameplay setting;
    public Button howToPlay;//On click it should either bring up instructions or launch a video
    public Text Version;//Contains the version number in the lower left corner should be changed either manually or through code when changes have been made
    

    void Start () {

        //initialize the actionListeners for all the buttons
        play.onClick.AddListener(launchGame);
        options.onClick.AddListener(openOptions);
        howToPlay.onClick.AddListener(openHowToPlay);
	}
	
    private void launchGame()
    {
        Debug.Log("Launching Game");
        Application.LoadLevel("GamePlayRound");
        //Game gameStart = new Game();
        //gameStart.createNewGame(3);
    }
    private void openOptions()
    {
        Debug.Log("Opening options menu");
        //Need to make an options menu
    }
    private void openHowToPlay()
    {
        Debug.Log("Opening Instructions");
        //Need to create a tutorial 
    }


}
