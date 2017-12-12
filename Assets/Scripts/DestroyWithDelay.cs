using UnityEngine;
using System.Collections;

public class DestroyWithDelay : MonoBehaviour
{
	public float delay;
	
	void Start ()
	{
		Destroy(gameObject, delay);
	}
}
