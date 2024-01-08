using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        if (ContObj.I.get_has_buff (_targ, _buffName)) remove_buff (_targ, _buffName);

        buff _new = DB_Buffs.I.get_buff_data (_buffName);
        _new.owner = _targ;
        _targ.buffs.Add (_new);
    }

    public void remove_buff (InGameObject _targ, string _buffName, bool _remFromArray = true){
        int _i  = _targ.buffs.FindIndex(b => b.name == _buffName);

        if (_i != -1) {
            Destroy (_targ.buffs [_i].attach);
            if (_remFromArray) _targ.buffs.RemoveAt (_i);
        }
    }
}
