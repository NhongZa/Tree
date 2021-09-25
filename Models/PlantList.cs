using System;
using System.Collections.Generic;

class PlantList {
    private List<Rose> roses;
    private List<SunFlower> sunFlowers;

    public PlantList() {
        this.roses = new List<Rose>();
        this.sunFlowers = new List<SunFlower>();
    }

    public void AddRose(Rose rose) {
        this.roses.Add(rose);
    }

    public void AddSunFlowers(SunFlower sunFlower) {
        this.sunFlowers.Add(sunFlower);
    }

    public int GetTotalRoses() {
        return this.roses.Count;
    }

    public int GetTotalSunFlowers() {
        return this.sunFlowers.Count;
    }

    public void PrintRoseNames() {
        Console.WriteLine("Rose Information");
        Console.WriteLine("----------------");

        foreach (Rose rose in this.roses)
        {
            Console.WriteLine("Rose name: {0}", rose.GetPlantName());
        }
    }

    public void PrintSunFlowerNames() {
        Console.WriteLine("Sun Flowers Information");
        Console.WriteLine("----------------");

        foreach (SunFlower sunFlower in this.sunFlowers)
        {
            Console.WriteLine("Sun Flowers name: {0}", sunFlower.GetPlantName());
        }
    }

}