using CommunityToolkit.Mvvm.Input;
using FamilyCompanion.Models;

namespace FamilyCompanion.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}