using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public static Game I;
	public void Awake(){ I = this; }
    
    public bool gameReady = false;

    void Start() {
        // PlayerPrefs for testing
        PlayerPrefs.SetString ("map", "testMap");
        PlayerPrefs.SetString ("player_charName1", "hero");
        PlayerPrefs.SetString ("player_charName2", "anastasia");
        PlayerPrefs.SetString ("player_charName3", "");
        PlayerPrefs.SetString ("player_charName4", "");
        PlayerPrefs.SetInt ("player_charSel", 0);
        for (int h = 1; h <= 4; h++) {
            PlayerPrefs.SetString ("player_charName" + h.ToString () + "_wpn", "test sword");
            PlayerPrefs.SetString ("player_charName" + h.ToString () + "_armr", "");
            PlayerPrefs.SetString ("player_charName" + h.ToString () + "_acc1", "");
            PlayerPrefs.SetString ("player_charName" + h.ToString () + "_acc2", "");
        }

        PlayerPrefs.SetString ("Item1", "sample1");
        PlayerPrefs.SetInt ("Item1_Stack", 5);
        for (int i = 2; i <= 20; i++) {
            PlayerPrefs.SetString ("Item" + i.ToString (), "");
            PlayerPrefs.SetInt ("Item" + i.ToString () + "_Stack", 0);
        }
        
        // Setups
        ContMap.I.setup_map ();
        ContPlayer.I.setup_player ();
        GameUI_InGameTxt.I.setup ();
        MUI_CharPane.I.setup ();
        
        gameReady = true;
    }

    void Update() {
        if (!gameReady) return;
        
        ContPlayer.I.update ();
        
        MUI_HPBars.I.update_bars ();
    }

    // Accesibility
    public GameObject get_player_obj (){
        return ContPlayer.I.player.gameObject;
    }

    // Scenes
    public void change_scene (string _scene){
        Transition_Game.I.change_scene (_scene);
    }
}
