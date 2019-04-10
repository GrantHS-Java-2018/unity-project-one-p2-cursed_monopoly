using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RollButton : MonoBehaviour
{
    //public static Boolean rollButton = false;
    public Boolean rollButtonPress = false;
    public Boolean pressRoll = false;
    private int button;
    public Button m_YourFirstButton;
    public GameObject dice1, dice2;

    // Start is called before the first frame update
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
       // button.onClick.AddListener(Dice, Dice2);
    }
    void TaskOnClick()
    {
     
        rollButtonPress = true;
        //Output this to console when Button1 or Button3 is clicked
        StartCoroutine(dice1.GetComponent<Dice>().Roll());
        StartCoroutine(dice2.GetComponent<Dice>().Roll());
        Debug.Log("You have clicked the button!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
