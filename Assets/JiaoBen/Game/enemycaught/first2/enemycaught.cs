using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemycaught : MonoBehaviour
{
    public BoxCollider2D box1; //caught的触发器
    public float xuanyuntime; //设置眩晕时间
    public float yuntime = 0; //计算已经眩晕的时间
    public GameObject ui;
    public GameObject player1;
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.tag == "Player")
        {
            ui.SetActive(true);
            player1.SetActive(false);
        }
        if (player.tag == "deng")
        {
            enemyai.yun = true;
            box1.enabled = false;
        }
    }
    private void Update()
    {
        if (enemyai.yun == true)
        {
            yuntime += Time.deltaTime;
            if (yuntime >= xuanyuntime)
            {
                box1.enabled = true;
                enemyai.yun = false;
                yuntime = 0;
            }
        }
    }
}
