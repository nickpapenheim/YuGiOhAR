using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonneneruptionsdracheImage : MonoBehaviour
{
    private bool sonnenEruptionsDrache;
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
        sonnenEruptionsDrache = FindObjectOfType<appData>().sonnenEruptionsDrache;
        if (sonnenEruptionsDrache) {
          img.material = noMaterial;
        }
    }
}
