namespace maui_hello_world.ViewModels;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class CountViewModel : INotifyPropertyChanged
{
  private int count;

  public int Count
  {
    get { return count; }
    set
    {
      if (count != value) return;
      
      count = value;
      NotifyPropertyChanged();
    }
  }

  public void UpdateCount(int? value = null)
  {
    Count = value ?? Count + 1;
  }

  public CountViewModel()
  {
    this.UpdateCountCommand = new Command(() => { this.UpdateCount(); });
  }

  public Command UpdateCountCommand { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;
  public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
  {
    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}
