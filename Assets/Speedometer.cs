using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public Rigidbody target;
    public float maxSpeed = 0.0f;
    public float minSpeedArrowAngle;
    public float maxSpeedArrowAngle;
    public float speed;

    [Header("UI")]
    public TMP_Text speedLabel;
    public RectTransform pivot;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        speed = target.velocity.magnitude * 3.6f;

        if (speedLabel != null)
            speedLabel.text = ((int)speed) + " km/h";
        if (pivot != null)
            pivot.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minSpeedArrowAngle, maxSpeedArrowAngle, speed / maxSpeed));
    }
}
