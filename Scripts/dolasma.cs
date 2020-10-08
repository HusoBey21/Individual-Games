using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dolasma : MonoBehaviour
{
    public Transform nesne;
    void Start()
    {
        nesne = GameObject.FindGameObjectWithTag("Resim").transform;
    }
   void Update()
    {
        this.transform.SetParent(nesne, false);
        transform.position += Vector3.right * 2f*Time.deltaTime;
        if(Vector3.Distance(nesne.position,transform.position) <=3f)
        {
            transform.position += Vector3.left * 2f*Time.deltaTime;
        }
    }
    void OnCollisionEnter2D(Collision2D asd)
    {
        if(asd.gameObject.tag != "Kamburbalina")
        {
            asd.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
