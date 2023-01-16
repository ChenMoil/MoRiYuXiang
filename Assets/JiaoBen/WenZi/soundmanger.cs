using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanger : MonoBehaviour
{
    public static AudioSource audiosrc;
    public static AudioClip houjiao;
    public static AudioClip walk;
    public static AudioClip boli;
    void Start()
    {
        audiosrc = GetComponent<AudioSource>();
        houjiao = Resources.Load<AudioClip>("houj");
        walk = Resources.Load<AudioClip>("walk");
        boli = Resources.Load<AudioClip>("boli");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void hou()
    {
        audiosrc.PlayOneShot(houjiao);
    }
    public static void bolibreak()
    {
        audiosrc.PlayOneShot(boli);
    }
}
