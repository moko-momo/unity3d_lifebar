using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMGUI : MonoBehaviour {

	private Rect BloodBar;
	private Rect AddButton;
	private Rect SubButton;
	public float bloodValue = 1.0f;

	void Start()
	{

		BloodBar = new Rect(500, 20, 200, 20);  	 
		AddButton = new Rect(500, 50, 40, 20);  
		SubButton = new Rect(650, 50, 40, 20); 
	}

	void OnGUI()
	{
		if (GUI.Button(AddButton, "+"))
		{
			bloodValue += 0.1f;
		}
		if (GUI.Button(SubButton, "-"))
		{
			bloodValue -= 0.1f;
		}
		if (bloodValue > 1.0f)
		{
			bloodValue = 1.0f;
		}
		if (bloodValue < 0.0f)
		{
			bloodValue = 0.0f;
		}


		bloodValue = Mathf.Lerp(bloodValue, bloodValue, 0.05f);

		GUI.HorizontalScrollbar(BloodBar, 0.0f, bloodValue, 0.0f, 1.0f);  
	}
}
