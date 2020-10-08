using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genisleme : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Sürekli büyü");
        transform.localScale += new Vector3(Random.Range(0f, 2f), 0f, 0f);
    }
}
