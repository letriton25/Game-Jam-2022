using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreateSeg : MonoBehaviour
{
    public bool firstClick = false;

    public bool secondClick = false;

    public GameObject segment;

    public int first;
    public int second;

    public bool[] answer = new bool[5];


    void Start()
    {
        answer = new bool[] {false, false, false, false, false};


    }

    public void ResetButton()
    {
        answer = new bool[] {false, false, false, false, false};
    }

    public void ButtonClicked(int val)
    {
        if (!firstClick)
        {
            print("first");
            firstClick = true;
            first = val;
        }
        else if (firstClick && !secondClick)
        {
            print("second");
            secondClick = true;
            second = val;

            if (first == second)
            {
                answer[val - 1] = true;
            }

            firstClick = false;
            secondClick = false;
        }
    }
    public void Button_1()
    {
        ButtonClicked(1);
    }
    public void Button_2()
    {
        ButtonClicked(2);
    }
    public void Button_3()
    {
        ButtonClicked(3);
    }
    public void Button_4()
    {
        ButtonClicked(4);
    }
    public void Button_5()
    {
        ButtonClicked(5);
    }
    
    
}
