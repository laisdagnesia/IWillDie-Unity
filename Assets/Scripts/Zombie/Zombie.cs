using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private GameObject player;
    public float velocidade = 2f;
    public int dano = 1;
    public VidaPlayer vidaPlayer; 
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidade*Time.deltaTime);
    }
   void OnTriggerEnter2D(Collider2D other){
     if (other.gameObject.tag=="Player"){

        vidaPlayer.LevaDano(dano);
       //     other.gameObject.GetComponent<PlayerController>().sofrerDano(dano);
       //     Destroy(other.gameObject);
     }
    }
}

//Números positivos para o eixo Z fazem o objeto se deslocar para a frente e número negativos para a trás.