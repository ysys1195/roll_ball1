using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform palyerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPlayerPosition = palyerTransform.position;
        Vector3 higherPlayerPosition = new Vector3(currentPlayerPosition.x, currentPlayerPosition.y + 14, currentPlayerPosition.z);
        gameObject.GetComponent<Transform>().position = higherPlayerPosition;
    }
}
