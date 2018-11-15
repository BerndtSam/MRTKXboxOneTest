using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Test : XboxControllerHandlerBase
{
    Vector3 initialPosition;

	// Use this for initialization
	void Start () {
        initialPosition = gameObject.transform.position;
	}

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnXboxInputUpdate(XboxControllerEventData eventData)
    {
        float x = eventData.XboxLeftStickHorizontalAxis;
        float y = eventData.XboxRightStickVerticalAxis;
        float z = eventData.XboxLeftStickVerticalAxis;

        gameObject.transform.position = initialPosition + new Vector3(x, y, z);

        float roll = eventData.XboxRightStickHorizontalAxis;
        float pitch = eventData.XboxRightStickVerticalAxis;
        float yaw = eventData.XboxDpadHorizontalAxis;

        gameObject.transform.rotation *= Quaternion.Euler(roll, pitch, yaw);

        float scale = eventData.XboxDpadHorizontalAxis;
        gameObject.transform.localScale += new Vector3(scale,scale,scale);
    }
}
