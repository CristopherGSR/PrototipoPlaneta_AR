using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urlmanager : MonoBehaviour
{
	public string web1;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void tutorial(){
		Application.OpenURL(web1);
	}
}
