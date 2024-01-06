using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI_Inv : MonoBehaviour
{
    
    public static GameUI_Inv I;
	public void Awake(){ I = this; }

    public GameObject go;
    public TextMeshProUGUI tPage;
    public int NUMBER_OF_BUTTONS;
    public List<Button> buttons;
    public List<TextMeshProUGUI> btnTxt;
    
    public int pageCur, pageMax;
    public int NUM_OF_ITEMS_PER_PAGE;
    
    public string mode = "check";
        // Modes:
        // "hide" = UI is not showing
        // "check" = checking the inventory
        // "equip" = selecting an equippable item from the inventory

    void Start() {
        go.SetActive (true);

        

        go.SetActive (false);
    }

    void Update() {
        
    }
    
    public void show (string _mode){
        mode = _mode;
        go.SetActive (true);
        refresh_ui_list ();
    }

    public void hide (){
        go.SetActive (false);
        mode = "hide";
    }
    
    // UI Manipulation
    public void switch_page (int _inc){
        pageCur += _inc;
        if (pageCur > pageMax)  pageCur = 0;
        if (pageCur < 0)        pageCur = pageMax;
    }
    
    public void refresh_ui_list (){
        List<DB_Items.Item> _items = ContPlayer.I.items;
        int _pI = (NUM_OF_ITEMS_PER_PAGE * pageCur) + NUMBER_OF_BUTTONS;
        pageMax = (_items.Count - 1) / NUM_OF_ITEMS_PER_PAGE + 1;
        
        for (int i = NUM_OF_ITEMS_PER_PAGE * pageCur; i < _pI; i++){
            DB_Items.Item _item = _items [i];

            btnTxt [i].text = _item.nameUI;
        }
        
        tPage.text = pageCur.ToString () + "/" + pageMax.ToString ();
    }
    
    public void select_item (int _btnInd){
        int _itemNum = (NUM_OF_ITEMS_PER_PAGE * pageCur) + _btnInd;
        GameUI_ChkItm.I.show (_items [_itemNum]);
    }
}
