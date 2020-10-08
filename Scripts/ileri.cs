using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileri : MonoBehaviour
{
    public Transform genişleme;

    // Start is called before the first frame update
    void Start()
    {
        genişleme = GameObject.FindGameObjectWithTag("Resim").transform;
    }

    // Update is called once per frame
    void Update()
    {
       
            Debug.Log("Büyütme amaçlı hareket");
            genişleme.transform.localScale += Vector3.one * 2f;
        
    }
}
