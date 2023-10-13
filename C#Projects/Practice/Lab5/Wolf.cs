using System;
using System.Collections;
using System.Collections.Generic;

public class Wolf
{
    private string _name;
    private int _age;
    private string _gender;

    public Wolf(string name, int age, string gender)
    {
        _name = name;
        _age = age;
        _gender = gender;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public string Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
}