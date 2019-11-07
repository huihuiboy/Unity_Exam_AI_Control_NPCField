using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot : MonoBehaviour {

    [Header("對話")]
    public string Say = "腦袋裝鉛了嗎";
    public float saySpeed = 0.2f;
    [Header("任務")]
    public bool Can = false;
    public int bataryNum = 5;
    public int batary = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
