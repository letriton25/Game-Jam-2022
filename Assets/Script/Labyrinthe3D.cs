using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Labyrinthe3D : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject wall;

    public string[] lines;


    [SerializeField] private string m_mazeName = "Saved_labyrinthe";
    
    void Start()
    {

        Random.seed = 1234;
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
                
                if (sequence[c].Equals('1'))
                {
                    Vector3 position;
                    Vector3 scale;
                    
                    // Compute position
                    float height = Random.Range(1f, 100f);
                    position.x = (l * (Constants.CaseSize )) - Constants.MapWidth * Constants.CaseSize / 2 + Constants.CaseSize / 2;
                    position.y = height / 2;
                    position.z = (c/2 * (Constants.CaseSize )) - Constants.MapHeight * Constants.CaseSize / 2 + Constants.CaseSize / 2;
                    
                    // Compute scale
                    scale = new Vector3(1f, height, 1f);
                    
                    GameObject obj = Instantiate(wall, position, Quaternion.identity); //Entre sur scène
                    obj.transform.localScale = scale;
                    
                    obj.transform.parent = gameObject.transform;  //Bon dossier
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
