using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmeHexa : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] combination;
    public int[] solution = {1,2,7,2,5,5,2,1,2};
    private int index = 0;

    public GameObject door;
    public Canvas canvas;

    public void Start() {
        Debug.Log("ahhhh");
        combination = new int[9];
    }
    int numberFromName(string name) {
        return int.Parse(name);
    }

    public void Trigger(string name) {
        if (index < solution.Length) { 
            combination[index] = numberFromName(name);
            
        } else {
            index = 0;
            combination = new int[9];
            combination[index] = numberFromName(name);
        }
        index++;
    }

    public void DestroyWall()
    {
        Validate();
    }

    public bool Validate() {
        if (index != solution.Length) {
            print(index);
            print(solution.Length);
            return false;
        }
        for (int i=0; i < solution.Length; i++) {
            if (solution[i] != combination[i]) {
                return false;
            }
        }
        door.SetActive(false);
        canvas.gameObject.SetActive(false);
        return true;
    }

    
}
