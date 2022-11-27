using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TubeScript : MonoBehaviour
{
    public Canvas canvasDialogue;
    public Canvas canvasInside;
    public GameObject Cam;
    public GameObject Square;
    
    
    public Text TextBoxUI;

    private bool Collision = false;
    private bool Close_to_square = false;
    private bool Cancel_anim_done = false;
    private bool Diplay_dialogue = false;
    private bool Dialogue_finished = false;
    
    //--------------------------------------------------------------
    /*       max = aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa*/
    string text1 = "Bonjour habitant de Lineland, le monde à une dimension !!";
    string text2 = "Je me présente, je suis A.Square";
    string text3 = "Je viens de la dimension supérieure, le monde à 2 dimensions.";
    string text4 = "Veux-tu découvrir cette nouvelle dimension ?";
    string text5 = "Essaye de tourner à gauche et à droite.";
    string text6 = "Ahh oui c'est vrai, tu ne sais pas encore ce que ça veut dire.";
    string text7 = "Tu ne peux qu'avancer et reculer";
    string text8 = "Maintenant tu peux te déplacer dans d'autres directions ";
    string text9 = "(Appuyer flèche gauche/droite pour changer de direction)";


    string[] text11, text12, text13, text14, text15, text16, text17, text18;

    char[] separator = {' '};

    List<string[]> firstlist = new List<string[]>();

    
    private void Awake()
    {
        PlayerPrefs.SetInt("progress", 0);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        canvasDialogue.gameObject.SetActive(false);
        canvasInside.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Collision = false;
        
        if (Math.Abs(Cam.transform.position.z - Square.transform.position.z) < 7f)
        {
            Close_to_square = true;
            print("Close to square");
        }

        if ((Cam.transform.position.z - 2f > Square.transform.position.z - Square.transform.localScale.z) &&
            (Cam.transform.position.z - 2f < Square.transform.position.z + Square.transform.localScale.z))
        {
            Collision = true;
            print("Collision");
        }
        print("displaydialogue" + Diplay_dialogue);
        print("Dialogue_finished" + Dialogue_finished);

        if ((Diplay_dialogue == false) || (Dialogue_finished))
        {
            print("move");
            move();
        }

        if ((Close_to_square == true) && (Cancel_anim_done == false))
        {
            cancel_anim();
            Cancel_anim_done = true;
        }
        
        if ((Close_to_square == true) && (Diplay_dialogue == false))
        {
            //active canvasDialogue
            canvasDialogue.gameObject.SetActive(true);
            display_dialogue();
            Diplay_dialogue = true;
        }

        if (Collision == true)
        {
            //active canvasInside
            canvasDialogue.gameObject.SetActive(false);
            canvasInside.gameObject.SetActive(true);
            //desactive canvasDialogue
            GoToNextScene();
        }
    }

    private void move()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Cam.transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime, Space.World);
            print("Move forward");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Cam.transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime, Space.World);
            print("Move backward");
        }
    }

    private void cancel_anim()
    {
        Square.gameObject.GetComponent<Animator>().enabled = false;
        Square.transform.position = new Vector3(0f, 0f, 30f);
        print("Cancel Anim");
    }

    private void display_dialogue()
    {
        firstlist.Add(text1.Split(separator));
        firstlist.Add(text2.Split(separator));
        firstlist.Add(text3.Split(separator));
        firstlist.Add(text4.Split(separator));
        firstlist.Add(text5.Split(separator));
        firstlist.Add(text6.Split(separator));
        firstlist.Add(text7.Split(separator));
        firstlist.Add(text8.Split(separator));
        firstlist.Add(text9.Split(separator));

        StartCoroutine(DisplayText());
    }
    
    public IEnumerator DisplayText()
    {
        
        foreach (string[] phrase in firstlist)
        {
            string mot = " ";
            TextBoxUI.text = mot;

            foreach (string m in phrase)
            {
                
                mot += m + " ";
                yield return new WaitForSeconds(0.1f);
                TextBoxUI.text = mot;
            }

            yield return new WaitForSeconds(2.5f);

        }
        Dialogue_finished = true;
    }
    
    private void GoToNextScene()
    {
        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            StartCoroutine(SceneTransition());
        }
        
    }
    
    IEnumerator SceneTransition()
    {

        //Mettre le bon nom du menu

        AsyncOperation asyncload = SceneManager.LoadSceneAsync("2D_labyrinthe");
        while (!asyncload.isDone)
        {
            yield return null;
        }
        canvasInside.gameObject.SetActive(false);
    }
}
