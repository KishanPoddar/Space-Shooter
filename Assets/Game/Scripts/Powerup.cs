using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField]
    private int powerupID;  //0->tripple Shot   1->Speed Boost    2->Shields
    [SerializeField]
    private AudioClip _clip;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed * Vector3.down * Time.deltaTime);
        if (transform.position.y<-7)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  //other.Tag=="Player"
        {
            Player player = other.GetComponent<Player>();
            AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position, 1f);
            if (player != null)
            {
                //enable tripple shot
                if (powerupID == 0)
                {
                    player.TripleShotPowerupOn();
                }
                else if (powerupID == 1)
                {
                    //enable speed boost
                    player.SpeedBoostPowerupOn();
                }
                else if (powerupID == 2)
                {
                    //enable shields
                    player.EnableShields();
                }
            }
            //destroy ourself
            Destroy(this.gameObject);
        }
    }

}
