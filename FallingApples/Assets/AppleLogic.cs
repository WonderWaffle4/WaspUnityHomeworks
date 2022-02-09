using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleLogic : MonoBehaviour
{

    public float speed;
    public GameObject emptyObject;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        position.y -= speed * Time.deltaTime;
        transform.position = position;
        if (transform.position.y < -30f)
        {
            Destroy(transform.gameObject);
            emptyObject.GetComponent<GameLogic>().loseLife();
        }
    }
}
