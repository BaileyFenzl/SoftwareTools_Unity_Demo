using UnityEngine;
using System.Collections;

public class char_control : MonoBehaviour {


    // Use this for initialization. 
    // This is called on the first frame
    void Start () {
	
	}
	
	// Update is called once per frame
    // These are all built-in functions 
	void Update () {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * Time.deltaTime);

    }

}
