using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int vida;
    public int vidaMax = 5;
    public SpriteRenderer playerSr;
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMax;
    }

    public void LevaDano (int amount){
         vida -= amount;
        if(vida <= 0)
       {
        playerSr.enabled = false;
        playerController.enabled = false;
       }     
    }

    // Update is called once per frame
    void Update()
    {
    }
}
