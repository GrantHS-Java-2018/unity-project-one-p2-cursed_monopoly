using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Dice : MonoBehaviour
{   
    [SerializeField]private Sprite[] dieFace;
    //[SerializeField] private Button button;
    public int value;

   

    // Start is called before the first frame update
    void Awake ()
    {

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // if (rollButtonPress == true)
      //  {
            //StartCoroutine(Roll());
       // }
    }


    public IEnumerator Roll()
    {
        for (int i = 0; i < 20; i++)
        {
            int num = Random.Range(0, 6) + 1;
            GetComponent<SpriteRenderer>().sprite = dieFace[num - 1];
            value = num;
            yield return new WaitForSeconds(.15f);
        }
    }
}
