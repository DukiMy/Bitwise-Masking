using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bitwise_masking;

public class BitOperator ()
{
    public byte binaryA { get; private set; }
    public byte binaryB { get; private set; }
    public byte binaryResult { get; private set; }
    
    public BitOperator AND_Operation(byte a, byte b){
        this.binaryA = a;
        this.binaryB = b;
        this.binaryResult = (byte)(a & b);
        return this;
    }
    
    public BitOperator OR_Operation(byte a, byte b)
    {
        this.binaryA = a;
        this.binaryB = b;
        this.binaryResult = (byte)(a | b);
        return this;
    }

    public BitOperator XOR_Operation(byte a, byte b)
    {
        this.binaryA = a;
        this.binaryB = b;
        this.binaryResult = (byte)(a ^ b);
        return this;
    }

    public BitOperator NOT_Operation(byte a)
    {
        this.binaryA = a;
        this.binaryResult = (byte)~a;
        return this;
    }

    public BitOperator LEFT_SHIFT_Operation(byte a, byte b)
    {
        this.binaryA = a;
        this.binaryB = b;
        this.binaryResult = (byte)(a << b);
        return this;
    }

    public BitOperator RIGHT_SHIFT_Operation(byte a, byte b)
    {
        this.binaryA = a;
        this.binaryB = b;
        this.binaryResult = (byte)(a >> b);
        return this;
    }

    public void PresentTable(string operation)
    {
        Console.Write(new Formatter(this, operation).ToString());
    }
}
