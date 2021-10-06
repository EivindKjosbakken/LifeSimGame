using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{

    public static int activeSkin = 1;

    static public float money = 50000f;

    static public int energy = 50;

    public static float daysPassed = 0f;

    public static float invested1 = 0;
    public static float invested2 = 0;
    public static float invested3 = 0;
    public static float invested4 = 0;

    static public List<int> ownedStocks = new List<int>() { 0, 0, 0, 0 };

    public static List<int> unlockedAreas = new List<int>() { 1, 0, 0, 0 };

    static public List<int> unlockedJobs = new List<int>();

    static public List<bool> unlockedClothes = new List<bool>() { true, false, false, false };

    static public int garbageManExperience = 0;
    static public int chefExperience = 0;
    static public int salesExperience = 0;
    static public int doctorExperience = 0;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
