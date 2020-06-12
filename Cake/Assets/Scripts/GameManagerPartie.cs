
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManagerPartie : MonoBehaviour
{
    public static GameManagerPartie instance;
   // public List<GameObject> myCake;
    public  GameObject[] Cakes;
    public GameObject[] Walls;
    public Vector3 cakePos;
    public int nb_cake;
    public GameObject curentCake;
    public GameObject curentCake_;
    public int Cake_Div;
    public GameObject cakeInstantiated;
    public float speed = 20f;
    public GameObject Cream;
    public Material[] cakeMaterials= new Material[3];
    public Material[] creamMaterials= new Material[3];
    private byte materialSelected;
    public int scoreValue = 0;
    public Text scoreText;
    public TextMeshProUGUI ScoreTxt;
    public TextMeshProUGUI highScore;
    public GameObject HighScoreMenu;
    public Material[] materials=new Material[4];
    public bool Die = false;
    public GameObject GameOverMenu;
    public string Mode;
    public GameObject ProgressBar;
    public int CakeSpeed;
    public int[] SpeedArray = new int[] {100, 25, 150, 10, 50 };
    public GameObject Wall;
    public GameObject Wall_;
    public Vector3 WallPos;
    

    void Awake()
    {
        instance=this;
    }
    void Start()
    {   

        Mode = ModesManager.Mode;
        Debug.Log(Mode);
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
         
        cakeMaterials = Resources.LoadAll<Material>("cakeMaterials");
        creamMaterials = Resources.LoadAll<Material>("creamMaterials");
        materialSelected = (byte)Random.Range(0, cakeMaterials.Length);
       Debug.Log("bbb" + materialSelected);
       Debug.Log("aaaaaaaa" + cakeMaterials[materialSelected]);
        Cakes = Resources.LoadAll<GameObject>("Cakes");
        Walls = Resources.LoadAll<GameObject>("WALL");
        Debug.Log("Cakes length:" + Cakes.Length);
        nb_cake = Cakes.Length;
        curentCake = Cakes[Random.Range(0, nb_cake)];
        Debug.Log("curent cake is "+ curentCake);

        Cake_Div = curentCake.transform.childCount;
        Debug.Log("nb div est " + Cake_Div);
        curentCake_= Instantiate(curentCake, cakePos, Quaternion.Euler(0, 0, 0),cakeInstantiated.transform);
       

        for (int i = 0; i < nb_cake; i++)
        {
            for (int j = 0; j < Cakes[i].transform.childCount; j++)
            {
                Cakes[i].transform.GetChild(j).gameObject.GetComponent<MeshRenderer>().sharedMaterial = materials[Random.Range(0, materials.Length)];
               // Debug.Log(Cakes[i].transform.GetChild(j).GetComponent<MeshRenderer>().material.GetColor("_BaseColor"));
            }

        } switch (scoreValue)
        {
            case 0:
                Wall = Walls[0];
                Wall_ = Instantiate(Wall, WallPos, Quaternion.Euler(0, 0, 0));
                break;
            case 10:
                Wall = Walls[1];
                Wall_ = Instantiate(Wall, WallPos, Quaternion.Euler(0, 0, 0));
                break;
        }
        
        switch (Mode)
        {
            case "Endless":
                Debug.Log("5tart Endless");
                break;

            case "Timer":
                 
                Debug.Log(" 5tart timer ");
                ProgressBar.SetActive(true);
                break;

            case "Speed":
                StartCoroutine(RandomSpeed());
                
                Debug.Log("5tart speed");
                break;
        }
    }
    public void nextCake()
    {
        curentCake = Cakes[Random.Range(0, nb_cake)];
        Cake_Div = curentCake.transform.childCount;
        GameObject creamInstantiated= Instantiate(Cream, new Vector3(curentCake_.transform.position.x, curentCake_.transform.position.y, curentCake_.transform.position.z), Quaternion.Euler(0, 0, 0), cakeInstantiated.transform);
        creamInstantiated.transform.GetChild(0).GetComponent<MeshRenderer>().sharedMaterial = creamMaterials[materialSelected];
           
        for (int i = 0; i < curentCake_.transform.childCount; i++)
        {
            curentCake_.transform.GetChild(i).GetComponent<MeshRenderer>().sharedMaterial = cakeMaterials[materialSelected];
        }

        for (int i = 0; i < cakeInstantiated.transform.childCount; i++)
        {
            cakeInstantiated.transform.GetChild(i).localScale = new Vector3(cakeInstantiated.transform.GetChild(i).localScale.x - 1000, cakeInstantiated.transform.GetChild(i).localScale.y, cakeInstantiated.transform.GetChild(i).localScale.z - 1000);
        }
        
        cakeInstantiated.transform.position = Vector3.Lerp(cakeInstantiated.transform.position, new Vector3(cakeInstantiated.transform.position.x, cakeInstantiated.transform.position.y + 185, cakeInstantiated.transform.position.z), speed * Time.deltaTime);
        curentCake_ = Instantiate(curentCake, cakePos, Quaternion.Euler(0, 0, 0),cakeInstantiated.transform);
         

    }
    void Update()
   {

      

       


        scoreText.text = "score: " + scoreValue;
        if (Die)
        {
            FindObjectOfType<AudioManager>().Play("GameOver");
            if (scoreValue > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", scoreValue);
                highScore.text = scoreValue.ToString();
                HighScoreMenu.SetActive(true);

            }
            else
            {
                GameOverMenu.SetActive(true);
            }
                ScoreTxt.text = "Your score is  " +  scoreValue;
        }
    }

    IEnumerator RandomSpeed()
    {
        while (true)
        {
            Rotate.degreesPerSecond = SpeedArray[Random.Range(2, SpeedArray.Length)];
            yield return new WaitForSeconds(5);
            Debug.Log(Rotate.degreesPerSecond);
        }
    }
}



