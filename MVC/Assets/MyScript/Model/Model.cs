using UnityEngine;
using System.Collections;
using System;
public class Model {
	private int exp;
	public Model(){
		exp = 0;
	}
	public int EXP{
		get{ return exp;}
		set{ exp += value;
			if (expAdd!=null) {
				expAdd (this, new EventArgs ());
			}
		}
	}
	public event EventHandler expAdd;
}
