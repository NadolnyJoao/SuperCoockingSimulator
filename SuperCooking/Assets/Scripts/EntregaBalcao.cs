using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EntregaBalcao : MonoBehaviour
{
    public GameObject pratohamburguer;
    public GameObject pratocupcake;
    public GameObject pratosopa;
    private PratosProntos pratosProntos;
    public bool cupcakemao = false;
    public bool hamburguermao = false;
    public bool sopamao = false;
    public float pontuacao;
    public Text pontuacaotxt;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Prato Controller");
        if (obj != null)
        {
            pratosProntos = obj.GetComponent<PratosProntos>();
        }
         pontuacaotxt.text = "Pontuação: " + pontuacao;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PegarPratoHamburguer()
    {
        pratohamburguer.SetActive(true);
        hamburguermao = true;
    }

    public void PegarPratoCupcake()
    {
        pratocupcake.SetActive(true);
        cupcakemao = true;
    }

    public void PegarPratoSopa()
    {
        pratosopa.SetActive(true);
        sopamao = true;
    }

    public void EntregarBalcao()
    {
        if(pratohamburguer.activeSelf || pratocupcake.activeSelf || pratosopa.activeSelf)
        {
            pratohamburguer.SetActive(false);
            pratocupcake.SetActive(false);
            pratosopa.SetActive(false);
            pontuacao++;
            pontuacaotxt.text = "Pontuação: " + pontuacao;
            if(pontuacao == 3)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    
    
}
