using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderScript : MonoBehaviour {

	public Slider s;
	public int val;
	public int damageValue;



	// Use this for initialization
	void Start () {
		s = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {

		s.value = GameObject.Find ("HarryPotter").GetComponent<PlayerHealth>().currentHealth;
		
	}


}
