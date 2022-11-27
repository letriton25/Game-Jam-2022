using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeHexa : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] combination;
    public int[] solution = {1,2,7,2,5,5,2,1,2};
    private int index = 0;

    public void Start() {
        Debug.Log("ahhhh");
        combination = new int[9];
    }
    int numberFromName(string name) {
        return int.Parse(name);
    }

    public void Trigger(string name) {
        if (index < solution.Length - 1) { 
            combination[index] = numberFromName(name);
            
        } else {
            index = 0;
            combination[index] = numberFromName(name);
        }
        index++;
    }

    public bool validate() {
        if (index != solution.Length) {
            return false;
        }
        for (int i=0; i < solution.Length; i++) {
            if (solution[i] != combination[i]) {
                return false;
            }
        }
        return true;
    }

    
}
