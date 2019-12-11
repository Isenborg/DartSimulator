using System;

namespace Dart_Simulator
{
    class Turn
    {
        private int Throw1;
        private int Throw2;
        private int Throw3;

        public Turn(int _Throw1, int _Throw2, int _Throw3)
        {
            Throw1 = _Throw1;
            Throw2 = _Throw2;
            Throw3 = _Throw3;
        }

        public override string ToString()
        {
            return string.Format($"Throw 1: {Throw1}" +
                $"\nThrow 2: {Throw2}" +
                $"\nThrow 3: {Throw3}");
        }

    }
}