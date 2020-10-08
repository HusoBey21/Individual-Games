using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpistik : MonoBehaviour

{
    public Text metin; //Metin 
    public int sayac;
    // Start is called before the first frame update
    void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Metin").GetComponent<Text>();
    }

    // Update is called once per frame
   void OnCollisionEnter2D(Collision2D carpisma)
    {
        if(carpisma.gameObject.tag=="Kamburbalina")
        {
            Debug.Log("Animasyonum yok maalesef");
            sayac += 1;
            metin.text = "Amount of Whale:" + sayac.ToString();
        }
    }
}
