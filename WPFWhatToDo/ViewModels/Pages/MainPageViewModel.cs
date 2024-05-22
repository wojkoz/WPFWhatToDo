using System.Collections.ObjectModel;
using System.Windows.Input;
using WPFWhatToDo.Core;

namespace WPFWhatToDo;

public class MainPageViewModel
{
    public ObservableCollection<TaskViewModel> TaskList { get; set; } = new ObservableCollection<TaskViewModel>();

    public ICommand OpenCreateTaskPageCommand {  get; set; }

    public MainPageViewModel()
    {
        OpenCreateTaskPageCommand = new RelayCommand(OpenCreateTaskPage);
    }

    private void OpenCreateTaskPage()
    {

    }
}
