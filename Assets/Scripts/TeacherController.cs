using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherController : MonoBehaviour
{
    public t teacher; 
    public enum t { g,t,m,k }
    private Animator Animator;

    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetBool($"{teacher}", true);
        transform.Find($"MinimapIcon_{teacher}").gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
}
