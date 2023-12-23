using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContDamage : MonoBehaviour {

    public static ContDamage I;
	public void Awake(){ I = this; }

    public void damage (InGameObject _atk, InGameObject _def, int _damOrig, List<string> _tags) {
        if (!DB_Conditions.I.dam_condition (_atk, _def)) return;

        int _dam = _damOrig;
        
        _dam = check_tag_effects (_atk, _def, _dam, _tags);

        _def.hp -= _dam;

        post_dam_events (_atk, _def, _dam);

        if (_def.hp <= 0) {
            kill (_def);
        }
    }
    
    public void lose_hp (InGameObject _def, int _dam) {
        if (!DB_Conditions.I.dam_condition (_atk, _def)) return;
        
        int _dam = _damOrig;
        
        _dam = check_tag_effects (_atk, _def, _dam, _tags);

        _def.hp -= _dam;
        if (_def.hp < 1) _def.hp = 1;

        post_dam_events (_atk, _def, _dam);
    }

    public void kill (InGameObject _def){
        ContObj.I.evt_on_death (_def);
        Destroy (_def.gameObject);
    }

    private void post_dam_events (InGameObject _atk, InGameObject _def, int _dam) {
        // Invul if player
        if (_def == ContPlayer.I.player) {
            ContBuffs.I.add_buff (_def, "invulnerable");
        }
        
        // Dam Text UI
        GameUI_InGameTxt.I.create_ingame_txt (_dam.ToString (), _def.gameObject.transform.position, 2f);
    }
    
    private int check_tag_effects (InGameObject _atk, InGameObject _def, int _dam, List<string> _tags){
        
        
        return _dam;
    }
}
