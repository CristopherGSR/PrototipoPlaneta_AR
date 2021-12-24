using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Siguiente : MonoBehaviour
{
public Animator animator;
int i=0;

    // Start is called before the first frame update
    void Start()
    { 
	i=i+1;
	switch(i){
		case 1:
			animator.Play("RotacionOceania");
			break;
		default:
			break;
        
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }

public void Animator()	
	{}
}