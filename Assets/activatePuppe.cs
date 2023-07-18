using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class activatePuppe : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTargetFound() {
        FindObjectOfType<appData>().boshaftePuppe = true;
    }
}
