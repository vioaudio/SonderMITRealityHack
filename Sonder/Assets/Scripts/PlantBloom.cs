using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SkinnedMeshRenderer))]
public class PlantBloom : MonoBehaviour
{
    public float secondsToAnimate = 3.0f;
    public bool multistepAnimation = false;
    [HideInInspector]
    public float[] keyframeStep;

    private int blendShapeCount;
    private SkinnedMeshRenderer skinnedMeshRenderer;
    private Mesh skinnedMesh;
    private float bloomAnimation;

    private void Awake()
    {
        skinnedMeshRenderer = gameObject.GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    // Start is called before the first frame update
    void Start()
    {
        blendShapeCount = skinnedMesh.blendShapeCount;
    }

    // Update is called once per frame
    void Update()
    {
        //to be replaced by collision or trigger
        if (Input.GetKeyDown(KeyCode.Space) && multistepAnimation == false)
        {
            //invoke coroutine passing 
        }
        //else (Input.GetKeyDown(KeyCode.Space) && multistepAnimation == true)
        //{
            //coroutine passing through []
        //}
    }


}
