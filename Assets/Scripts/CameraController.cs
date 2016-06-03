using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	// Better for follow cameras, procedural animation and ghathering last know states
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}
