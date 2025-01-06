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
    public GameObject sopaPrefab;
    public Transform spawnPoint;
    public GameObject acucarprefab;
    public GameObject farinhaprefab;
    public GameObject chocolateprefab;
    public GameObject acucarprefabSpawn;
    public GameObject farinhaprefabSpawn;
    public GameObject chocolateprefabSpawn;
    public GameObject sopaPrefabSpawn;
    public bool pronto;
    public bool prontoSopa = false;

    private Inventario inventario;
    private PratosProntos pratosprontos;
    public float yOffset = 2.0f;
    public bool prontoCup = false;

    
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
            pronto = false;
        }
        if(prontoCup)
        {
            Destroy(chocolateprefabSpawn, 0);
            Destroy(acucarprefabSpawn, 0);
            Destroy(farinhaprefabSpawn, 0);
            prontoCup= false;
        }
        if(prontoSopa)
        {
            Destroy(sopaPrefabSpawn,0);
            prontoSopa = false;
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

    public void MontarPratoHamburguer()
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

    public void MontarPratoCupcake()
    {
        if(inventario.acucar)
        {
            acucarprefabSpawn = Instantiate(acucarprefab, spawnPoint.position, spawnPoint.rotation); 
            pratosprontos.acucarNoPrato = true;
            inventario.acucar = false;
        }
        if(inventario.chocolate)
        {
            chocolateprefabSpawn = Instantiate(chocolateprefab, spawnPoint.position, spawnPoint.rotation); 
            pratosprontos.chocolateNoPrato = true;
            inventario.chocolate = false;
        }
        if(inventario.farinha)
        {
            farinhaprefabSpawn = Instantiate(farinhaprefab, spawnPoint.position, spawnPoint.rotation); 
            pratosprontos.farinhaNoPrato = true;
            inventario.farinha = false;
        }
        prontoCup = true;
    }

   public void MontarSopa()
   {
    if(inventario.sopadetomate)
    {
        sopaPrefabSpawn = Instantiate(sopaPrefab, spawnPoint.position, spawnPoint.rotation); 
        pratosprontos.sopaNoPrato = true;
        inventario.sopadetomate = false;
    }
    prontoSopa = true;
   } 


}
