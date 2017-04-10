using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsUI : MonoBehaviour {

	public RectTransform Augmented;

	[SerializeField] Slider zoomValue;
	[SerializeField] float maxScale;


	void Start()
	{
		/*Vector3 pos = Augmented.position;
		pos.x = PlayerPrefs.GetFloat ("posx",Augmented.position.x);
		pos.y = PlayerPrefs.GetFloat ("posy",Augmented.position.y);
		pos.z = PlayerPrefs.GetFloat ("posx",Augmented.position.z);

		if (pos.x == 0)
			pos.x = Augmented.position.x;
		if (pos.y == 0)
			pos.y = Augmented.position.y;
		if (pos.z == 0)
			pos.z = Augmented.position.z;


		Augmented.position = pos;*/
	}

	public void HorizontalMove(float value)
	{
		Vector3 pos = Augmented.position;
		pos.x += value;
		Augmented.position = pos;
		PlayerPrefs.SetFloat ("posx",Augmented.position.x);

	}

	public void VerticalMove(float value)
	{
		Vector3 pos = Augmented.position;
		pos.y += value;
		Augmented.position = pos;
		PlayerPrefs.SetFloat ("posy", Augmented.position.y);
	}

	public void Zoom(float value)
	{
		Vector3 pos = Augmented.position;
		pos.z += value;
		Augmented.position = pos;
		PlayerPrefs.SetFloat ("posz", Augmented.position.z);
	}

	public void OcultarControles()
	{
		gameObject.SetActive (false);
	}

	public void SliderZoom()
	{
		float scale = zoomValue.value;
		scale *= maxScale;
		Vector3 newScale = new Vector3 (scale, scale, scale);
		Augmented.localScale = newScale;
			
	}

}
