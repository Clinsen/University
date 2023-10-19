using System;

interface IShape
{
    double CalculateArea();
    void Draw(int x, int y);
    void DisplayColor(string color);
    string GetCenterCoordinates();
}