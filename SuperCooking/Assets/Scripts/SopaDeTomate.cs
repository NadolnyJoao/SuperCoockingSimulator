using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SopaDeTomate : MonoBehaviour
{
    private Inventario inventario;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Player");
        if (obj != null)
        {
            inventario = obj.GetComponent<Inventario>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PegarSopaDeTomate()
    {
        inventario.sopadetomate = true;
    }
}
