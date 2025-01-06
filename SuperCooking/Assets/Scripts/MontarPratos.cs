using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontarPratos : MonoBehaviour
{
    public GameObject hamburguerfeitoprefab;
    public GameObject paoprefab;
    public GameObject queijoPrefab;
    public GameObject hamburguerfeitoprefabSpawn;
    public GameObject paoprefabSpawn;
    public GameObject queijoPrefabSpawn;
    public Transform spawnPoint;
    public bool pronto;


    private Inventario inventario;
    private PratosProntos pratosprontos;
    public float yOffset = 2.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj2 = GameObject.Find("Prato Controller");
        if (obj2 != null)
        {
            pratosprontos = obj2.GetComponent<PratosProntos>();
        }

        GameObject obj = GameObject.Find("Player");
        if (obj != null)
        {
            inventario = obj.GetComponent<Inventario>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(pronto)
        {
            Destroy(paoprefabSpawn, 0);
            Destroy(queijoPrefabSpawn, 0);
            Destroy(hamburguerfeitoprefabSpawn, 0);

        }
    }

    // public void hamburguerprato()
    // {
    //     if(inventario.hamburguercozido)
    //     {
    //         Instantiate(hamburguerfeitoprefab, spawnPoint.position, spawnPoint.rotation); 
    //         inventario.hamburguercozido = false;
    //         pratosprontos.hamburguerNoPrato = true;
    //     }
    // }

    // public void paonoprato()
    // {
    //     if(inventario.pao)
    //     {
    //         Instantiate(paoprefab, spawnPoint.position, spawnPoint.rotation); 
    //         pratosprontos.paoNoPrato = true;
    //         inventario.pao= false;
    //     }
    // }

    // public void queijonoprato()
    // {
    //     if(inventario.queijo)
    //     {
    //         Instantiate(queijoPrefab, spawnPoint.position, spawnPoint.rotation); 
    //         pratosprontos.queijoNoPrato = true;
    //         inventario.queijo = false;
    //     }
    // }

    public void MontarPrato()
    {
        if(inventario.queijo)
        {
            queijoPrefabSpawn = Instantiate(queijoPrefab, spawnPoint.position, spawnPoint.rotation); 
            pratosprontos.queijoNoPrato = true;
            inventario.queijo = false;
        }
        if(inventario.pao)
        {
            paoprefabSpawn = Instantiate(paoprefab, spawnPoint.position, spawnPoint.rotation); 
            pratosprontos.paoNoPrato = true;
            inventario.pao= false;
        }
        if(inventario.hamburguercozido)
        {
            hamburguerfeitoprefabSpawn = Instantiate(hamburguerfeitoprefab, spawnPoint.position, spawnPoint.rotation); 
            inventario.hamburguercozido = false;
            pratosprontos.hamburguerNoPrato = true;
        }
        pronto = true;
    }


}
