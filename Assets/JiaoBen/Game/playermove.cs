using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class playermove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator ani;
    public LayerMask grd;
    public LayerMask df;
    public BoxCollider2D coli;
    public BoxCollider2D coli1;
    public GameObject deng;
    public float speed;
    public float jump;
    private float direction; //�����ƶ�����
    public static float touz; //����Ͷ������
    public static float face; //������������
    public GameObject ph;
    public static bool tou = false; //�����ܲ���Ͷ��
    public static bool getkey = false; //����Ƿ��õ���Կ�� 
    private int jumptimes = 0;
    private void Start()
    {
        tou = true;
        getkey = false; 
    }
    void Update()
    {
        move();
        touzi();
    }

    void move()
    {
        direction = Input.GetAxis("Horizontal");  //-1��1
        face = Input.GetAxisRaw("Horizontal");  //-1 0 1
        rb.velocity = new Vector2(direction * speed , rb.velocity.y); //��ɫ�ƶ�
        ani.SetFloat("runspeed", Mathf.Abs(direction));  //�л�����
        if (face != 0)
        {
            transform.localScale = new Vector3(face , 1f, 1f); //�ı䳯��
        }
        if (Input.GetButtonDown("Jump")) //��ɫ��Ծ
        {
            if(jumptimes <= 0)
            {
                ani.SetBool("jump", true);
                ani.SetBool("idot", false);
                jumptimes++;
                rb.velocity = new Vector2(rb.velocity.x, jump);
            }
        }
        if(rb.velocity.y < 0 || coli.IsTouchingLayers(df))
        {
            ani.SetBool("fall", true);
        }
        if (coli.IsTouchingLayers(grd) || coli1.IsTouchingLayers(grd))
        {
            ani.SetBool("jump", false);
            ani.SetBool("fall", false);
            ani.SetBool("idot", true);
            jumptimes = 0;
        }
        if(tou == true)
        {
            ani.SetBool("pick", true);
            deng.SetActive(true);
        }
        else if(tou == false)
        {
            ani.SetBool("pick", false);
            deng.SetActive(false);
        }
    }
    void touzi() //����Ͷ��
    {
        if (Input.GetKeyUp(KeyCode.F) && tou == true && rb.velocity.x == 0)
        {
            ani.SetBool("pick", false);
            Invoke("tou2", 0.7f);
            tou = false;
        }
    }
    void tou2()
    {
        GameObject obj = Instantiate(ph, transform);
        obj.transform.position = new Vector2(this.transform.position.x + (1 * transform.localScale.x), this.transform.position.y);
        touz = transform.localScale.x;
        obj.transform.parent = null;
    }
}
