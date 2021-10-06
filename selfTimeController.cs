using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class selfTimeController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void changeTime(float time)
        {
            Data.daysPassed += time;
            Data.invested1 = Data.invested1 + Data.invested1 * time / 100f;
        Debug.Log(Data.invested1);
            Data.invested2 = Data.invested2 + Data.invested2 * time / 100f;
            Data.invested3 = Data.invested3 + Data.invested3 * time / 100f;
            Data.invested4 = Data.invested4 + Data.invested4 * time / 100f;
        //Debug.Log("Day passed");
        //Debug.Log(Data.daysPassed);
        //Debug.Log("Invested in stocks after time is" + Data.investedInStocks);
    }
    }
