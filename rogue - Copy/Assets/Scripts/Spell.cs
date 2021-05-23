using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Spell{
    public string name{ get; set; }
    public int damage { get; set; }
    public float areaOfDamage{ get; set; }

    public Spell(string _name){
        this.name = _name;
        this.damage = 10;
        this.areaOfDamage = 1f;
    }
    public Spell(string _name, int _damage){
        this.name = _name;
        this.damage = _damage;
        this.areaOfDamage = 1f;
    }

      public Spell(string _name, int _damage, float _areaOfEffect){
        this.name = _name;
        this.damage = _damage;
        this.areaOfDamage = _areaOfEffect;
    }
    public string GetSPellStats(){
        string spellStats = "";
        spellStats += "Name: " + this.name;
        spellStats += "Damage: " + this.damage;
        spellStats += "AreaOfEffect: " + this.areaOfDamage;
        return spellStats;
    }


}
