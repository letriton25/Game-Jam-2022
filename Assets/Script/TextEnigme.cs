
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;

    public class TextEnigme : MonoBehaviour
    {
        [SerializeField] 
        private TMP_Text _title;

        public void OnButtonClick()
        {
            if (_title != null)
            {
                if (_title.text.Length <= 9){
                    _title.text += "*";
                }
                else {
                    _title.text = "*";
                }
            }else {
                _title.text = string.Empty;
            }

        }
        public void OnButtonClickValidate() { 
            GameObject obj = GameObject.Find("Enigme");
            EnigmeHexa enigme = obj.GetComponent<EnigmeHexa>();
            if (enigme.validate()) {
                _title.text = "SUCCES   ";
            } 
            else {
                _title.text = "ECHEC     ";
            }
        }
    }