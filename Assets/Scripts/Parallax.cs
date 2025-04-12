using UnityEngine;

public class Parallax : MonoBehaviour
{

    private float startPos, length;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        float distance = cam.transform.position.x * parallaxEffect; // 0 = moviemnto com a camera || 1 n�o se move, ajustar velocidade do parallax entendendo estas conven�oes de valores
        float movement = cam.transform.position.x * (1 - parallaxEffect);
        
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement< startPos-length)
        {
            startPos -= length; 
        }
    
    }
}
