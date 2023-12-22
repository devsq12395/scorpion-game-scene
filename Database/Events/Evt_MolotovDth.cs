using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evt_MolotovDth : EvtTrig {
    
    public override void use (){
        List<InGameObject> _objs = new List<InGameObject> ();
        InGameObject _owner = gameObject.GetComponent <InGameObject> ();
        create_obj (gameObject.transform.position, _owner);
        for (int i = 0; i < 4; i++){
            create_obj (Calculator.I.get_next_point_in_direction (gameObject.transform.position, i * 90 + 45, 1), _owner);
        }
        for (int i = 0; i < 8; i++){
            create_obj (Calculator.I.get_next_point_in_direction (gameObject.transform.position, i * 45, 2), _owner);
        }
    }
    
    private InGameObject create_obj (Vector2 _pos, InGameObject _owner){
        InGameObject _ret = ContObj.I.create_obj ("molotovEfct", _pos, _owner.owner).GetComponent<InGameObject> ();
        
        return _ret;
    }
}
