using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public int Xrotation;
	public int Yrotation;
	public int Zrotation;
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (Xrotation, Yrotation, Zrotation) * Time.deltaTime);
	}
}
