using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    private CharacterController _controller;
    float Speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Avatar is starting....");
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(hor, 0, ver);
        _controller.Move(move * Time.deltaTime * Speed);
        Debug.Log(hor);
    }
}
