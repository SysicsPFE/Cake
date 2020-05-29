﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [Header("Shop")]
    public PackScript[] Packs;
    public GameObject PackButton;
    public GameObject packPanel;
    public GameObject PackDetailsPanel;
    
    public Image PackImage;
    public Text LockedTxt;
    public Text NbcoinTxt;
    // Start is called before the first frame update
    void Start()
    {
        instantiatePacks();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void instantiatePacks()
    {
        for (int i = 0; i < Packs.Length; i++)
        {

            GameObject go= Instantiate(PackButton, packPanel.transform);
            go.GetComponentInChildren<Image>().sprite = Packs[i].image;
            //RegisterListenerPack(go, i);
            go.GetComponent<Button>().onClick.AddListener(() => { OnPackClick(i); });
            
        }
    }



    public void RegisterListenerPack(GameObject obj, int i)
    {

        Debug.Log(i);
        
    }
    public void OnPackClick(int i)
    {
        Debug.Log("ioj");
        PackDetailsPanel.SetActive(true);
        PackImage.sprite = Packs[i].image;
        LockedTxt.text = "Unlocked after "+ Packs[i].Locked + " games";
        NbcoinTxt.text = Packs[i].nbCoin +"Coins";
    }
    public void test()
    {
        Debug.Log("ihbiub");
    }


}