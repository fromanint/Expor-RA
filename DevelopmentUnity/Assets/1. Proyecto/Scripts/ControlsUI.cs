using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsUI : MonoBehaviour {

	RectTransform Augmented;

	public void HorizontalMove(float value)
	{
		Vector3 pos = Augmented.position;
		pos.x += value;
		Augmented.position = pos;
	}

	public void VerticalMove(float value)
	{
		Vector3 pos = Augmented.position;
		pos.y += value;
		Augmented.position = pos;
	}

	public void Zoom(float value)
	{
		Vector3 pos = Augmented.position;
		pos.z += value;
		Augmented.position = pos;
	}

}
