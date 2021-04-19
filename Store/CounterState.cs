using Fluxor;

namespace BlazorServer.Store
{
    public record CounterState(int Count)
    {
    }

    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState() => new CounterState(0);
    }
}
