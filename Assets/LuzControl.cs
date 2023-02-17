using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzControl : MonoBehaviour
{
    public Light directionalLight;
    // Start is called before the first frame update

    RectTransform rectTransform;
    void Start()
    {
        rectTransform = this.GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        directionalLight.intensity = rectTransform.anchorMax.x;
    }
}
