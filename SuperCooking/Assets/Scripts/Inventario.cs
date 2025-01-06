using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public bool hamburguercru;
    public bool hamburguercozido;
    public bool pao;
    public bool queijo;
    public bool farinha;
    public bool acucar;
    public bool chocolate;
    public bool sopadetomate;
    public GameObject pao2;
    public GameObject queijo2;
    public GameObject hamburguercru2;
    public GameObject hamburguercozido2;
    public GameObject farinha2;
    public GameObject acucar2;
    public GameObject chocolate2;
    public GameObject sopadetomate2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pao)
        {
            pao2.SetActive(true);
        }
        else
        {
            pao2.SetActive(false);
        }
        if(queijo)
        {
            queijo2.SetActive(true);
        }
        else
        {
            queijo2.SetActive(false);
        }
        if(hamburguercru)
        {
            hamburguercru2.SetActive(true);
        }
        else
        {
            hamburguercru2.SetActive(false);
        }
        if(hamburguercozido)
        {
            hamburguercozido2.SetActive(true);
        }
        else
        {
            hamburguercozido2.SetActive(false);
        }
        if(farinha)
        {
            farinha2.SetActive(true);
        }
        else
        {
            farinha2.SetActive(false);
        }
        if(acucar)
        {
            acucar2.SetActive(true);
        }
        else
        {
            acucar2.SetActive(false);
        }
        if(chocolate)
        {
            chocolate2.SetActive(true);
        }
        else
        {
            chocolate2.SetActive(false);
        }
        if(sopadetomate)
        {
            sopadetomate2.SetActive(true);
        }
        else
        {
            sopadetomate2.SetActive(false);
        }
    }
}
