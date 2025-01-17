﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour{

    public static UIManager Instance = null;

    [SerializeField]
    private bool initUI = true;

    public GameObject PanelConnect;
    public GameObject LabelProgress;
    public GameObject PanelLobby;
    public GameObject PanelRoom;
    public GameObject PanelMatchOptions;
    [SerializeField] MeshRenderer tank_UI;



    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        if (initUI)
        {
            Clear();
            PanelConnect.SetActive(true);            
        }
    }

    void Clear()
    {
        PanelConnect.SetActive(false);
        LabelProgress.SetActive(false);
        PanelLobby.SetActive(false);
        PanelRoom.SetActive(false);
        PanelMatchOptions.SetActive(false);
    }
    public  void GoToLobby()
    {
        Clear();
        PanelLobby.SetActive(true);
    }
    public void ShowProgress()
    {
        Clear();
        LabelProgress.SetActive(true);
    }
    public void GotoRoom()
    {
        Clear();
        PanelRoom.SetActive(true);
    }
    public void ShowMatchOptions()
    {
        PanelMatchOptions.SetActive(true);       
    }
    public void HideMatchOptions()
    {
        PanelMatchOptions.SetActive(false);
    }
    public void ChangeColorTank(int index)
    {
        string color;
        ColorCodes color_c = (ColorCodes)index;
        color = color_c.ToString();
        Debug.Log("color: " + color);
        if (color == "Red") tank_UI.material.color = Color.red;
        else if (color == "Blue") tank_UI.material.color = Color.blue;
        else tank_UI.material.color = Color.green;
    }

}
