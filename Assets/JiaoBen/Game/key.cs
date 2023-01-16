using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject text; //∞¥º¸Ã· æ
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            text.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            {
                text.SetActive(false);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && text.active == true)
        {
            playermove.getkey = true;
            text.SetActive(false);
            Destroy(gameObject);
        }
    }
}
