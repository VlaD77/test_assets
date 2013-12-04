using UnityEngine;
using System.Collections;
 
public class HealthBar : MonoBehaviour
{
 
    Rect box = new Rect(10, 10, 100, 20);
 
    private Texture2D background;
    private Texture2D foreground;
 
    public float nnhealth = 100;
    public int maxHealth = 100;
 
    void Start()
    {
 
        background = new Texture2D(1, 1, TextureFormat.RGB24, false);
        foreground = new Texture2D(1, 1, TextureFormat.RGB24, false);
 
        background.SetPixel(0, 0, Color.black);
        foreground.SetPixel(0, 0, Color.red);
 
        background.Apply();
        foreground.Apply();
    }
 
    void Update()
    {
       // nnhealth += Input.GetAxisRaw("Horizontal");
        if (nnhealth < 0) nnhealth = 0;
        if (nnhealth > maxHealth) nnhealth = maxHealth;
    }
 
    void OnGUI()
    {
        GUI.BeginGroup(box);
        {
            GUI.DrawTexture(new Rect(0, 0, box.width, box.height), background, ScaleMode.StretchToFill);
            GUI.DrawTexture(new Rect(0, 0, box.width*nnhealth/maxHealth, box.height), foreground, ScaleMode.StretchToFill);
        }
        GUI.EndGroup(); ;
    }
 
}