using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucucu : MonoBehaviour
{
    public Transform ucan;
    void Start()
    {
        ucan = GameObject.FindGameObjectWithTag("DüşmanKartal").transform;
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(ucan); //Hedefe odaklandı
        Vector3 uzaklik = ucan.position - transform.position;
        transform.position += uzaklik * 5f;
        transform.rotation = Quaternion.Slerp(transform.rotation, ucan.rotation, 5f);
    }
}
