
using EmployeeDBMS.Shared.Models;

namespace EmployeeDBMS.Shared
{
    public class MyStateObject
    {
        public List<CheckboxModel> Value { get; set; }

        public event Action OnStateChange;

        public void SetValue(List<CheckboxModel> value)
        {
            Value = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
