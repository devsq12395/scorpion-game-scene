using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB_Buffs : MonoBehaviour {

    public static DB_Buffs I;
	public void Awake(){ I = this; }

    public ContBuffs.buff get_buff_data (string _name) {
        ContBuffs.buff _new = new ContBuffs.buff (_name);
        _new.dur = get_buff_data_dur (_name);

        string _atchName = (get_buff_has_attach (_name) ? "buffAtch_" + _name : "dummy");
        _new.attach = DB_Objects.I.get_game_obj (_atchName);

        return _new;
    }

    public float get_buff_data_dur (string _name){
        switch (_name) {
            case "invulnerable": return 0.5f; break;
            case "molotov": return 1f; break;
            case "grounded": return 1f; break;
            case "burn": return 4f; break;
            case "burned": return 1f; break;
            default: return 1f; break;
        }
    }

    public bool get_buff_has_attach (string _name) {
        switch (_name) {
            case "burn": 
                return true;
                break;
            default: return false; break;
        }
    }
    
    public void update_buff_trigger (InGameObject _obj, string _buff){
        switch (_buff) {
            case "burn":
                if (ContObj.I.get_has_buff (_obj, "burned")) return;
                
                ContDamage.I.lose_hp (_obj, 1);
                ContBuffs.I.add_buff (_obj, "burned");
                break;
        }
    }
}
