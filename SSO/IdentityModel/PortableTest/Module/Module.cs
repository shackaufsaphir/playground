using System;
using Contract;
using IdentityModel.Client;

namespace Module
{
    public class Module : IFactory
    {
        public void Execute(Action<AuthorizeResponse> callbackFunction)
        {
            throw new NotImplementedException();
        }
    }
}
