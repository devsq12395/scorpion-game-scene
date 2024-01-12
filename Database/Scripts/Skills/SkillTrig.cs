using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTrig : MonoBehaviour {

    public string scriptTag = "skill";
    public string skillName;
    [Header("------ Skill Slots: mouse1, shift, Skill1, Skill2, Skill3 ------")]
    public string skillSlot = "mouse1"; // Use the input name like "Skill1" for the set skill1 key, or "shift" for the set shift key
        // OFFICIAL LIST: "mouse1", "shift", "Skill1", "Skill2", "Skill3"

    public int mc;
    public float cdDef = 0.5f, cd;

    public virtual void use_active (){
        // CD - Reduced at ContObj.cs
        if (cd > 0) return;
        
        // MC
        InGameObject _igo = gameObject.GetComponent <InGameObject> ();
        if (_igo.mp < mc) return;
        ContDamage.I.lose_mp (_igo, mc);
    }

    public virtual void use_passive (){
        
    }
}
