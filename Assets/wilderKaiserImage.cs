using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wilderKaiserImage : MonoBehaviour
{
    private bool wilderKaser;
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
        wilderKaser = FindObjectOfType<appData>().wilderKaser;
        if (wilderKaser) {
          img.material = noMaterial;
          butt.enabled = true;
        }
    }
}
