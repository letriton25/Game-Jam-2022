using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCreateSeg : MonoBehaviour
{
    public GameObject door;
    
    public bool firstClick = false;

    public bool secondClick = false;

    public Image segment;

    public int first;
    public int second;

    public Vector2 firstPos;
    public Vector2 secondPos;

    public bool[] answer = new bool[5];

    public Color[] color;
    public int count;
    


    void Start()
    {
        answer = new bool[] {false, false, false, false, false};

        color = new Color[] {Color.blue, Color.green, Color.yellow, Color.magenta, Color.cyan};
        count = 0;

        //side = new int[] {-72, 78};
        //lines = new int[] {85, 40, -5, -50, -95};
    }

    public void ResetButton()
    {
        answer = new bool[] {false, false, false, false, false};
        
        foreach (Transform child in gameObject.transform) {
            GameObject.Destroy(child.gameObject);
        }

        count = 0;
    }

    public bool CheckAnswers()
    {
        foreach (bool response in answer)
        {
            if (!response)
            {
                return false;
            }
        }

        return true;
    }


    public void CreatePoint(Vector2 pos)
    {
        Vector3 vect = new Vector3();

        vect.x = pos.x;
        vect.y = pos.y;
        vect.z = 1;

        Image obj = Instantiate(segment, vect, Quaternion.identity);
        
        obj.color = color[count];

        obj.transform.SetParent (gameObject.transform, false);
    }

    public void ButtonClicked(int val, Vector2 pos)
    {
        if (!firstClick)
        {
            print("first");
            firstClick = true;
            firstPos = pos;
            first = val;
            CreatePoint(firstPos);
        }
        else if (firstClick && !secondClick)
        {
            print("second");
            secondClick = true;
            second = val;
            secondPos = pos;
            CreatePoint(secondPos);
            
            if (first == second)
            {
                answer[val - 1] = true;
            }

            count += 1;
            firstClick = false;
            secondClick = false;

            if (count >= 4)
            {
                bool res = CheckAnswers();

                if (res)
                {
                    GameObject.Destroy(door);
                }
            }
        }
    }
    public void Button_1()
    {
        ButtonClicked(1, new Vector2(-72, 85));
    }
    public void Button_2()
    {
        ButtonClicked(2, new Vector2(-72, 40));
    }
    public void Button_3()
    {
        ButtonClicked(3, new Vector2(-72, -5));
    }
    public void Button_4()
    {
        ButtonClicked(4, new Vector2(-72, -50));
    }
    public void Button_5()
    {
        ButtonClicked(5, new Vector2(-72, -95));
    }
    public void Button_1_right()
    {
        ButtonClicked(1, new Vector2(78, 85));
    }
    public void Button_2_right()
    {
        ButtonClicked(2, new Vector2(78, 40));
    }
    public void Button_3_right()
    {
        ButtonClicked(3, new Vector2(78, -5));
    }
    public void Button_4_right()
    {
        ButtonClicked(4, new Vector2(78, -50));
    }
    public void Button_5_right()
    {
        ButtonClicked(5, new Vector2(78, -95));
    }
}
