using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
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
            if (randomoffset==0)
            {
                temp = new Vector3(15, temp.y, temp.z);
                transform.position = temp;
            }
            float randomhigh = UnityEngine.Random.Range(2.3f, 4.8f);
            temp = new Vector3(15, randomhigh, temp.z);
            transform.position = temp;
        }
    }
}
