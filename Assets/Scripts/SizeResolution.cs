using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeResolution : MonoBehaviour {


	private const float targetAspect = 1080.0f / 1920.0f;   
	void Start() {    float currentAspect = (float)Screen.width / (float)Screen.height;    float rectHeight = currentAspect / targetAspect;    Rect cameraRect = Camera.main.rect;    cameraRect.height = rectHeight;    cameraRect.y = (1.0f - rectHeight) / 2.0f;    Camera.main.rect = cameraRect;  }}
