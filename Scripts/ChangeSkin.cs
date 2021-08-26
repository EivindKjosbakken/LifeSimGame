using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject player;
    public GameObject redPlayer;
    public GameObject ninjaPlayer;

    public SpriteRenderer player1;
    public SpriteRenderer redPlayer1;
    public SpriteRenderer ninjaPlayer1;


    private void Start()
    {
        redPlayer1.enabled = false;
        ninjaPlayer1.enabled = false;
    }
    void ChangeToRedSkin()
    {
        
    }
}
