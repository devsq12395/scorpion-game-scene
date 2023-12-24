using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContBuffs : MonoBehaviour {

    public static ContBuffs I;
	public void Awake(){ I = this; }

    public struct buff {
        public string name;
        public float dur;
        public GameObject attach;
        public InGameObject owner;
        public Vector3 atchOffset;

        public buff (string _name) {
            name = _name;
            attach = null;

            dur = 1;
            owner = null;
            
            atchOffset = new Vector3 (0, 0, 0);
        }
    }

    void Start() {
        
    }

    void Update() {
        
    }

    public void add_buff (InGameObject _targ, string _buffName) {
        buff _new = DB_Buffs.I.get_buff_data (_buffName);
        _new.owner = _targ;
        _targ.buffs.Add (_new);
    }
}
