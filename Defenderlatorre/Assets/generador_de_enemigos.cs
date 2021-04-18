using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//tipos de enemigos
//enemy_ufoGreen
//enemy_ufoGreenWeapon
//enemy_ufoPurple
//enemy_ufoPurpleWeapon
//enemy_ufoRed
//enemy_ufoRedWeapon
//enemy_ufoYellow
//enemy_ufoYellowWeapon
public class generador_de_enemigos : MonoBehaviour
{
    public float tiempoMax = 1;
    private float tiempoInicial = 0;
    public GameObject enemigo1;
    public GameObject enemigo2;
    public GameObject enemigo3;
    public GameObject enemigo4;
    public GameObject enemigo5;
    public GameObject enemigo6;
    public GameObject enemigo7;
    public GameObject enemigo8;
    private GameObject enemigoNuevo;
//    public GameObject piezainicio;
//    public Vector3 posicioninicio;

    // Start is called before the first frame update
    void Start()
    {
//        enemigo1 = GameObject.Find("enemy_ufoGreen");
//        enemigo2 = GameObject.Find("enemy_ufoGreenWeapon");
//        enemigo3 = GameObject.Find("enemy_ufoPurple");
//        enemigo4 = GameObject.Find("enemy_ufoPurpleWeapon");
//        enemigo5 = GameObject.Find("enemy_ufoRed");
//        enemigo6 = GameObject.Find("enemy_ufoRedWeapon");
//        enemigo7 = GameObject.Find("enemy_ufoYelolw");
//        enemigo8 = GameObject.Find("enemy_ufoYellowWeapon");

        //        posicioninicio = piezainicio.transform.position;
        //      GameObject obstaculoNuevo = Instantiate(enemigo);
        //      obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        creaenemigo();
    }
    void creaenemigo()
    {
        if (tiempoInicial > tiempoMax) {
            int tipo = Random.Range(1, 8);
            switch(tipo)
            {
                case 1:
                    enemigoNuevo = Instantiate(enemigo1);
                    break;
                case 2:
                    enemigoNuevo = Instantiate(enemigo2);
                    break;
                case 3:
                    enemigoNuevo = Instantiate(enemigo3);
                    break;
                case 4:
                    enemigoNuevo = Instantiate(enemigo4);
                    break;
                case 5:
                    enemigoNuevo = Instantiate(enemigo5);
                    break;
                case 6:
                    enemigoNuevo = Instantiate(enemigo6);
                    break;
                case 7:
                    enemigoNuevo = Instantiate(enemigo7);
                    break;
                case 8:
                    enemigoNuevo = Instantiate(enemigo8);
                    break;
            }
            enemigoNuevo.transform.position = transform.position;
            tiempoInicial = 0;
        }
        else
        {
            tiempoInicial += Time.deltaTime;
        }
        

    }

}

