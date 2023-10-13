using System;
using System.IO;
using System.Collections.Generic;

namespace StudentInfo
{
    class Student
    {
        private string _surname;
        private string _group;
        private string _studyForm;
        private double _averageScore;

        public Student(string surname, string group, string studyForm, double averageScore)
        {
            _surname = surname;
            _group = group;
            _studyForm = studyForm;
            _averageScore = averageScore;
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public string StudyForm
        {
            get { return _studyForm; }
            set { _studyForm = value; }
        }

        public double AverageScore
        {
            get { return _averageScore; }
            set { _averageScore = value; }
        }
    }
}