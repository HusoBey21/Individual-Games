using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hedefeZarar : MonoBehaviour
{
    public Transform vurus;
    public Text metin;
    public int sayac;

   void Start()
    {
      
        metin = GameObject.FindGameObjectWithTag("Yenimetin").GetComponent<Text>();
        sayac = 0;
    }
    
    void OnCollisionEnter2D(Collision2D carpisma)
    {
        if(carpisma.gameObject.tag=="Kamburbalina")
        {
            Debug.Log("İkindiyin saat beşte");
            
            carpisma.gameObject.GetComponent<canlar>().hasar(10f); //Her vuruşta 10f hasar verecek.
            if(carpisma.gameObject.GetComponent<canlar>().can <= 0f)
            {
                sayac += 1;
            }
        }
    }
    void Update()
    {
        metin.text = "Among of Dead Whales:" + sayac.ToString();
    }
}
