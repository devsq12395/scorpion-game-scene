using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTrig : MonoBehaviour {

    public string scriptTag = "skill";
    public string skillName;
    public string skillSlot = "mouse1"; // Use the input name like "Skill1" for the set skill1 key, or "shift" for the set shift key
        // OFFICIAL LIST: "mouse1", "shift", "Skill1", "Skill2", "Skill3"

    public virtual void use_active (){
        
    }

    public virtual void use_passive (){
        
    }
}
