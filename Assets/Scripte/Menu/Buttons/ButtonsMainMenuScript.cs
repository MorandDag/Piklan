﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMainMenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MenuExite;
    public GameObject MenuSave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonGame()
    {
        MainMenu.SetActive(false);
    }

    public void ButtonExite()
    {
        MainMenu.SetActive(false);
        MenuExite.SetActive(true);
    }
}
