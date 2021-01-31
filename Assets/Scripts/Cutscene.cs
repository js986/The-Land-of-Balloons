using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour
{
    [SerializeField]Sprite[] cutscene_images = new Sprite[9];
    Image current_image;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        current_image = GetComponent<Image>();
        i = 0;
        current_image.sprite = cutscene_images[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeImage()
    {
        i++;
        if(i<9)current_image.sprite = cutscene_images[i];
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
