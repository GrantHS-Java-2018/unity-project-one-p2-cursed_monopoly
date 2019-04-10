using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;
using Random = System.Random;
public class Dice2 : MonoBehaviour
{   
    [SerializeField]private Sprite[] dieFace2;

    public int value;
    // Start is called before the first frame update
    void Awake ()
    {

    }
    void Start()
    {
        
        StartCoroutine(Roll2());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Roll2()
    {
        for (int i = 0; i < 20; i++)
        {
            var randNum = new Random();
            int num = randNum.Next(1, 7);
            GetComponent<SpriteRenderer>().sprite = dieFace2[num - 1];
            value = num;
            yield return new WaitForSeconds(.15f);
            //StartCoroutine(Roll2());
        }
    }
}