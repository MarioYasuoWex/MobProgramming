namespace SimpleCalculator
{
    public enum Operations
    {
        Sum,
        Subtraction,
        Multiplication,
        Division,
    }

    public class OperationModel
    {
        public double NumberLeft { get; private set; }
        public double NumberRight { get; private set; }

        public double Remainder { get; private set; }

        public Operations Operation { get; private set; }

        public OperationModel(double numberLeft, double numberRight, string operation)
        {
            NumberLeft = numberLeft;
            NumberRight = numberRight;
            Operation = ParseOperationToEnum(operation);
        }

        public OperationModel(string numberLeft, string numberRight, string operation)
        {
            NumberLeft = double.Parse(numberLeft);
            NumberRight = double.Parse(numberRight);
            Operation = ParseOperationToEnum(operation);
        }

        public string GetOperationAsString() => $"{NumberLeft}{ParseOperationToString(Operation)}{NumberRight}";

        public double PerformOperation()
        {
            switch (Operation) 
            {
                case Operations.Sum:
                    return NumberLeft + NumberRight;
                case Operations.Subtraction:
                    return NumberLeft - NumberRight;
                case Operations.Multiplication:
                    return NumberLeft * NumberRight;
                case Operations.Division:
                    Remainder = NumberLeft % NumberRight;
                    return NumberLeft / NumberRight;
                default:
                    throw new NotImplementedException();
            }
        }

        public static Operations ParseOperationToEnum(string operation)
        {
            switch (operation)
            {
                case "+": 
                    return Operations.Sum;
                case "-":
                    return Operations.Subtraction;
                case "*":
                    return Operations.Multiplication;
                case "/": 
                    return Operations.Division;
                default:
                    throw new NotImplementedException();
            }
        }

        public static string ParseOperationToString(Operations operation)
        {
            switch (operation)
            {
                case Operations.Sum:
                    return "+";
                case Operations.Subtraction:
                    return "-";
                case Operations.Multiplication:
                    return "*";
                case Operations.Division:
                    return "/";
                default: 
                    throw new NotImplementedException();
            }
        }
    }
}
