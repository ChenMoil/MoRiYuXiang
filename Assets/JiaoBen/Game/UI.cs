using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject light;
    public GameObject key;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playermove.tou == true)
        {
            light.SetActive(true);
        }
        else if(playermove.tou == false)
        {
            light.SetActive(false);
        }
        if (playermove.getkey == true)
        {
            key.SetActive(true);
        }
        else if (playermove.getkey == false)
        {
            key.SetActive(false);
        }
    }
}
