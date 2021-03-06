// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HelloListOperations.
    /// </summary>
    public static partial class HelloListOperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ListResult> Get(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList))
            {
                return operations.GetAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ListResult>> GetAsync(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ListResult> Create(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList))
            {
                return operations.CreateAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ListResult>> CreateAsync(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ListResult> Post(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList))
            {
                return operations.PostAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ListResult>> PostAsync(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static IList<ListResult> Delete(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList))
            {
                return operations.DeleteAsync(names, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='names'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ListResult>> DeleteAsync(this IHelloListOperations operations, IList<string> names = default(IList<string>), HelloList body = default(HelloList), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(names, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
