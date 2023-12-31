using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upkey;
    public KeyCode downkey;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput()); 
    }

    private Vector2 GetInput()
    {
        // Game input
        if (Input.GetKey(upkey))
        {
           return Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
        // gerakan object pake input
        Debug.Log("Test: " + movement);
        rig.velocity = movement;
    }
}
