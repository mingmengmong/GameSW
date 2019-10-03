using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    private Vector3 defaultPosition = new Vector3(0f, 0.5f, 0f);
    
    // Start is called before the first frame update
    void Start() {
        this.transform.position = defaultPosition;
    }

    private float moveSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.forward;
        }
        
        if (Input.GetKey(KeyCode.DownArrow)) {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.back;
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.left;
        }
        
        if (Input.GetKey(KeyCode.RightArrow)) {
            this.transform.position += moveSpeed * Time.deltaTime * Vector3.right;
        }
    }
}
