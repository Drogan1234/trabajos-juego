using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class avanzar : MonoBehaviour
{
    public Transform objetivo;

    // Start is called before the first frame update
    void Start()
    {
        objetivo = GameObject.FindWithTag("Finish").transform;
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        agente.destination = objetivo.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
