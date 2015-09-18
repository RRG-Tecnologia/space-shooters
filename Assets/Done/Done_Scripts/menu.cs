using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// CHAMA A FASE 01 AO CLICAR NO MENU
	void Update () {
	if (Input.GetButtonDown ("Fire1")) {
			Application.LoadLevel("cena_principal");
				}
	}
}
