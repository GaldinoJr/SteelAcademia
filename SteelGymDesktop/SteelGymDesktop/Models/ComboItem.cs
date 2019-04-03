namespace SteelGymDesktop.Models
{
    public class ComboItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public ComboItem(string Text, object Value)
        {
            this.Text = Text;
            this.Value = Value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
