using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Vector3 movementInput = Vector3.zero;
            if (Input.GetKey(KeyCode.A))
            {
                movementInput.x = -1;
            }
            if (Input.GetKey(KeyCode.D))
            {
                movementInput.x = 1;
            }
            if (Input.GetKey(KeyCode.W))
            {
                movementInput.z = 1;
            }
            if (Input.GetKey(KeyCode.S))
            {
                movementInput.z = -1;
            }
            Move(movementInput);
        }
        
    }

    void Move(Vector3 dir)
    {
        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
