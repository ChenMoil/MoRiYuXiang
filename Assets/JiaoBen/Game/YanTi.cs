using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YanTi : MonoBehaviour
{
    public BoxCollider2D yanticoli;  //掩体的碰撞体
    public BoxCollider2D playercoli; //玩家碰撞体
    public GameObject playersign;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "playerhide")
        {
            playercoli.enabled = false;
            playersign.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "playerhide")
        {
            playercoli.enabled = true;
            playersign.SetActive(false);
        }
    }
}
