using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyai5 : MonoBehaviour
{
    public float walkspeed;
    public float runspeed;
    public float walkTime;
    public float waitTime;
    public int face = -1;
    private float walknow;
    private float waitnow; 
    private int du = -1;
    private bool zhui = false;
    public BoxCollider2D shiye;
    public static bool yun = false;
    public Animator animator;
    public GameObject guang;
    void Update()
    {
        move(yun);
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.tag == "Player")
        {
            zhui = true;
        }
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            zhui = false;
        }
    }
    private void move(bool Yun)
    {
        if (Yun == false)
        {
            guang.SetActive(true);
            if (!zhui)
            {
                transform.Translate(new Vector3(walkspeed * Time.deltaTime * face, 0, 0));
                animator.SetBool("walk", true);
                walknow += Time.deltaTime;
                if (walknow > walkTime && face != 0)
                {
                    du = face;
                    du *= -1;
                    transform.localScale = new Vector3(du * -1, 1, 1);
                    face = 0;
                }
                if (walknow > walkTime)
                {
                    waitnow += Time.deltaTime;
                    animator.SetBool("walk", false);
                }
                if (waitnow > waitTime)
                {
                    face = du;
                    waitnow = 0;
                    walknow = 0;
                }
            }
            if (zhui)
            {
                transform.Translate(new Vector3(runspeed * Time.deltaTime * du, 0, 0));
            }
        }
        if (Yun == true)
        {
            guang.SetActive(false);
        }
    }
}
