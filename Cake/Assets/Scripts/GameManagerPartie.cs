using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerPartie : MonoBehaviour
{
    public static GameManagerPartie instance;
   // public List<GameObject> myCake;
    public  GameObject[] Cakes;
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
    public Material[] materials=new Material[4];

    void Awake()
    {
        instance=this;
    }
        
    
    void Start()
    {
        //scoreText = GetComponent<Text>();
        cakeMaterials = Resources.LoadAll<Material>("cakeMaterials");
        creamMaterials = Resources.LoadAll<Material>("creamMaterials");
        materialSelected = (byte)Random.Range(0, cakeMaterials.Length);
       Debug.Log("bbb" + materialSelected);
       Debug.Log("aaaaaaaa" + cakeMaterials[materialSelected]);
        Cakes = Resources.LoadAll<GameObject>("Cakes");
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
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + scoreValue;
    }
}
