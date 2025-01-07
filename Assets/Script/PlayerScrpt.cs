using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class PlayerScrpt : MonoBehaviour
{
   public float jumpforce = 10f;
   public Rigidbody2D rb;
   public string currentColor;
   public Color cyan;
   public Color yellow;
   public Color pink;
   public Color magenta;
   public SpriteRenderer sr;


    void Start()
    {
        SetRandomColor();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpforce;
        }
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log(coll.tag);

       // here is game over 
       if(coll.tag == "ColorChange")
       {
         SetRandomColor();
         return;
       }
       if(currentColor != coll.tag)
       {
         Debug.Log("Game Over");
       }
    }

    public void SetRandomColor()
    {
        int index = Random.Range(0 , 4);
        switch(index)
        {
            case 0 :
            currentColor = "Cyan";
            sr.color = cyan;
            break;
            case 1: 
            currentColor = "Yellow";
            sr.color = yellow;
            break;
            case 2:
            currentColor = "Pink";
            sr.color = pink;
            break;
            case 3: 
            currentColor = "Magenta";
            sr.color = magenta;
            break;

        }

    }
}
