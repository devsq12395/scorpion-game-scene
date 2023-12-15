using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB_Conditions : MonoBehaviour {

    public static DB_Conditions I;
	public void Awake(){ I = this; }
    
    // Controls
    public bool move_cond (InGameObject _obj) {
        if (_obj.isAtk)                             return false;
        if (is_a_ui_showing())                      return false;

        return true;
    }

    public bool atk_cond (InGameObject _obj) {
        if (_obj.isAtk)                             return false;
        if (is_a_ui_showing())                      return false;

        return true;
    }

    public bool coll_cond (InGameObject _obj) {
        if (_obj.isInvul)                                           return false;
        if (ContObj.I.get_has_buff (_obj, "invulnerable"))          return false;

        return true;
    }
    
    public bool coll_cond_missile (InGameObject _obj) {
        if (_obj.type == "missile" || _obj.type == "effect")                                 
            return false;
        
        return true;
    }
    
    public bool is_check_border (InGameObject _obj){
        if (!_obj.constMovDir_isOn)         return false;
        if (_obj.type != "unit")            return false;
        
        return true;
    }
    
    // UI
    public bool is_a_ui_showing (){
        if (GameUI_Inv.I.mode != "hide")            return true;
        if (GameUI_Upg.I.isShow)                    return true;
        if (GameUI_Equip.I.isShow)                  return true;
        
        return false;
    }
    
    // Battle
    public bool dam_condition (InGameObject _atk, InGameObject _def) {
        if (ContObj.I.get_has_buff (_def, "invulnerable"))                 return false;

        return true;
    }
    
    public bool can_change_char (int _cI){
        if (is_a_ui_showing())                      return false;
        
        if (ContPlayer.I.players [_cI] == null) return false;
        
        InGameObject _newChar = ContPlayer.I.players [_cI];
        if (_newChar.hp < 0) return false;
        
        return true;
    }
    
    public bool can_mp_regen (InGameObject _obj){
        if (_obj.mp >= _obj.mpMax) return false;
        
        return true;
    }
    
    public bool is_kill_on_border_pass (InGameObject _obj){
        if (_obj.type == "unit") return false;
        
        return true;
    }

}