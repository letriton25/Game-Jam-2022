using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class EnigmeHexa : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] combination;
    public int[] solution= {1,2,7,2,5,5,2,1,2};
    private int index = 0;
    [SerializeField]
    private TMP_Text textComponent;

    void printArray() { 
        string s = "[";
        for (int i = 0; i < combination.Length; i++) {
            s += combination[i] + ", ";
        }
        s+= "]";
        //Debug.Log(s);
    }

    public void Start() {
        Debug.Log("ahhhh");
        combination = new int[9];
        textComponent = GameObject.Find("PTN").GetComponent<TMP_Text>();
    }
    int numberFromName(string name) {
        //Debug.Log(name);
        return int.Parse(name);
    }

    public void Trigger(string name) {
        
        if (index < solution.Length ) { 
            combination[index] = numberFromName(name);
            textComponent.text += "*";
        }
        else {
            index = 0;
            combination[index] = numberFromName(name);
            textComponent.text = "*";
        }
        index++;
        //printArray();
        //Debug.Log(solution.Length);
    }
    
    public bool validate() {
        if (index != solution.Length) {
            return false;
        }
        for (int i=0; i < solution.Length; i++) {
            if (solution[i] != combination[i]) {
                return false;
                //GameObject dia = Instantiate()
            }
        }
        return true;
    }

    
}
