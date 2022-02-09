using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorzinaLogic : MonoBehaviour
{
    private Vector2 MousePosition;
    private Vector3 MouseWorldPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MousePosition = Input.mousePosition;
        MouseWorldPosition = Camera.main.ScreenToWorldPoint(
            new Vector3(MousePosition.x, 40f, transform.position.z - Camera.main.transform.position.z)
            );
        MouseWorldPosition.x = 
            (MouseWorldPosition.x > 55f) ? 55f : 
            (MouseWorldPosition.x < 55f && MouseWorldPosition.x > -55f) ? MouseWorldPosition.x : -55f;
        transform.position = MouseWorldPosition;
    }

    void OnTriggerEnter(Collider collision) 
    {
        GameObject deletable = collision.transform.gameObject;
        Destroy(deletable);
    }
}
