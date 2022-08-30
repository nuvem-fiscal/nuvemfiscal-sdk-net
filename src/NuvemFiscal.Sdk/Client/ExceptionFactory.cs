/*
 * Nuvem Fiscal - SDK para .NET
 * https://www.nuvemfiscal.com.br
 */


using System;

namespace NuvemFiscal.Sdk.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
