namespace maui_hello_world.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class CountViewModel: ObservableObject
{
  [ObservableProperty]
  private int count;

  [RelayCommand]
  public void UpdateCount(int? value = null) {
    Count = value ?? Count + 1;
  }
}
