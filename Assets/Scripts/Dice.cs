using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Dice : MonoBehaviour
{   
    [SerializeField]private Sprite[] dieFace;

    public int value;
    // Start is called before the first frame update
    void Awake ()
    {

    }
    void Start()
    {
        StartCoroutine(Roll());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Roll()
    {
        var randNum = new Random();
        int num =randNum.Next(1, 7);
        GetComponent<SpriteRenderer>().sprite = dieFace[num - 1];
        value = num;
        yield return new WaitForSeconds(.15f);
        StartCoroutine(Roll());
    }
}
