using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonBehaviour : MonoBehaviour
{
    public float Speed;
    public Vector3 AddForceWhenHittingPlayer;

    [HideInInspector]
    public List<PistonState> States = new List<PistonState>();

    Transform m_Visuals;
    Transform Visuals
    {
        get
        {
            if(m_Visuals == null)
            {
                m_Visuals = transform.GetChild(0);
            }
            return m_Visuals;
        }
    }
    Vector3 m_VisualsTargetPosition;
    float m_MovingSpeed;
    Vector3 m_MovingDirection;

    void Awake()
    {
        m_VisualsTargetPosition = Visuals.transform.localPosition;
    }

	void Start ()
    {
		
	}

	void Update ()
    {
		
	}
}
