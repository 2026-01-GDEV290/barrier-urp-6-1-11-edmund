using Mono.Cecil.Cil;
using UnityEngine;

public class playerinputscript : MonoBehaviour
{
    private int punchCount = 0;
    [SerializeField]
    public Animator anim;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && punchCount == 0)
        {
            anim.SetTrigger("Punch");
            punchCount++;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse0) && punchCount == 1)
        {
            anim.SetTrigger("Punch2");
                punchCount++;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse0) && punchCount == 2)
        {
            anim.SetTrigger("Punch3");
            punchCount++;
        }
    }
}
