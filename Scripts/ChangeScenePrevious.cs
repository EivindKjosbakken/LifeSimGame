using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenePrevious : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter2D(Collider2D collision)
    {



        gm.PreviousLevel();
        Debug.Log("Going to previous level");

    }
}
