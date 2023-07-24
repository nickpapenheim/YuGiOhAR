using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonneneruptionsdracheImage : MonoBehaviour
{
    private bool sonnenEruptionsDrache;
    private Material grayScale;
    private Material noMaterial;
    private GameObject imageMaterial;
    
    // Start is called before the first frame update
    void Start()
    {
        grayScale = FindObjectOfType<appData>().grayScale;
        noMaterial = FindObjectOfType<appData>().noMaterial;
        imageMaterial = GameObject.Find("Library/sonneneruptionsdrache");
    }

    // Update is called once per frame
    void Update()
    {
        sonnenEruptionsDrache = FindObjectOfType<appData>().sonnenEruptionsDrache;
        if (sonnenEruptionsDrache) {
          //  imageMaterial.Image.Material = noMaterial;
          //  imageMaterial.
        }
    }
}
