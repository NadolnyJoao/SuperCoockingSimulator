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
        progress++;
        slider.value = progress;
        interactionText.SetActive(false);
        interactionSlider.SetActive(true);
        interactionWater.SetActive(true);
        interactionPrato.SetActive(true);



    } 

}
