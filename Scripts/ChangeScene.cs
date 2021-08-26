using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{


    
    
    public GameManager gm;

    public Money money; //nytt


    public Animator transition;




    void OnTriggerEnter2D(Collider2D collision)
    {


        if (this.tag == "End")
        {

            transition.SetTrigger("Start");
            //yield return new WaitForSeconds(1);   //nytt denne linja og over
            gm.NextLevel();
                
            GameManager.WhichTrigger = "End";



        }

        if (this.tag == "Start")
        {
            transition.SetTrigger("Start");
           //  yield return new WaitForSeconds(1);  //nytt denne linja og over
            gm.PreviousLevel();
            GameManager.WhichTrigger = "Start";
        }
    }


}
