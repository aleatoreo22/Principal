using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Principal.Model;

namespace Principal.ViewModel;

public class StudentRegisterViewModel : DefaultNotifyProperty
{
    public StudentRegisterViewModel()
    {
        _student = new("");
    }

    private Student _student;
    public Student Student
    {
        get => _student;
        set
        {
            SetField(ref _student, value);
        } 
    }

    private string _name = "";
    public string Name
    {
        get => _name;
        set
        {
            SetField(ref _name, value);
        } 
    }
    
    private string _id = "";
    public string Id
    {
        get => _id;
        set
        {
            SetField(ref _id, value);
        } 
    }
    
    private string _mom = "";
    public string Mom
    {
        get => _mom;
        set
        {
            SetField(ref _mom, value);
        } 
    }
    
    private string _dad = "";
    public string Dad
    {
        get => _dad;
        set
        {
            SetField(ref _dad, value);
        } 
    }
}