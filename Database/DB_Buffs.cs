using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB_Buffs : MonoBehaviour {

    public static DB_Buffs I;
	public void Awake(){ I = this; }

    void Start() {
        
    }

    void Update() {
        
    }

    public ContBuffs.buff get_buff_data (string _name) {
        ContBuffs.buff _new = new ContBuffs.buff (_name);
        _new.dur = get_buff_data_dur (_name);

        string _atchName = (get_buff_has_attach (_name) ? "buffAtch_" + _name : "dummy");
        _new.attach = DB_Objects.I.get_game_obj (_atchName);

        return _new;
    }

    public float get_buff_data_dur (string _name){
        switch (_name) {
            case "invulnerable": return 0.5f;
            case "molotov": return 1f;
            default: return 1f;
        }
    }

    public bool get_buff_has_attach (string _name) {
        switch (_name) {
            default: return false;
        }
    }
}
