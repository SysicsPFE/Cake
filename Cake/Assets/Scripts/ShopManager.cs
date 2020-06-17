using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    [Header("Shop")]
    public PackScript[] Packs;
    public GameObject PackButton;
    public GameObject packPanel;
    public GameObject PackDetailsPanel;
    private PackScript lastPackClicked;
    public GameObject Shop;
    
    
    public Image PackImage;
    public TextMeshProUGUI LockedTxt;
    public TextMeshProUGUI NbcoinTxt;
    public TextMeshProUGUI NameTxt;

    // Start is called before the first frame update
    void Start()
    {
        instantiatePacks();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CoinAnimationAdd(byte c)
    {

        for (int i = 0; i < c; i++)
        {

            yield return new WaitForSeconds(Time.deltaTime);
            GetComponent<MenuManager>().CoinValue--;
            GetComponent<MenuManager>().CoinText.text = GetComponent<MenuManager>().CoinValue.ToString();
            

        }
    }
    private void instantiatePacks()
    {
        for (int i = 0; i < Packs.Length; i++)
        {

            GameObject go= Instantiate(PackButton, packPanel.transform);
            go.GetComponentInChildren<Image>().sprite = Packs[i].image;
            RegisterListenerPack(go, i);
            
            
        }
    }



    public void RegisterListenerPack(GameObject obj, int i)
    {

        Debug.Log(i);
        obj.GetComponent<Button>().onClick.AddListener(() => { OnPackClick(i); });
        
    }
    public void OnPackClick(int i)
    {
        if (Packs[i].Unlocked == false)
        {
            lastPackClicked = Packs[i];
            PackDetailsPanel.SetActive(true);
            PackImage.sprite = Packs[i].CharacterImage;
            LockedTxt.text = "Unlocked after " + Packs[i].Locked + " games";
            NbcoinTxt.text = Packs[i].nbCoin + "Coins";
            NameTxt.text = Packs[i].Name;
        }

    }
    public void onBuyClick()
    {
        if (lastPackClicked.nbCoin > GetComponent<MenuManager>().CoinValue)
        {
            lastPackClicked.Unlocked = true;
        }
        else
        {
            StartCoroutine(CoinAnimationAdd(lastPackClicked.nbCoin));
        }
    }
    public void exitPackDetails()
    {
        PackDetailsPanel.SetActive(false);
    }

    public void ExitShop()
    {
        Shop.SetActive(false);
    }
   

}
