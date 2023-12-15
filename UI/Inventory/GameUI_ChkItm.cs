using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI_ChkItm : MonoBehaviour
{
    
    public static GameUI_ChkItm I;
	public void Awake(){ I = this; }

    public GameObject go;
    
    public string item;

    void Start() {
        go.SetActive (true);

        

        go.SetActive (false);
    }

    void Update() {
        
    }
    
    public void show (string _mode){
        go.SetActive (true);
    }

    public void hide (){
        go.SetActive (false);
    }
}
