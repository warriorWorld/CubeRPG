﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStat  {
	public List<StatBonus> BaseAdditives{ get; set;}

	public int BaseValue{ get; set;}
	public string StatName{ get; set;}
	public string StatDescription{ get; set;}
	public int FinalValue{ get; set;}

	public BaseStat(int baseValue,string statName,string statDescription){
		this.BaseAdditives = new List<StatBonus> ();
		this.BaseValue = baseValue;
		this.StatName = statName;
		this.StatDescription = statDescription;
	}

    //tell newton this is constructor for him
    [Newtonsoft.Json.JsonConstructor]
    public BaseStat(int baseValue, string statName)
    {
        this.BaseAdditives = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = statName;
    }
    public void AddStatBonus(StatBonus statBonus){
		this.BaseAdditives.Add (statBonus);
	}
	public void RemoveStatBonus(StatBonus statBonus){
		//to avoid 1 bug caused by same statbonus we remove statbonus this way(remove the first one finded)
		this.BaseAdditives.Remove (BaseAdditives.Find(x=>x.BonusValue==statBonus.BonusValue));
	}

	public int GetCalculatedStatValue(){
		this.FinalValue = 0;
		this.BaseAdditives.ForEach (x=>this.FinalValue+=x.BonusValue);
		FinalValue += BaseValue;
		return FinalValue;
	}
}
