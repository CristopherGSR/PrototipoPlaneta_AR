using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorobjetc6 : MonoBehaviour
{
    private bool esColor = false;
	private Renderer colorPlane;
	string btnName;

    // Start is called before the first frame update
    void Start()
    {
	colorPlane = GetComponent<Renderer>();
	colorPlane.material.SetColor("_Color",Color.white);
	esColor = true;
    }

    // Update is called once per frame
    void Update()
    {
	if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
		Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
		RaycastHit Hit;
		if(Physics.Raycast(ray, out Hit)){
			btnName = Hit.transform.name;
			switch(btnName){
				case "Peru":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					}
					break;
				case "AmericaNorte":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					}
					break;
				case "Asia":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					}
					break;
				case "Africa":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					}
					break;
				case "Europa":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					}
					break;
				case "Oceania":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.yellow);
						Invoke("ColorOn",3);
					}
					break;
				case "asia":
					if(esColor == true){
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = false;
					}
					else{
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					}
					break;
				default:
						colorPlane.material.SetColor("_Color", Color.white);
						esColor = true;
					break;
			}
		}
	}        
    }
	public void ColorOn(){
		colorPlane.material.SetColor("_Color", Color.white);
		esColor = true;
	}
	public void ColorOff(){
		colorPlane.material.SetColor("_Color", Color.yellow);
		esColor = true;
	}
}
