using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {
	public List<BaseStat> stats = new List<BaseStat> ();

	// Use this for initialization
	void Start () {
		stats.Add (new BaseStat(4,"power","power is power"));
		stats.Add (new BaseStat(8,"vitality","vitality is vitality"));

		Debug.Log ("final power:"+stats[0].GetCalculatedStatValue());
	}
	public void AddStatBonus(List<BaseStat> statBonuses){
		foreach (BaseStat statBonus in statBonuses) {
			//one sword equiped and sword's power is sword's power's basevalue add this basevalue to character's bonus power
			stats.Find (x => x.StatName == statBonus.StatName).AddStatBonus (new StatBonus(statBonus.BaseValue));		;
		}
	}
	public void RemoveStatBonus(List<BaseStat> statBonuses){
		foreach (BaseStat statBonus in statBonuses) {
			//one sword equiped and sword's power is sword's power's basevalue add this basevalue to character's bonus power
			stats.Find (x => x.StatName == statBonus.StatName).RemoveStatBonus (new StatBonus(statBonus.BaseValue));		;
		}
	}
}
