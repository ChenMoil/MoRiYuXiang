using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class touzideng : MonoBehaviour
{
    public Rigidbody2D rgb;
    public int speedx;
    public int speedy;
    public GameObject tx;
    void Start()
    {
        rgb.velocity = new Vector2(speedx * playermove.touz, speedy);
    }
    private void Update()
    {
        Invoke("ds", 1f);
    }
    private void ds()
    {
        Destroy(gameObject);
        soundmanger.bolibreak();
    }
}
