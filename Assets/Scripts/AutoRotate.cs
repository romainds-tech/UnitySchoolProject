using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    
    [Range(0, 100)]
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.localPosition = new Vector3(this.transform.localPosition.x + 0.1f, this.transform.localPosition.y , this.transform.localPosition.z);
        
        // this.transform.localPosition = new Vector3(0.1f, 0, 0);
        
        // this.transform.localPosition = Vector3.right * 0.1f;
        
        this.transform.Rotate(Vector3.up * 10f);
        // this.transform.Rotate(Vector3.up, this.speed, );
    }
}
