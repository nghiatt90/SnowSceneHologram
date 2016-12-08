using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoRotate : MonoBehaviour {
	public Transform rotationObject;
	[Range(1f,10f)]
	public float rotationSpeed = 1.0f;
	public Image placeholder;
	private Color c = new Color (1f, 1f, 1f, 1f);

	void Update () {
		rotationObject.Rotate(transform.position.x, rotationSpeed, transform.position.z);
		if (c.a != 0f) {
			c.a = c.a - 0.002f;
			placeholder.color = new Color (1f, 1f, 1f, c.a);
		}
	}
}
