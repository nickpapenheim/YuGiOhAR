using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class appData : MonoBehaviour
{
    public bool wilderKaser = false;
    public bool sonnenEruptionsDrache = false;
    public bool boshaftePuppe = false;
    public Material grayScale;
    public Material noMaterial;
   void Awake(){
    noMaterial = Resources.Load("noMaterial", typeof(Material)) as Material;
   }
}
