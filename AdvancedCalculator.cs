namespace Calculator
{
    public class AdvancedCalculator
    {
        public decimal _result { get; set; } = 0;
        public void Add(decimal input)
        {
            _result = _result + input;
        }
        public void Clear()
        {
            _result = 0;
        }
    }
}
