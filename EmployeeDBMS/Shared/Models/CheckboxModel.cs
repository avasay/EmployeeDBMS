namespace EmployeeDBMS.Shared.Models
{
    public class CheckboxModel
    {
        public int Value { get; set; }
        public bool Checked { get; set; }

        public CheckboxModel()
        {
        }
        public CheckboxModel(int v, bool c)
        {
            Value = v;
            Checked = c;
        }
    }
}
