using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Hamburguer : MonoBehaviour
{
    public bool hamburguerfritar = false;
    public GameObject objectPrefab;
    public GameObject HambPronto;
    public GameObject spawnedObject;

    public Transform spawnPoint;

    public float startTime = 60f;

    public Text timerText;

    private float timeRemaining;

    private bool isRunning = false;
    public bool hambpronto = false;
    public bool hambinv = false;


    private Inventario inventario;

    void Start()
    {
        timeRemaining = startTime;


        GameObject obj = GameObject.Find("Player");
        if (obj != null)
        {
            inventario = obj.GetComponent<Inventario>();
        }

        UpdateTimerText();
    }

    void Update()
    {
        if (hamburguerfritar && !isRunning)
        {
            isRunning = true;
        }

        if (isRunning)
        {
            // Subtrai o tempo desde o último quadro
            timeRemaining -= Time.deltaTime;

            // Garante que o tempo não fique negativo
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isRunning = false; // Para o timer
                Destroy(spawnedObject, 0);
                hambpronto = true;
                hamburguerfritar = false; // Redefine a flag
            }

            // Atualiza o texto do timer
            UpdateTimerText();
        }

        if (hambpronto)
        {
            HamburguerPronto();
            hambpronto = false;
        }

    }

    // Atualiza o texto do timer
    void UpdateTimerText()
    {
        // Formata o tempo como "Min:Seg"
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void hamburguerfrigideira()
    {
        if(inventario.hamburguercru)
        {
            spawnedObject = Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation);
            hamburguerfritar = true;
            inventario.hamburguercru = false;
        }

    }

    void HamburguerPronto()
    {
        Instantiate(HambPronto, spawnPoint.position, spawnPoint.rotation);
    }

    public void HamburguerFeito()
    {
        Destroy(this.gameObject, 0);

        inventario.hamburguercozido = true;
    }

    public void PegarHamburguerCru()
    {
        inventario.hamburguercru = true;
    }

    public void PegarPao()
    {
        inventario.pao = true;
    }
    public void pegarQueijo()
    {
        inventario.queijo = true;
    }
}

