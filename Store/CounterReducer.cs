using Fluxor;

namespace BlazorServer.Store
{
    public class CounterReducer : Reducer<CounterState, IncrementCounterAction>
    {
        public override CounterState Reduce(CounterState state, IncrementCounterAction action) => 
            new CounterState(state.Count + 1);
    }
}
