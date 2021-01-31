using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderCloud : MonoBehaviour
{
    public float freq = 5;
    public float magnitude = 10f;
    public float speed;
    float ThunderDelay = 2.5f;
    public GameObject LightningPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootLightning());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var _newPosition = transform.position;
        _newPosition.y += Mathf.Sin(Time.time * freq) * magnitude * Time.deltaTime;
        transform.position = _newPosition;
        if (this.transform.position.y < GridManager.instance.current.bottom_bound - 30)
        {
            Destroy(this.gameObject);
        }
    }
        IEnumerator ShootLightning()
        {

            while (true)
            {
                yield return new WaitForSeconds(ThunderDelay);

                Instantiate(LightningPrefab, transform.position, Quaternion.identity);
            }
        }
}
