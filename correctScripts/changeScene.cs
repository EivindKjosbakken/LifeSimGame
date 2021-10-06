using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeScene : MonoBehaviour
{





    public GameManager gm;
    //public Animator animator;


    public void nextLevel()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {



        if (this.tag == "startTrigger")
        {
            // transition.SetTrigger("Start");
            //  yield return new WaitForSeconds(1);  //nytt denne linja og over
            //gm.PreviousLevel();
            //GameManager.WhichTrigger = "Start";
            gm.trigger = "startTrigger";
            gm.loadNextLevel();
            Debug.Log("StartTrigger");
        }

        if (this.tag == "endTrigger")
        {

            gm.trigger = "endTrigger";
            gm.loadPrevLevel();

            Debug.Log("EndTrigger");

        }
    }

}
