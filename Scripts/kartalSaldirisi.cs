using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartalSaldirisi : MonoBehaviour
{
    public Transform parilti;
    public GameObject[] vuruslar;
    // Start is called before the first frame update
    void Start()
    {
        parilti = GameObject.FindGameObjectWithTag("Parıltı").GetComponent<ParticleSystem>().transform;
        vuruslar = GameObject.FindGameObjectsWithTag("Kamburbalina");
    }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Neden battı?");
                foreach (GameObject all in vuruslar)
                {
                    if (all != null)
                    {
                        Debug.Log("Köşe başı beklerim vay benim emeklerim");
                    

                        Transform vuruslarim = Instantiate(parilti, transform.position, Quaternion.identity) as Transform; //Vuruşları buradan değerlendireceğiz.
                        vuruslarim.position = Vector3.MoveTowards(vuruslarim.position, all.transform.position, 5f * Time.deltaTime);
                        vuruslarim.rotation = Quaternion.RotateTowards(vuruslarim.rotation, all.transform.rotation, 5f * Time.deltaTime);
                    vuruslarim.transform.LookAt(all.transform); 
                        Destroy(vuruslarim.gameObject, 5f);
                    
                    }
                else
                {
                    Debug.Log("Boş değer");
                }
                }
            }

        }
    }

