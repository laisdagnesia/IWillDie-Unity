using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public int vida;
    public int vidaMax;

    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] hearts;
    public VidaPlayer vidaPlayer; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vida = vidaPlayer.vida;
        vidaMax = vidaPlayer.vidaMax;
        for (int i = 0 ; i < hearts.Length; i++) {
            if (i< vida){
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }
            if ( i < vidaMax) 
            {
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false; 
            }
        }
    }
}
