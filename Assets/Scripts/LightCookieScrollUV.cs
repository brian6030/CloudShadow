using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightCookieScrollUV : MonoBehaviour
{
    UniversalAdditionalLightData lightData;
    public Vector2 speed;

    void Start()
    {
         lightData = GetComponent<UniversalAdditionalLightData>();
    }

    void Update()
    {
        // Scroll the light cookie
        lightData.lightCookieOffset += speed * Time.deltaTime;
    }

}
