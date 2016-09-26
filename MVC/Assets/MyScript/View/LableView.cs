using UnityEngine;
using System.Collections;
using System;

public class LableView :MonoBehaviour {
	public UILabel expLab;
	public UIButton addExpbtn;

	public string Text{
		get{ return expLab.text;}
		set{ expLab.text = value;}
	}
	public event EventHandler OnClick;
	public  void btnClicked(){
		if (OnClick != null) {
			OnClick (this, new EventArgs ());
		}
	}
		
}
