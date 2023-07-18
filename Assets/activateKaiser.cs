using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class activateKaiser : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTargetFound() {
        FindObjectOfType<appData>().wilderKaser = true;
    }
}
