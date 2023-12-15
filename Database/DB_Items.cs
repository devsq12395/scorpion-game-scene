using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB_Items : MonoBehaviour {

    public static DB_Items I;
	public void Awake(){ I = this; }

    public Sprite dummy, test1, testSword;

    public struct Item {
        public string name, nameUI, equipType;
        public string desc;
        public Sprite sprite;
        public int stack, stackLim;

        public Item (string _name, Sprite _sprite){
            name = _name;
            nameUI = "";
            desc = "";
            equipType = "";
            sprite = _sprite;

            stack = 0;
            stackLim = 0;
        }
    }

    void Start() {
        
    }

    void Update() {
        
    }

    public Item get_item (string _name){
        Item _new = new Item ("", dummy);

        switch (_name) {
            case "sample1":
                _new.nameUI = "Sample 1";
                _new.desc = "";
                _new.equipType = "";
                _new.sprite = test1;
                
                _new.stackLim = 10;
                break;
                
            case "test sword":
                _new.nameUI = "Test Sword";
                _new.desc = "";
                _new.equipType = "weap";
                _new.sprite = testSword;
                
                _new.stackLim = 10;
                break;

            default:
                _new.nameUI = "Empty";
                _new.desc = "";
                _new.sprite = dummy;
                
                _new.stackLim = 0;
                break;
        }

        return _new;
    }
    
    public void select_item (Item _item, string _mode){
        switch (_item.name) {
            case "test sword":
                
                break;
        }
    }
}
