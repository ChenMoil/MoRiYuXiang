using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shan1 : MonoBehaviour
{
    public GameObject wh;
    public GameObject re;
    public GameObject next;
    public GameObject nextpic;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shan(wh , re , next));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Shan(GameObject color ,GameObject color2 ,GameObject next)
    {
        color2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        color2.SetActive(true);
        yield return new WaitForSeconds(2f);
        nextpic.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        next.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        color2.SetActive(false);
        gameObject.SetActive(false);
    }
}
