using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using Principal.Model;

namespace Principal.ViewModel;

public class SearchStudentViewModel : DefaultNotifyProperty
{
    public class GridStudent
    {
        public string Name { get; set; }
        public string Mom { get; set; }
        public string Dad { get; set; }
    }

    private List<GridStudent> _grid = new();

    public List<GridStudent> Grid
    {
        get => _grid;
        set => SetField(ref _grid, value);
    }
}