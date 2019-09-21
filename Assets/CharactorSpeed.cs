//#define CHARA_CONTROLLER
#define NAVMESH

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CharacterControllerからキャラのスピードを取得してコンソールに出力する
/// </summary>
public class CharactorSpeed : MonoBehaviour
{
    private UnityEngine.Rigidbody m_RBody = null;

    private UnityEngine.CharacterController m_CController = null;

    private UnityEngine.AI.NavMeshAgent m_Agent = null;

    private UnityEngine.Animator m_Animator = null;

    // Use this for initialization
    void Start()
    {
        m_CController = gameObject.GetComponent<UnityEngine.CharacterController>() as UnityEngine.CharacterController;
        m_RBody = gameObject.GetComponent<UnityEngine.Rigidbody>() as UnityEngine.Rigidbody;
        m_Agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>() as UnityEngine.AI.NavMeshAgent;
        m_Animator = gameObject.GetComponent<UnityEngine.Animator>() as UnityEngine.Animator;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity;
        string str;

        m_Agent.speed = m_Animator.GetFloat("NAV_SPEED");       //NavMeshAgentの移動速度をAniamtorのParameterから取得する。

#if CHARA_CONTROLLER
        velocity = m_CController.velocity;
#elif NAVMESH
        velocity = m_Agent.velocity;
#else
        velocity = m_RBody.velocity;
#endif

        str = string.Format("velocity=({0},{1},{2})", velocity.x, velocity.y, velocity.z);
        Debug.Log(str);
    }
}
