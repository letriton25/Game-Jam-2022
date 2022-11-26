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
    int numberFromName() {
        string name = gameObject.name;
        int number = int.Parse(name.Substring(name.Length - 1));
        return number;
    }

    public void Trigger() {
        Debug.Log(combination);
        if (combination.Length < solution.Length - 1) { 
            combination[index] = numberFromName();
            index++;
        } 
    }

    public void validate() {
        if (combination.Length != solution.Length) {
            return;
        }
        for (int i=0; i < solution.Length; i++) {
            if (solution[i] != combination[i]) {
                Debug.Log("non");
            }
        }
        Debug.Log("oui");
    }

    
}
