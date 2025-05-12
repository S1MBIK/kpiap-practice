
using StatePatternLib.Interfaces;

namespace StatePatternLib
{
    public class Context
    {
        private IState state;

        public Context(IState initialState)
        {
            state = initialState;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}