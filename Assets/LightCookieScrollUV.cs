using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightCookieScrollUV : MonoBehaviour
{
    // In URP, we need to scroll the light cookie.
    // -> lightCookieOffset in URP's UniversalAdditionalLightData component.

    UniversalAdditionalLightData lightData;
    public Vector2 speed;

    void Start()
    {
        if (!lightData)
        {
            lightData = GetComponent<UniversalAdditionalLightData>();
        }
    }

    void Update()
    {
        // Scroll UVs of the light cookie texture.

        lightData.lightCookieOffset = speed * Time.time;
    }
}
