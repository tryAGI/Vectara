#nullable enable

namespace Vectara
{
    public partial interface ITableExtractorsClient
    {
        /// <summary>
        /// List supported table extractors<br/>
        /// Table extractors are used to extract tabular data from documents during indexing.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vectara.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vectara.ListTableExtractorsResponse> ListTableExtractorsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}