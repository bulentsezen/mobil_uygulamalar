using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour
{
    // config params
    [SerializeField] Oyuncu1 oyuncu1;
    [SerializeField] float xPush = 10f;
    [SerializeField] float yPush = 14f;

    //state
    Vector2 oyuncu1ToBallVector;
    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        oyuncu1ToBallVector = transform.position - oyuncu1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToOyuncu1();
            LaunchOnMouseClick();
        } 
        
    }

    private void LockBallToOyuncu1()
    {
        Vector2 oyuncu1Pos = new Vector2(oyuncu1.transform.position.x, oyuncu1.transform.position.y);
        transform.position = oyuncu1Pos + oyuncu1ToBallVector;
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
