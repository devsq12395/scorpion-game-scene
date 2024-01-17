using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MUI_CharPane : MonoBehaviour
{
    public static MUI_CharPane I;
    public void Awake() { I = this; }

    private struct Char {
        public Image port, hpBar, mpBar;

        public Char(Image _port, Image _hp, Image _mp){
            port = _port;
            hpBar = _hp;
            mpBar = _mp;
        }
    };

    public GameObject go;
    public List<Char> chars;

    public void setup (){
        go.SetActive (true);

        chars = new List<Char>();
        chars.Add ();

        go.SetActive (false);
    }

    private Char create_char (int _num){
        
    }
}
