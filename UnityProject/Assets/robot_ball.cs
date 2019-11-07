using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_ball : MonoBehaviour {

    [Header("速度"), Range(0, 100)]
    public int Speed = 1;
    [Header("跳躍"),Range(0f,1000f)]
    public float Jump = 200f;
    [Header("地板裝鉛了嗎")]
    public bool IsGround = false;

    private Rigidbody ball;

    // Use this for initialization
    void Start () {
        ball = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S)) Walk(0f,-0.1f);
        if (Input.GetKey(KeyCode.W)) Walk(0f,0.1f);
        if (Input.GetKey(KeyCode.A)) Walk(-0.1f,0f);
        if (Input.GetKey(KeyCode.D)) Walk(0.1f,0f);
        Jumpy();
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGround = true;
    }
    /// <summary>
    /// 走起
    /// </summary>
    /// <param name="x">左右</param>
    private void Walk(float x,float z)
    {
        this.transform.Translate(Speed * x, 0, Speed * z);
    }
    /// <summary>
    /// 跳起來
    /// </summary>
    private void Jumpy()
    {
        if (Input.GetKey(KeyCode.Space) && IsGround == true)
        {
            IsGround = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0f,Jump,0f));

        }
    }
}
