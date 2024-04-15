using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectBowlingBall : MonoBehaviour
{
    [SerializeField] Material defaultBallMat;
    [SerializeField] Material selectedBallMat;

    private Renderer ballRenderer;

    private void Awake()
    {
        ballRenderer = GetComponent<Renderer>();
        ballRenderer.material = defaultBallMat;
    }

    public void OnHoverEnter()
    {
        ballRenderer.material = selectedBallMat;
    }

    public void OnHoverExit()
    {
        ballRenderer.material = defaultBallMat;
    }
}
