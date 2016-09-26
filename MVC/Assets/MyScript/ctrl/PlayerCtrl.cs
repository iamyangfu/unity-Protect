using UnityEngine;
using System.Collections;
using System;
public class PlayerCtrl{
	private Model playerMod;
 
	private LableView playerVie;
//	void Start(){
	public PlayerCtrl(){
		playerVie = GameObject.Find ("MainGUI").GetComponent<LableView> ();
		playerMod = new Model ();
		playerMod.expAdd += updateLable;
		playerMod.expAdd += (s, e) => {Debug.Log("add");} ;
		playerVie.OnClick += (sender, e) => {playerMod.EXP = 50;} ;
		updateLable (null, null);
	}

	void updateLable(object sender,EventArgs arg){
//		playerVie.GetComponent<UILabel> ().text = "LP:" + playerMod.EXP;
		playerVie.Text = System.Convert.ToString (playerMod.EXP);
	}
	public void show(){
		playerVie.gameObject.SetActive (true);
	}
	public void hide(){
		playerVie.gameObject.SetActive (false);
	}
}
