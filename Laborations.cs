namespace bitwise_masking;
public static class Laborations
{
    public static void Run()
    {
        BitOperator bo = new();
        BitwiseAND_laboration();

        void BitwiseAND_laboration()
        {
            bo.AND_Operation(0b_0000_0000, 0b_0000_0000).PresentTable("AND");
            bo.AND_Operation(0b_0000_0001, 0b_0000_0000).PresentTable("AND");
            bo.AND_Operation(0b_0000_0000, 0b_0000_0001).PresentTable("AND");
            bo.AND_Operation(0b_0000_0001, 0b_0000_0001).PresentTable("AND");

            /** 
                RESULT:
                ┌────────────────────────────┐
                │Operation:     AND          │
                │Binary A:      0000_0000 = 0│
                │Binary B:      0000_0000 = 0│
                │Result:        0000_0000 = 0│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     AND          │
                │Binary A:      0000_0001 = 1│
                │Binary B:      0000_0000 = 0│
                │Result:        0000_0000 = 0│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     AND          │
                │Binary A:      0000_0000 = 0│
                │Binary B:      0000_0001 = 1│
                │Result:        0000_0000 = 0│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     AND          │
                │Binary A:      0000_0001 = 1│
                │Binary B:      0000_0001 = 1│
                │Result:        0000_0001 = 1│
                └────────────────────────────┘
            */
        }
        void BitwiseOR_laboration()
        {
            bo.OR_Operation(0b_0000_0000, 0b_0000_0000).PresentTable("OR");
            bo.OR_Operation(0b_0000_0001, 0b_0000_0000).PresentTable("OR");
            bo.OR_Operation(0b_0000_0000, 0b_0000_0001).PresentTable("OR");
            bo.OR_Operation(0b_0000_0001, 0b_0000_0001).PresentTable("OR");

            /**
                ┌────────────────────────────┐
                │Operation:     OR           │
                │Binary A:      0000_0000 = 0│
                │Binary B:      0000_0000 = 0│
                │Result:        0000_0000 = 0│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     OR           │
                │Binary A:      0000_0001 = 1│
                │Binary B:      0000_0000 = 0│
                │Result:        0000_0001 = 1│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     OR           │
                │Binary A:      0000_0000 = 0│
                │Binary B:      0000_0001 = 1│
                │Result:        0000_0001 = 1│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     OR           │
                │Binary A:      0000_0001 = 1│
                │Binary B:      0000_0001 = 1│
                │Result:        0000_0001 = 1│
                └────────────────────────────┘
            */
        }
        void BitwiseXOR_laboration()
        {
            bo.XOR_Operation(0b_0000_0000, 0b_0000_0000).PresentTable("XOR");
            bo.XOR_Operation(0b_0000_0001, 0b_0000_0000).PresentTable("XOR");
            bo.XOR_Operation(0b_0000_0000, 0b_0000_0001).PresentTable("XOR");
            bo.XOR_Operation(0b_0000_0001, 0b_0000_0001).PresentTable("XOR");

            /**
                ┌────────────────────────────┐
                │Operation:     XOR          │
                │Binary A:      0000_0000 = 0│
                │Binary B:      0000_0000 = 0│
                │Result:        0000_0000 = 0│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     XOR          │
                │Binary A:      0000_0001 = 1│
                │Binary B:      0000_0000 = 0│
                │Result:        0000_0001 = 1│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     XOR          │
                │Binary A:      0000_0000 = 0│
                │Binary B:      0000_0001 = 1│
                │Result:        0000_0001 = 1│
                └────────────────────────────┘
                ┌────────────────────────────┐
                │Operation:     XOR          │
                │Binary A:      0000_0001 = 1│
                │Binary B:      0000_0001 = 1│
                │Result:        0000_0000 = 0│
                └────────────────────────────┘
            */
        }
        void BitwiseNOT_laboration()
        {
            bo.NOT_Operation(0b_0000_0000).PresentTable("NOT");
            bo.NOT_Operation(0b_0000_0001).PresentTable("NOT");

            /**
                ┌──────────────────────────────┐
                │Operation:     NOT            │
                │Binary A:      0000_0000 = 0  │
                │Binary B:      0000_0000 = 0  │
                │Result:        1111_1111 = 255│
                └──────────────────────────────┘
                ┌──────────────────────────────┐
                │Operation:     NOT            │
                │Binary A:      0000_0001 = 1  │
                │Binary B:      0000_0000 = 0  │
                │Result:        1111_1110 = 254│
                └──────────────────────────────┘
            */
        }
        void BitwiseLEFT_SHIFT_laboration()
        {
            bo.LEFT_SHIFT_Operation(0b_0000_0001, 0b_0000_0001).PresentTable("LEFT SHIFT");
            bo.LEFT_SHIFT_Operation(0b_0000_0001, 0b_0000_0010).PresentTable("LEFT SHIFT");
            bo.LEFT_SHIFT_Operation(0b_0000_0001, 0b_0000_0100).PresentTable("LEFT SHIFT");
            bo.LEFT_SHIFT_Operation(0b_0000_0001, 0b_0000_1000).PresentTable("LEFT SHIFT");

            /**
                    ┌────────────────────────────┐
                    │Operation:     LEFT SHIFT   │
                    │Binary A:      0000_0001 = 1│
                    │Binary B:      0000_0001 = 1│
                    │Result:        0000_0010 = 2│
                    └────────────────────────────┘
                    ┌────────────────────────────┐
                    │Operation:     LEFT SHIFT   │
                    │Binary A:      0000_0001 = 1│
                    │Binary B:      0000_0010 = 2│
                    │Result:        0000_0100 = 4│
                    └────────────────────────────┘
                    ┌─────────────────────────────┐
                    │Operation:     LEFT SHIFT    │
                    │Binary A:      0000_0001 = 1 │
                    │Binary B:      0000_0100 = 4 │
                    │Result:        0001_0000 = 16│
                    └─────────────────────────────┘
                *┌────────────────────────────┐
                    │Operation:     LEFT SHIFT   │
                    │Binary A:      0000_0001 = 1│
                    │Binary B:      0000_1000 = 8│
                    │Result:        0000_0000 = 0│
                    └────────────────────────────┘
                    * Shifting by 8 or more results in 0, as the byte is only 8 bits long.
            */
        }
        void BitwiseRIGHT_SHIFT_laboration()
        {
            bo.RIGHT_SHIFT_Operation(0b_0001_0000, 0b_0000_0001).PresentTable("RIGHT SHIFT");
            bo.RIGHT_SHIFT_Operation(0b_0001_0000, 0b_0000_0010).PresentTable("RIGHT SHIFT");
            bo.RIGHT_SHIFT_Operation(0b_0001_0000, 0b_0000_0011).PresentTable("RIGHT SHIFT");
            bo.RIGHT_SHIFT_Operation(0b_0001_0000, 0b_0000_0100).PresentTable("RIGHT SHIFT");
            /**
                ┌─────────────────────────────┐
                │Operation:     RIGHT SHIFT   │
                │Binary A:      0001_0000 = 16│
                │Binary B:      0000_0001 = 1 │
                │Result:        0000_1000 = 8 │
                └─────────────────────────────┘
                ┌─────────────────────────────┐
                │Operation:     RIGHT SHIFT   │
                │Binary A:      0001_0000 = 16│
                │Binary B:      0000_0010 = 2 │
                │Result:        0000_0100 = 4 │
                └─────────────────────────────┘
                ┌─────────────────────────────┐
                │Operation:     RIGHT SHIFT   │
                │Binary A:      0001_0000 = 16│
                │Binary B:      0000_0011 = 3 │
                │Result:        0000_0010 = 2 │
                └─────────────────────────────┘
                ┌─────────────────────────────┐
                │Operation:     RIGHT SHIFT   │
                │Binary A:      0001_0000 = 16│
                │Binary B:      0000_0100 = 4 │
                │Result:        0000_0001 = 1 │
                └─────────────────────────────┘
            */
        }
    }
}
