using StatePatternLib.Interfaces;

namespace StatePatternLib.Implementations
{
    public class StateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Состояние A");
            context.SetState(new StateB());
        }
    }
}