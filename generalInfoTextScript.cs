using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generalInfoTextScript : MonoBehaviour
{
    
    public Text infoText;


   

    public void ShowText(string s)
    {

        infoText.text = s;
        StartCoroutine(InvokeRealtimeCoroutine());


        /*Debug.Log("Det funker!");
        infoText.text = s;
        
        Invoke("hideText", 1f);

        infoText.text = s;
        StartCoroutine(FadeTextToFullAlpha(1f, this.infoText));
        Debug.Log("Tekst vises");

        StartCoroutine(InvokeRealtimeCoroutine());
        Debug.Log("Tidligst");
        */


    }


    IEnumerator InvokeRealtimeCoroutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        RemoveText();
    }
    

    public void RemoveText()
    {
        infoText.text = "";
        Debug.Log("Remove funker");
    }
    public void hideText()
    {
        StartCoroutine(FadeTextToZeroAlpha(0f, this.infoText));
        Debug.Log("Den kjører");
    }


    //for fading av teksten, kan evt legge til senere

    public IEnumerator FadeTextToFullAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }

}
