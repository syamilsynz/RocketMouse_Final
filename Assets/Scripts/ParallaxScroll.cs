using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParallaxScroll : MonoBehaviour {

	public Renderer background;
	public Renderer foreground;
	
	public float backgroundSpeed = 0.02f;
	public float foregroundSpeed = 0.06f;

	public float offset = 0;

	public Text textFrame;

	// Use this for initialization
	void Start () 
	{
		Application.targetFrameRate = 300	;
		QualitySettings.vSyncCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float backgroundOffset = offset * backgroundSpeed;
		float foregroundOffset = offset * foregroundSpeed;

		background.material.mainTextureOffset = new Vector2(backgroundOffset, 0);
		foreground.material.mainTextureOffset = new Vector2(foregroundOffset, 0);

		// Check fps
		double f = 1.0/Time.deltaTime;
		textFrame.text = "fps : " + f;

	}
}
