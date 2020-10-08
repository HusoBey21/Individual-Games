using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solaDogru : MonoBehaviour
{
    public Vector3 vurun;
    // Start is called before the first frame update
    void Start()
    {
        vurun = transform.position;
        vurun.y = -0.29f;
        transform.position = vurun;
    }

    // Update is called once per frame
    void Update()
    {
          //Önceliğimiz y ekseni boyunca kaymayı engellemek.
        transform.position += Vector3.left * 2f*Time.deltaTime;
    }
}
