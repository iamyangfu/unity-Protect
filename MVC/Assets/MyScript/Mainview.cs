using UnityEngine;
using System.Collections;

public class Mainview : MonoBehaviour {
	PlayerCtrl play;
	// Use this for initialization
	void Start () {
		play = new PlayerCtrl ();
	
		Invoke("hide",3);
		Invoke("showshow",5);
	}
	void showshow(){
		play.show ();
	}
	void hide(){
		play.hide ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
