using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeacherController : MonoBehaviour
{
    public t teacher; 
    public enum t { g,t,m,k }
    private Animator Animator;

    public TeacherController(t teacher, Animator animator)
    {
        this.teacher = teacher;
        Animator = animator;
    }

    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetBool($"{teacher}", true);
        transform.Find($"MinimapIcon_{teacher}").gameObject.SetActive(true);
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player" && SceneManager.sceneCount == 1)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
    }
}
