using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour
{
    public Vector3 RandomTarget = new Vector2();
    public Vector3 pos;
    public float speed;
    public bool onWayToTarget;
    public GameObject apple;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        //RandomTarget.y = 21.3f;
        //RandomTarget.z = 42.3f;
        Invoke("MoveTree", 0f);
        Invoke("SpawnApple", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (RandomTarget.x > transform.position.x && onWayToTarget)
        {
            pos.x += speed * Time.deltaTime;
            if (RandomTarget.x <= pos.x)
                onWayToTarget = false;
            transform.position = pos;
        }
        else if (RandomTarget.x < transform.position.x && onWayToTarget)
        {
            pos.x -= speed * Time.deltaTime;
            if (RandomTarget.x >= pos.x)
                onWayToTarget = false;
            transform.position = pos;
        }
        else
            Invoke("MoveTree", 0f);
    }

    void MoveTree()
    {
        RandomTarget.x = Random.Range(-55f, 55f);
        pos = transform.position;
        onWayToTarget = true;

    }

    void SpawnApple()
    {
        Instantiate(apple, transform.position, transform.rotation);
        //spawnable.transform.position = transform.position;
        Invoke("SpawnApple", 3f);
    }
}
