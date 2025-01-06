using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PratosProntos : MonoBehaviour
{
    public bool hamburguerNoPrato = false;
    public bool paoNoPrato = false;
    public bool queijoNoPrato = false;
    public GameObject hamburguerCompleto;
    public Transform SpawnPointPedido;
    public float YOffset = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hamburguerNoPrato && paoNoPrato && queijoNoPrato)
        {
            Instantiate(hamburguerCompleto, new Vector3(SpawnPointPedido.position.x, SpawnPointPedido.position.y + YOffset, SpawnPointPedido.position.z), SpawnPointPedido.rotation);  
        }
    }
}
