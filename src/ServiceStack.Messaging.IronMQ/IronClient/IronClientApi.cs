using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ServiceStack.Messaging.IronMQ.IronClient
{
    /// <summary>
    /// Implementation of the basic actions in the IronMQ API
    /// </summary>
    internal class IronClientApi
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="IronClientApi"/> class.
        /// </summary>
        public IronClientApi()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="IronClientApi" /> class.
        /// </summary>
        /// <param name="authToken">The IronMQ auth token.</param>
        /// <param name="projectId">The IronMQ project id.</param>
        /// <param name="baseUrl">The base URL. Valid base urls can be found at: http://dev.iron.io/mq/reference/api/#base_url</param>
        public IronClientApi(string authToken, string projectId, string baseUrl)
        {
            Configure(authToken, projectId, baseUrl);
        }

        /// <summary>
        /// Configures the instance.
        /// </summary>
        /// <param name="authToken">The auth token.</param>
        /// <param name="projectId">The project id.</param>
        /// <param name="baseUrl">The base URL. Valid base urls can be found at: http://dev.iron.io/mq/reference/api/#base_url</param>
        public void Configure(string authToken, string projectId, string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(authToken))
            {
                throw new ArgumentNullException("authToken", "AuthToken is null");
            }
            if (string.IsNullOrWhiteSpace(projectId))
            {
                throw new ArgumentNullException("projectId", "ProjectId is null");
            }
            if (string.IsNullOrWhiteSpace(baseUrl))
            {
                throw new ArgumentNullException("baseUrl", "BaseUrl is null");
            }

            AuthToken = authToken;
            ProjectId = projectId;
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Enqueues the specified element in the queue.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element">The element.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Enqueue<T>(T element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Dequeues an message of type T from the queue.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public T Dequeue<T>()
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <remarks>
        /// Common gateway method responsible for setting auth headers, correct URL and so forth.
        /// </remarks>
        /// <typeparam name="T">The element that is either being sent or fetched from the queues</typeparam>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        private T Execute<T>(RestRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets or sets the auth token.
        /// </summary>
        /// <value>
        /// The auth token.
        /// </value>
        public string AuthToken { get; set; }

        /// <summary>
        /// Gets or sets the project id.
        /// </summary>
        /// <value>
        /// The project id.
        /// </value>
        public string ProjectId { get; set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }
    }
}
