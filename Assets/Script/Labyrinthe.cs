using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Labyrinthe : MonoBehaviour
{
    public GameObject wall;

    public GameObject ground;
    
    public string[] lines;

    public Vector3 position;

    [SerializeField] private string m_mazeName = "Saved_labyrinthe";
    
    // Start is called before the first frame update
    void Start()
    {
        // Load the .txt from resources
        TextAsset textAsset = Resources.Load<TextAsset>(m_mazeName);
        
        // Split on the line return
        lines = textAsset.text.Split('\n');

        int size_map = lines[0].Length;


        for (int l = 0; l < size_map; l++)
        {
            string sequence = lines[l];

            for (int c = 0; c < size_map; c++)
            {
                GameObject obj;
                if (sequence[c].Equals('1'))
                {
                    obj = Instantiate(wall); //Entre sur scène
                    
                    obj.transform.parent = gameObject.transform;  //Bon dossier

                    position.x = (l * (Constants.CaseSize )) - Constants.MapWidth * Constants.CaseSize / 2 + Constants.CaseSize / 2;
                    position.y = 1f;
                    position.z = (c/2 * (Constants.CaseSize )) - Constants.MapHeight * Constants.CaseSize / 2 + Constants.CaseSize / 2;
                    
                    obj.transform.position = position;
                }
                /*else
                {
                    obj = Instantiate(ground); //Entre sur scène
                }*/
                
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
