using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canlar : MonoBehaviour
{
    public float can = 100f;
    
    public void hasar(float kayip)
    {
        can -= kayip;
        if(can <=0)
        {
            can=0f;
            Destroy(this.gameObject);
        }
    }
}
