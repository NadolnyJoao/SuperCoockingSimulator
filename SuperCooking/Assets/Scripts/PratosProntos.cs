using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PratosProntos : MonoBehaviour
{
    public bool hamburguerNoPrato = false;
    public bool paoNoPrato = false;
    public bool queijoNoPrato = false;
    public bool acucarNoPrato = false;
    public bool farinhaNoPrato = false;
    public bool chocolateNoPrato = false;
    public bool sopaNoPrato = false;
    public GameObject hamburguerCompleto;
    public GameObject cupcakeCompleto;
    public GameObject sopaCompleto;
    public GameObject obj;
    public Transform SpawnPointPedido;
    public Transform SpawnPointCupcake;
    public Transform SpawnPointSopa;
    public float YOffset = 0.2f;
    public float YOffset2 = 0;

    public GameObject hamburguerCompletoSpawn;
    public GameObject cupcakeCompletoSpawn;
    public GameObject sopaCompletoSpawn;

    public LoucaScript PodeLavar;
    private EntregaBalcao entregaBalcao;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Louca");
        if (obj != null)
        {
            PodeLavar = obj.GetComponent<LoucaScript>();
        }

        GameObject obj2 = GameObject.FindGameObjectWithTag("Esteira");
        if (obj2 != null)
        {
            entregaBalcao = obj.GetComponent<EntregaBalcao>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(hamburguerNoPrato && paoNoPrato && queijoNoPrato)
        {
            hamburguerCompletoSpawn = Instantiate(hamburguerCompleto, new Vector3(SpawnPointPedido.position.x, SpawnPointPedido.position.y + YOffset, SpawnPointPedido.position.z), SpawnPointPedido.rotation); 
            
        }
        hamburguerNoPrato = false;
        paoNoPrato = false;
        queijoNoPrato = false;

        if(acucarNoPrato && chocolateNoPrato && farinhaNoPrato)
        {
            
            cupcakeCompletoSpawn = Instantiate(cupcakeCompleto, new Vector3(SpawnPointCupcake.position.x, SpawnPointCupcake.position.y + YOffset, SpawnPointCupcake.position.z), SpawnPointPedido.rotation);
            PodeLavar.PodeLavaraLouca = true;  
            
        }
        acucarNoPrato = false;
        chocolateNoPrato = false;
        farinhaNoPrato = false;
        

        if(sopaNoPrato && PodeLavar.PodeSopa == true)
        {
            sopaCompletoSpawn = Instantiate(sopaCompleto, new Vector3(SpawnPointSopa.position.x, SpawnPointSopa.position.y + YOffset2, SpawnPointSopa.position.z), SpawnPointPedido.rotation);  
        }
        sopaNoPrato = false;
    }
}
