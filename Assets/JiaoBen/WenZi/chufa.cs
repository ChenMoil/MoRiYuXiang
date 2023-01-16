using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chufa : MonoBehaviour
{
    public GameObject shuxing1;
    public GameObject shuxing2;
    public GameObject next;
    void Start()
    {
        Invoke("s1", 0.1f);
        Invoke("s2", 3f);
        Invoke("gonext", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void s1()
    {
        shuxing1.SetActive(false);
    }
    private void s2()
    {
        shuxing2.SetActive(true);
    }
    private void gonext()
    {
        next.SetActive(true);
    }

}
