using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject Castle;

    public float speed = 1.0f;


    float elapsedTime;
    float timeLimit = 3f;
    void Update()
    {
        ManageMovement();

    }

    void ManageMovement()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Castle.transform.position, step);
    }


   
        void OnTriggerEnter2D(Collider2D other)
        {
                Debug.Log("castle takes damage!!");
                Destroy(gameObject);

        }

}
