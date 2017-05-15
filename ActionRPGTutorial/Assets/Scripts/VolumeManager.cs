using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour {

    public VolumeController[] vcObjects;
    public float currentVolumeLevel;
    public float maxVolumeLevel;
    
    // Use this for initialization
	void Start () {
        vcObjects = FindObjectsOfType<VolumeController>();
        maxVolumeLevel = 1.0f;
        if(currentVolumeLevel > maxVolumeLevel) {
            currentVolumeLevel = maxVolumeLevel;
        }

        for(int i = 0; i < vcObjects.Length; i++) {
            vcObjects[i].setAudioLevel(currentVolumeLevel);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
