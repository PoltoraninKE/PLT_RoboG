using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoParserAndLexer.TestModels
{
    public interface ITankEntity
    {
        public void TurnToLeft(float degrees);
        public void TurnToRight(float degrees);
        public void MoveForward(float movementRange);
        public void MoveBackward(float movementRange);

    }
}
