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
   //  public GameObject wilderKaiserImage = GameObject.Find("wilderKaiser");
   //  public GameObject sonnenEruptionsDracheImage = GameObject.Find("sonneneruptionsdrache");
   //  public GameObject boshaftePuppeImage = GameObject.Find("boshaftePuppe");
   // void Start() {
   // wilderKaiserImage = GameObject.Find("wilderKaiser");
   // sonnenEruptionsDracheImage = GameObject.Find("sonneneruptionsdrache");
   // boshaftePuppeImage = GameObject.Find("boshaftePuppe");
   // grayScale = Resources.Load("grayScale", typeof(Material)) as Material;
   // noMaterial = Resources.Load("noMaterial", typeof(Material)) as Material;
   // }
   void Awake(){
    noMaterial = Resources.Load("noMaterial", typeof(Material)) as Material;
    grayScale = Resources.Load("grayScale", typeof(Material)) as Material;
   }
}
