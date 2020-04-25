using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    // Player inflicts 10 dmg and can reach object in the map in a range
    // of 100 units.
    public float damage = 10f;
    public float range = 100f;

    // Defines the fire rate at which the player can shoot the gun
    public float fireRate = 15f;

    // The shooting behaviour is linked to camera "fpsCam" linked to our
    // player's "MainCamera"
    public Camera fpsCam;

    // Reference to the muzzleFlash particles in the scene
    public ParticleSystem muzzleFlash;

    // Reference to the bullet impact object in the scene
    public GameObject impactEffect;

    // Reference to the class "Weapon_Recoil_Script" that handles the
    // gun's recoil
    public Weapon_Recoil_Script recoil;


    private float nextTimeToFire = 0f;

    public int highScore = 0;
    public Text highScoreDisplay;

    public CountdownController c_countCtrl;

    private AudioSource mAudioSrc;


    void Start()
    {
        mAudioSrc = GetComponent<AudioSource>();
    }

    // Set next time the weapon can be shot according to rate of fire
    // Shoot the gun
    // Add recoil to the weapon
    void Update()
    {
        // Mouse1 is clicked and is in rate of fire
         if (Input.GetKey(KeyCode.Mouse0) && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            Shoot();
            recoil.Fire();
        }

    }

    /* Shooting is done using Raycasting using the following params:
    1- The ray starts to the position of our main camera
    2- The ray ends where it hits something
    3- The hit detection is stored in a variable "hit"
    4- The range at which the player can reach an object */
    void Shoot()
    {
        // Play muzzle flash animation when shooting
        // TODO: when mouse button held, needs to play indefinitely
        muzzleFlash.Play();

        mAudioSrc.Play();

        // Detect hit and output name of object in the console
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.name.Contains("covidTarget")){

                // Hide target when it gets shot and increment the high score
                GameObject.Find (hit.transform.name).transform.localScale = new Vector3(0, 0, 0);
                
                highScore += 10;
                highScoreDisplay.text = highScore.ToString();
                
            }


            if(hit.transform.name.Contains("STARTGAME")){
                GameObject.Find ("STARTGAME").transform.localScale = new Vector3(0, 0, 0);
                GameObject.Find ("HUD").transform.localScale = new Vector3(0.522309f, 0.522309f, 0.522309f);
                StartCoroutine(c_countCtrl.CountdownToStart());
            }
        }

        // Destroy bullet impact's game objects after 1 second
        GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impactGO, 1f);
    }
}
