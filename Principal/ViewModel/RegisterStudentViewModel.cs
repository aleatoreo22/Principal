using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Principal.Model;
using SkiaSharp;

namespace Principal.ViewModel;

public class RegisterStudentViewModel : DefaultNotifyProperty
{
    public RegisterStudentViewModel()
    {
        _student = new Student();
    }

    private Student _student;

    public Student Student
    {
        get => _student;
        set => SetField(ref _student, value);
    }

    private string _name = "";

    public string Name
    {
        get => _name;
        set
        {
            if (SetField(ref _name, value))
                _student.Name = value;
        }
    }

    public string Id => _student.Id.ToString();

    private string _mom = "";

    public string Mom
    {
        get => _mom;
        set
        {
            if (SetField(ref _mom, value))
                _student.Mom = value;
        }
    }

    private string _dad = "";

    public string Dad
    {
        get => _dad;
        set
        {
            if (SetField(ref _dad, value))
                _student.Dad = value;
        }
    }
}