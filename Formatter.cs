using System.Numerics;
using System.Text;

namespace bitwise_masking;

public class Formatter
{
    private byte binaryA;
    private byte binaryB;
    private byte binaryResult;
    private string formattedBinaryA;
    private string formattedBinaryB;
    private string formattedBinaryResult;
    private string operation;
    private StringBuilder sb = new();

   public Formatter(BitOperator bo, string _operation)
    {
        binaryA = bo.binaryA;
        binaryB = bo.binaryB;
        binaryResult = bo.binaryResult;

        formattedBinaryA = Convert.ToString(binaryA, 2).PadLeft(8, '0').Insert(4, "_");
        formattedBinaryB = Convert.ToString(binaryB, 2).PadLeft(8, '0').Insert(4, "_");
        formattedBinaryResult = Convert.ToString(binaryResult, 2).PadLeft(8, '0').Insert(4, "_");
        operation = _operation;

        Format();
        Console.WriteLine(sb.ToString());
        sb.Clear();
    }

    private void Format()
    {
        // Present before
        sb.AppendLine($"\t\t┌────────────────────────────┐");
        sb.AppendLine($"\t\t│Operation: \t{operation}\t     │");
        sb.AppendLine($"\t\t│Binary A:\t{formattedBinaryA} = {binaryA}│");
        sb.AppendLine($"\t\t│Binary B:\t{formattedBinaryB} = {binaryB}│");

        // Present after
        sb.AppendLine($"\t\t│Result: \t{formattedBinaryResult} = {binaryResult}│");
        sb.Append($"\t\t└────────────────────────────┘");

    }

    public override string ToString()
    {
        return sb.ToString();
    }
}
