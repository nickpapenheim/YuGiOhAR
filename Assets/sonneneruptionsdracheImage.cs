using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sonneneruptionsdracheImage : MonoBehaviour
{
    private bool sonnenEruptionsDrache;
    private Material noMaterial;
    private Image img;
    private Button butt;
    
    // Start is called before the first frame update
    void Start()
    {
        noMaterial = FindObjectOfType<appData>().noMaterial;
        img = GetComponent<Image>();
        butt = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        sonnenEruptionsDrache = FindObjectOfType<appData>().sonnenEruptionsDrache;
        if (sonnenEruptionsDrache) {
          img.material = noMaterial;
          butt.enabled = true;
        }
    }
}
