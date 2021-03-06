﻿using UnityEngine;
using System.Collections;

public class PlataformaCai : MonoBehaviour {

    //Indica o tempo que irá demorar para a plataforma cair após o personagem pisar.
    public float duracaoCair;

    //Armazena o tempo desde a ultima vez que ele pisou.
    private float tempo;

    //Indica se o personagem pisou ou não. (se pisou, inicia a contagem para a plataforma cair).
    private bool pisou;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Se a variavel pisou for verdadeira.
        if (pisou)
        {
            //Começa a contagem do tempo.
            tempo += Time.deltaTime;

            //Se o tempo for maior ou igual que a duracao planejada para a plataforma cair.
            if (tempo >= duracaoCair)
            {
                //Se o objeto não tiver Rigidbody.
                if(gameObject.GetComponent<Rigidbody2D>() == null) { 
                //Adiciona massa ao objeto.
                gameObject.AddComponent<Rigidbody2D>();
                }
                //Destroi o objeto após 2 segundos.
                Destroy(gameObject, 2f);
            }
        }

    }


    /*
    void OnCollisionEnter2D(Collision2D colisor)
    {

        //Debug.Log();
        Debug.Log(colisor.gameObject.name + " " + "OnCollision");
        if (colisor.gameObject.name == "Player")
        {

            //pisou = true;

        }

    }
    */

    //Quando o player(o chao verificador do player) colidir com a plataforma, seta pisou como true.
    void OnTriggerEnter2D(Collider2D colisor)
    {
        
        if (colisor.gameObject.name == "chaoVerificador" && colisor.gameObject.transform.parent.gameObject.name == "Player")
        {

            pisou = true;

        }
        

    }






}
