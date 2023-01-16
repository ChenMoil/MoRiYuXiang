using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShiPing : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeq;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeq += Time.deltaTime;
        if(timeq > 30f)
        {
            SceneManager.LoadScene("WenZi");
        }
    }
}
