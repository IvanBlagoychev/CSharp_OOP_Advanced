using System;

public class TrafficLight
{
    private Signal light;

    public TrafficLight(string light)
    {
        this.Light = (Signal)Enum.Parse(typeof(Signal),light);
    }


    public Signal Light
    {
        get { return this.light; }
        set { this.light = value; }
    }

    public void Spinaroud()
    {
        this.Light = (Signal) (((int) this.Light + 1) % Enum.GetNames(typeof(Signal)).Length);
    }

    public override string ToString()
    {
        return $"{this.Light}";
    }
}