using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kartalHareketi : MonoBehaviour
{
    public Transform av;
    public bool avlama;
    void Start()
    {
        av = GameObject.FindGameObjectWithTag("Kamburbalina").transform;
    }

    

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal") * 5f;
        float dusey = Input.GetAxis("Vertical") * 5f;
        transform.Translate(new Vector3(yatay, 0f, dusey));
      
         if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Aşağıya doğru");
            transform.Translate(Vector3.down*2.03f);
            if(avlama)
            {
                av.SetParent(this.transform, false); //Balinayı avlayabileceğini varsayıyorum.
            }

        }
         if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Yukarıya doğru");
            transform.Translate(Vector3.up*2.03f);
            if (!avlama)
            {
                av.SetParent(null);
            }

        }
         if(Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

    }

}
