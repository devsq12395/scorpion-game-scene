using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Dash : SkillTrig {

    public string missileObj;
    
    public override void use_active (){
        float DIST = 3f;

        InGameObject _ownerComp = gameObject.GetComponent <InGameObject> ();

        Vector2 _pos = gameObject.transform.position,
                _mousePos = InGameCamera.I.get_mouse_pos (),
                _mousePos_scrn = Input.mousePosition,
                _dir = _mousePos - _pos;
        float _ang = Mathf.Atan2 (_dir.y, _dir.x);

        ContObj.I.change_facing (_ownerComp, (Calculator.I.is_mouse_left_of_object (_ownerComp) ? "left" : "right"));
        ContObj.I.move_forward_instant (_ownerComp, _ang, DIST);
        InGameCamera.I.point_to_target ();
    }
}
