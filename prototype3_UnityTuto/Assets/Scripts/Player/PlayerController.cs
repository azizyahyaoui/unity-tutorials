using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Animator animPlayer;
    [SerializeField]
     float jmpForce =10f;
    [SerializeField]
    private float gravityModifier = 2f;

    private bool isGrounded = true;
    [HideInInspector]
    public bool gameOver = false;
  
    [SerializeField]
    ParticleSystem explosionParticle;
    [SerializeField]
    ParticleSystem dirtParticle;

    private AudioSource playerAudio;
    [SerializeField]
    AudioClip jumpSound;
    [SerializeField]
    AudioClip crashSound;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        animPlayer = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded && !gameOver)
        {
            rbPlayer.AddForce(Vector3.up * jmpForce, ForceMode.Impulse);
            isGrounded = false;
            animPlayer.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.LogWarning("Game Over!");
            gameOver = true;
            animPlayer.SetBool("Death_b", true);
            animPlayer.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            dirtParticle.Stop();

        }
    }
}
