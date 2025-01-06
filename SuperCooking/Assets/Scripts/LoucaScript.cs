using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoucaScript : MonoBehaviour

{
    public Slider slider;
    int progress;
    public GameObject interactionText;
    public GameObject interactionSlider;
    public GameObject interactionWater;
    public GameObject interactionPrato;
    public GameObject interactionPratoLavado;
    public GameObject interactionPenela;
    public GameObject interactionPenelaLavado;
    public GameObject interactionEsponja;
    public Animator animator;
    public bool PodeLavaraLouca;
    public bool PodeSopa = false;
    

    
    
    // Start is called before the first frame update
    void Start()
    {
        interactionSlider.SetActive(false);
        interactionWater.SetActive(false);
        interactionPrato.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    } 
    public void ProgressLavando()
    {  
        if(PodeLavaraLouca == true)
        {
            progress++;
            slider.value = progress;
            interactionText.SetActive(false);
            interactionSlider.SetActive(true);
            interactionWater.SetActive(true);
            interactionEsponja.SetActive(true);
            animator.SetTrigger("Open");
        }

        if(progress == 1)
        {
        interactionPrato.SetActive(true);
        
        }
        
        

        if(progress == 5)
        {
            interactionPrato.SetActive(false);
            interactionPratoLavado.SetActive(true);
            interactionPenela.SetActive(true);
        }
        if(progress == 10)
        {
            interactionPenela.SetActive(false);
            interactionPrato.SetActive(false);
            interactionPenelaLavado.SetActive(true);
            interactionWater.SetActive(false);
            interactionSlider.SetActive(false);
            interactionEsponja.SetActive(false);
            PodeSopa = true;
             

        }



     
    }
}
