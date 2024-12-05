using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Actors
{
    public interface IActorContextWrapper<T> :
        IActorInteractionsContext<T>,
        IActorExpectationsContext<T> where T : AppElements
    {
    }
}
