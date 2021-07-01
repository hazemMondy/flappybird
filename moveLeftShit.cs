using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeftShit : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    [SerializeField] private float randomoffset;//2.4  4.8
    Vector3 temp;
    private void Update()
    {
        temp = transform.position;
        temp += speed * Time.deltaTime * Vector3.left;
        transform.position = temp;


        if (temp.x < -15)
        {

            temp = new Vector3(15,temp.y, temp.z);
            transform.position = temp;
        }
    }
}
