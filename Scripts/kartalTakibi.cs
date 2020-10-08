using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartalTakibi : MonoBehaviour
{
    public Transform hedefler;
    void Start()
    {
        hedefler = GameObject.FindGameObjectWithTag("Seçkinkartal").transform; //Hedefi takip edecek
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(hedefler);
        transform.position = Vector3.MoveTowards(transform.position, hedefler.position, 0f);
        
    }
}
