using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class suo2 : MonoBehaviour
{
    public GameObject text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            text.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            {
                text.SetActive(false);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && playermove.getkey == true)
        {
            playermove.getkey = false;
            text.SetActive(false);
            SceneManager.LoadScene("end");
        }
    }
}
