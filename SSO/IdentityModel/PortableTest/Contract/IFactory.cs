using System;
using IdentityModel.Client;

namespace Contract
{
    public interface IFactory
    {
        void Execute(Action<AuthorizeResponse> callbackFunction);
    }
}
