using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boshaftePuppeImage : MonoBehaviour
{
    private bool boshaftePuppe;
    private Material noMaterial;
    private Image img;
    
    // Start is called before the first frame update
    void Start()
    {
        noMaterial = FindObjectOfType<appData>().noMaterial;
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        boshaftePuppe = FindObjectOfType<appData>().boshaftePuppe;
        if (boshaftePuppe) {
          img.material = noMaterial;
        }
    }
}
