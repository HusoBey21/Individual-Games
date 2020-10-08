using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    public Transform hedefAlani,solSinir,resim;
    public Vector3 vurdularBeni;
    public bool resimUstu;
    public bool solda;
    void Start()
    {
        hedefAlani = GameObject.FindGameObjectWithTag("Nesne").transform;
        solSinir = GameObject.FindGameObjectWithTag("Sol").transform;
        resim = GameObject.FindGameObjectWithTag("Resim").transform;
        vurdularBeni = transform.position;
    }
    void FixedUpdate()
    {
        solda = true;
        
        if (resimUstu)
        {
            Debug.Log("Zara-Sivas");
            this.transform.SetParent(resim, false); //Çocuk haline getirmeye çalışıyoruz.
            transform.LookAt(hedefAlani);
            if (solda)
            {
                transform.position = Vector3.right * 2f;
                transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
            }
            else
            {
                transform.position = Vector3.left * 2f;
                transform.rotation = Quaternion.Euler(0f, (transform.eulerAngles.y + 180f), 0f); 
            }
            
        }
        else
        {
            transform.position = Vector3.zero; //Resmin ortasına gelir.
        }
    }
    void OnCollisionEnter2D(Collision2D carpistirici)
    {
        if(carpistirici.gameObject.tag=="Basamak")
        {
            Debug.Log("Yukarıya çık");
            transform.position += Vector3.up * 5f; //Yukarıya doğru hareketlenme sağlar;
        }
        if(carpistirici.gameObject.tag=="Duvar")
        {
            solda = false;
            Debug.Log("Sağdan sola");
          
            
        }
        if(carpistirici.gameObject.tag=="Sol")
        {
            solda = true;
            Debug.Log("Soldan sağa");
            transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
            
        }
        if(carpistirici.gameObject.tag=="Resim")
        {
            Debug.Log("Resim üstünde fener");
            resimUstu = true;
        }
    }
  

}
