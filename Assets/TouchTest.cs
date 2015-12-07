using UnityEngine;
using System.Collections;
using System.Threading;

public class TouchTest : MonoBehaviour
{

    float positionX = 0;
    float positionY = 0;
    private System.Timers.Timer timer = null;
    private int timeElapsed = 0;
    private int _duration = 0;
    ForceField forceF = new ForceField();
    void Start ()
    {
	
	}
    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(Input.touchCount);//To check Touch counts
        if (Input.touchCount > 0)
        {
            Debug.Log(Input.GetTouch(0).position);
            
            forceF.decreaseField();//calling forceField method to decrease power and getting radius
           // forceF.santaLife();//Calling SantaLife when bad kids strike with santa .
            touchPositionX();//To get X position
            touchPositionY();//To get y position
        }
    }
        public float touchPositionX()
    {
        positionX = Input.GetTouch(0).position.x;
        return positionX;
    }
    public float touchPositionY()
    {
        positionY = Input.GetTouch(0).position.y;
        return positionY;
    }
    public void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        timer.Interval = 1000; // set timer interval to 1000 milliseconds
        timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
        timer.Start();
        timeElapsed += 1000;

        if (timeElapsed > this._duration)
        {
            timer.Stop();
        }
        forceF.IncreaseField();
    }
}

public class ForceField
{
    float forceField = 100;//Radius
    float santaLifes = 100;
    public float decreaseField()
    {
        float radius = 100 / 25;
        if (radius <= 0)
        {
            radius = 0;
            return radius;
        }
        return radius;
    }
    public float santaLife()
    {
        santaLifes -= 20;
        return santaLifes;
    }
    public float IncreaseField()
    {
        float radius=decreaseField();
        radius += 10;
        if (radius >= 100)
        {
            radius = 100;
            return radius;
        }
        return radius;
    }
}
