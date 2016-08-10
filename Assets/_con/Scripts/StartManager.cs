using UnityEngine;
using System.Collections;
using Valve.VR;

public class StartManager : MonoBehaviour {

	public Transform vrCam, fpsCam;

	public GameObject FPSCamera;

	public Vector3 spawnPoint, SpawnPoint_VR;

	private Transform mainCam;

	private bool vrIsActive;

	void Awake () {
		#if UNITY_EDITOR_WIN
		mainCam = Instantiate(vrCam);
		mainCam.transform.localPosition = SpawnPoint_VR;
		#endif

		#if UNITY_EDITOR_OSX
		mainCam = Instantiate(fpsCam);
		mainCam.transform.localPosition = spawnPoint;
		#endif

	}

	
	// Update is called once per frame
	void Update () {

	}
}
