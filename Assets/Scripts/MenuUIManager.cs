﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene("level1");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
    public void Open()
    {
          Application.OpenURL("http://ssgames.ir/");
    }
}
