using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColTrig_GenericMissile : ColTrig {
    public override void on_hit_enemy (InGameObject _hit){
        if (!DB_Conditions.I.coll_cond_missile (_hit)) return;

        InGameObject _this = GetComponent <InGameObject> ();

        ContEffect.I.create_effect (_this.onHitSFX, _hit.gameObject.transform.position);
        ContDamage.I.damage (_this, _hit, _this.hitDam, _this.tags);

        Destroy (gameObject);
    }

    public override void on_hit_ally (InGameObject _hit){
        
    }
}
