public static string DecToBin(int decimalNumber, int numBits)
{
    string binary = Convert.ToString(decimalNumber, 2);
    return binary.PadLeft(numBits, '0');
}
