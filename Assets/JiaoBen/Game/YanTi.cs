using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YanTi : MonoBehaviour
{
    public BoxCollider2D yanticoli;  //�������ײ��
    public BoxCollider2D playercoli; //�����ײ��
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
