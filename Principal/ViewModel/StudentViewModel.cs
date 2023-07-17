using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Principal.Command;
using Principal.Control.FrameButton;
using Principal.Model;

namespace Principal.ViewModel;

public class StudentViewModel : DefaultNotifyProperty
{
    private bool _registerIsVisible;
    private RegisterStudentViewModel _registerStudentViewModel = new();
    private SearchStudentViewModel _searchStudentViewModel = new();
    private FrameButtonViewModel _frameButtonViewModel = new();

    private List<Student> _students = new();

    public StudentViewModel()
    {
        _frameButtonViewModel.Insert = Insert;
        _frameButtonViewModel.Confirm = Confirm;
        _frameButtonViewModel.Search = Search;
    }

    public FrameButtonViewModel FrameButtonViewModel
    {
        get => _frameButtonViewModel;
        set => SetField(ref _frameButtonViewModel, value);
    }

    public SearchStudentViewModel SearchStudentViewModel
    {
        get => _searchStudentViewModel;
        set => SetField(ref _searchStudentViewModel, value);
    }

    public RegisterStudentViewModel RegisterStudentViewModel
    {
        get => _registerStudentViewModel;
        set => SetField(ref _registerStudentViewModel, value);
    }

    public bool RegisterIsVisible
    {
        get => _registerIsVisible;
        set
        {
            SetField(ref _registerIsVisible, value);
            _frameButtonViewModel.ConfirmFrameIsVisible = _registerIsVisible;
        }
    }

    public void Insert()
    {
        RegisterIsVisible = true;
        _registerStudentViewModel.Student = new Student();
    }

    public void Search()
    {
        _searchStudentViewModel.Grid = _students.Select(x =>
            new SearchStudentViewModel.GridStudent
            {
                Dad = x.Dad,
                Mom = x.Mom,
                Name = x.Name
            }).ToList();
    }

    public void Confirm()
    {
        try
        {
            Validate();
            _students.Add(_registerStudentViewModel.Student);
            RegisterIsVisible = false;
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void Validate()
    {
    }
}