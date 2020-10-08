using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform hedef;
    public Vector3 calisma;
    public float surat;
    void Start()
    {
        hedef = GameObject.FindGameObjectWithTag("Seçkinkartal").transform;
        calisma = new Vector3(0f, 7f, 8f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float asd = Input.GetAxis("Horizontal");
        Vector3 aci = Quaternion.AngleAxis(asd*surat, Vector3.up) *calisma;
        transform.position += aci + hedef.position;
        transform.LookAt(hedef);
        
    }
}
