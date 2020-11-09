using System;
using System.Linq;

namespace XorHexadecimal
{
    public class HexString
    {
        private byte[] _data;

        public HexString(string data)
        {
            if ((data.Length & 1) != 0) throw new ArgumentException("Hex string must have an even number of digits.");

            _data = Enumerable.Range(0, data.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(data.Substring(x, 2), 16))
                .ToArray();
        }

        public HexString(byte[] data)
        {
            _data = data;
        }


        public override string ToString()
        {
            string hex = BitConverter.ToString(_data);
            return hex.Replace("-", "");
        }

        static public HexString operator ^(HexString LHS, HexString RHS)
        {
            return new HexString
                (
                    LHS._data.Zip
                        (
                            RHS._data,
                            (a, b) => (byte)(a ^ b)
                        )
                    .ToArray()
                );
        }
    }
}
