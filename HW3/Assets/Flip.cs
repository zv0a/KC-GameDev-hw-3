using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    SpriteRenderer sprite;
    bool FaceRight = true;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FLipPlayer();
    }
    void FLipPlayer()
    {

        if (Input.GetKeyDown(KeyCode.D) && FaceRight == false)
        {
            sprite.flipX = false;
            FaceRight = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && FaceRight == true)
        {
            sprite.flipX = true;
            FaceRight = false;
        }
    }
}
