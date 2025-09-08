using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public bool up = false;
    public bool down = false;
    public int keyUp;
    public int keyDown;
    public string keyUpLetter;
    public string keyDownLetter;
    

    // Start is called before the first frame update
    void Start()
    {
        keyUp = 1;
        keyDown = 3;
    }

    // Update is called once per frame
    void Update()
    {
        switch (keyUp)
        {
            case 1:
                keyUpLetter = "q";
                break;
            case 2:
                keyUpLetter = "w";
                break;
            case 3:
                keyUpLetter = "e";
                break;
            case 4:
                keyUpLetter = "r";
                break;
            case 5:
                keyUpLetter = "t";
                break;
            case 6:
                keyUpLetter = "y";
                break;
            case 7:
                keyUpLetter = "u";
                break;
            case 8:
                keyUpLetter = "i";
                break;
            case 9:
                keyUpLetter = "o";
                break;
            case 10:
                keyUpLetter = "P";
                break;
            case 11:
                keyUpLetter = "a";
                break;
            case 12:
                keyUpLetter = "s";
                break;
            case 13:
                keyUpLetter = "d";
                break;
            case 14:
                keyUpLetter = "f";
                break;
            case 15:
                keyUpLetter = "g";
                break;
            case 16:
                keyUpLetter = "h";
                break;
            case 17:
                keyUpLetter = "j";
                break;
            case 18:
                keyUpLetter = "k";
                break;
            case 19:
                keyUpLetter = "l";
                break;
            case 20:
                keyUpLetter = "z";
                break;
            case 21:
                keyUpLetter = "x";
                break;
            case 22:
                keyUpLetter = "c";
                break;
            case 23:
                keyUpLetter = "v";
                break;
            case 24:
                keyUpLetter = "b";
                break;
            case 25:
                keyUpLetter = "n";
                break;
            case 26:
                keyUpLetter = "m";
                break;
        }

        switch (keyDown)
        {
            case 1:
                keyDownLetter = "q";
                break;
            case 2:
                keyDownLetter = "w";
                break;
            case 3:
                keyDownLetter = "e";
                break;
            case 4:
                keyDownLetter = "r";
                break;
            case 5:
                keyDownLetter = "t";
                break;
            case 6:
                keyDownLetter = "y";
                break;
            case 7:
                keyDownLetter = "u";
                break;
            case 8:
                keyDownLetter = "i";
                break;
            case 9:
                keyDownLetter = "o";
                break;
            case 10:
                keyDownLetter = "P";
                break;
            case 11:
                keyDownLetter = "a";
                break;
            case 12:
                keyDownLetter = "s";
                break;
            case 13:
                keyDownLetter = "d";
                break;
            case 14:
                keyDownLetter = "f";
                break;
            case 15:
                keyDownLetter = "g";
                break;
            case 16:
                keyDownLetter = "h";
                break;
            case 17:
                keyDownLetter = "j";
                break;
            case 18:
                keyDownLetter = "k";
                break;
            case 19:
                keyDownLetter = "l";
                break;
            case 20:
                keyDownLetter = "z";
                break;
            case 21:
                keyDownLetter = "x";
                break;
            case 22:
                keyDownLetter = "c";
                break;
            case 23:
                keyDownLetter = "v";
                break;
            case 24:
                keyDownLetter = "b";
                break;
            case 25:
                keyDownLetter = "n";
                break;
            case 26:
                keyDownLetter = "m";
                break;
        }

        transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(keyUpLetter))
        {
            up = true;
            down = false;
            if (up && transform.position.y < 8)
            {
                transform.position = transform.position + new Vector3(0, 8, 0);
            }
        }
        if (Input.GetKeyDown(keyDownLetter))
        {
            down = true;
            up = false;
            if (down && transform.position.y > -8)
            {
                transform.position = transform.position + new Vector3(0, -8, 0);
            }
        }
    }
}
