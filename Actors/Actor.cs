namespace ENSEKUITests.Actors
{
    public class Actor<TWebElement> where TWebElement : AppElements
    {
        private ActorContext<TWebElement> ActorContext { get; }

        public IActorInteractionsContext<TWebElement> AttemptsTo => this.ActorContext;
        public IActorExpectationsContext<TWebElement> ExpectsTo => this.ActorContext;

        public Actor(TWebElement elements)
        {
            this.ActorContext = new ActorContext<TWebElement>(this, elements);
        }
    }

    public interface IActorContext<TWebElement> where TWebElement : AppElements
    {
        Actor<TWebElement> Actor { get; }
        TWebElement Elements { get; }
    }

    public interface IActorInteractionsContext<TWebElement> : IActorContext<TWebElement>
    where TWebElement : AppElements
    {

    }

    public interface IActorExpectationsContext<TWebElement> : IActorContext<TWebElement>
        where TWebElement : AppElements
    {

    }
}