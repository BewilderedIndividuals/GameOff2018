using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LogoDisperse : MonoBehaviour
{

    [SerializeField]
    private Texture2D logoTex;

    [SerializeField]
    private Material logoMat;


    [SerializeField]
    [Range(0f, 1f)]
    private float AlphaValue = 0.5f;

    [SerializeField]
    private Gradient Gradient;

    [SerializeField]
    private Gradient GradientTwo;

    // Start is called before the first frame update
    void Start()
    {


    }

    public Texture2D GetTex()
    {
        return logoTex;
    }

    public Material GetMat()
    {
        return logoMat;
    }

    public float GetAlpha()
    {
        return AlphaValue;
    }

    public Gradient GetGradient()
    {
        return Gradient;
    }

    public Gradient GetGradientTwo()
    {
        return GradientTwo;
    }
}
