using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleReciever : MonoBehaviour
{

    [SerializeField]
    private bool OverrideRendererMaterial = false;

    [SerializeField]
    private bool OverrideShape = false;

    [SerializeField]
    private bool OverrideAlpha = false;

    [SerializeField]
    private bool OverrideColorOverLifetime = false;

    [SerializeField]
    private bool OverrideColorOverLifetimeTwo = false;


    ParticleSystem pSystem;

    LogoDisperse top;

    // Start is called before the first frame update
    void Start()
    {

        top = GetComponentInParent<LogoDisperse>();
        pSystem = GetComponent<ParticleSystem>();


        if(OverrideRendererMaterial)
        {
            pSystem.GetComponent<ParticleSystemRenderer>().material = top.GetMat();
        }

        if(OverrideShape)
        {
            ParticleSystem.ShapeModule shapemod = pSystem.shape;
            shapemod.texture = top.GetTex();
        }

        if(OverrideAlpha)
        {
            Color gradientColor = pSystem.main.startColor.color;
            ParticleSystem.MainModule mainmod = pSystem.main;
            mainmod.startColor = new Color(gradientColor.r, gradientColor.g, gradientColor.g, top.GetAlpha());

        }

        if (OverrideColorOverLifetime)
        {
            ParticleSystem.ColorOverLifetimeModule col = pSystem.colorOverLifetime;
            col.color = top.GetGradient();
        }

        if (OverrideColorOverLifetimeTwo)
        {
            ParticleSystem.ColorOverLifetimeModule col = pSystem.colorOverLifetime;
            col.color = top.GetGradientTwo();
        }
    }
}
