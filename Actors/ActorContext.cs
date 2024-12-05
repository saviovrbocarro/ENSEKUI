using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Actors
{
    public class ActorContext<TWebElement> : IActorContextWrapper<TWebElement>
        where TWebElement : AppElements
    {
        private readonly Actor<TWebElement> actor;
        private readonly TWebElement elements;

        public ActorContext(Actor<TWebElement> actor, TWebElement elements)
        {
            this.actor = actor;
            this.elements = elements;
        }

        Actor<TWebElement> IActorContext<TWebElement>.Actor => this.actor;

        TWebElement IActorContext<TWebElement>.Elements => this.elements;
    }
}
