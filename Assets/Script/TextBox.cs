using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    /*       max = aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa*/
    string text1 = "Bonjour habitant de Lineland, le monde à une dimension !!";
    string text2 = "Je me présente, je suis A.Square";
    string text3 = "Je viens de la dimension supérieure, le monde à 2 dimensions.";
    string text4 = "Veux-tu découvrir cette mouvelle dimension ?";
    string text5 = "ENTRE dans mon corps et tu pourras découvrir de nouvelles directions !!";
    string text6 = "Tu ne pouvais qu'avancer et reculer";
    string text7 = "Maintenant tu peux te déplacer dans d'autres directions ";
    private string text8 = "(Appuyer flèche gauche/droite pour changer de direction)";


    string[] text11, text12, text13, text14, text15, text16, text17;

    char[] separator = {' '};

    List<string[]> firstlist = new List<string[]>();

    public Text TextBoxUI;
    
    private void Awake()
    {
        PlayerPrefs.SetInt("progress", 0);
    }


    // Start is called before the first frame update
    void Start()
    {
        firstlist.Add(text1.Split(separator));
        firstlist.Add(text2.Split(separator));
        firstlist.Add(text3.Split(separator));
        firstlist.Add(text4.Split(separator));
        firstlist.Add(text5.Split(separator));
        firstlist.Add(text6.Split(separator));
        firstlist.Add(text7.Split(separator));

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
                print(mot);
            }

            yield return new WaitForSeconds(2.5f);
        }
        
    }
}