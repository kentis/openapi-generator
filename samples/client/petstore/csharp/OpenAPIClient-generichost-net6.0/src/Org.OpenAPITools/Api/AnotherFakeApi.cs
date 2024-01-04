// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using System.Diagnostics.CodeAnalysis;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IAnotherFakeApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        AnotherFakeApiEvents Events { get; }

        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags and operation ID starting with number
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICall123TestSpecialTagsApiResponse"/>&gt;</returns>
        Task<ICall123TestSpecialTagsApiResponse> Call123TestSpecialTagsAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// To test special tags
        /// </summary>
        /// <remarks>
        /// To test special tags and operation ID starting with number
        /// </remarks>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICall123TestSpecialTagsApiResponse"/>&gt;</returns>
        Task<ICall123TestSpecialTagsApiResponse> Call123TestSpecialTagsOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ICall123TestSpecialTagsApiResponse"/>
    /// </summary>
    public interface ICall123TestSpecialTagsApiResponse : Org.OpenAPITools.Client.IApiResponse, IOk<Org.OpenAPITools.Model.ModelClient>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AnotherFakeApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnCall123TestSpecialTags;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorCall123TestSpecialTags;

        internal void ExecuteOnCall123TestSpecialTags(AnotherFakeApi.Call123TestSpecialTagsApiResponse apiResponse)
        {
            OnCall123TestSpecialTags?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorCall123TestSpecialTags(Exception exception)
        {
            OnErrorCall123TestSpecialTags?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class AnotherFakeApi : IAnotherFakeApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<AnotherFakeApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public AnotherFakeApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BasicTokenProvider"/>
        /// </summary>
        public TokenProvider<BasicToken> BasicTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="HttpSignatureTokenProvider"/>
        /// </summary>
        public TokenProvider<HttpSignatureToken> HttpSignatureTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnotherFakeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnotherFakeApi(ILogger<AnotherFakeApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, AnotherFakeApiEvents anotherFakeApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider,
            TokenProvider<BearerToken> bearerTokenProvider,
            TokenProvider<BasicToken> basicTokenProvider,
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider,
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<AnotherFakeApi>();
            HttpClient = httpClient;
            Events = anotherFakeApiEvents;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        partial void FormatCall123TestSpecialTags(ModelClient modelClient);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="modelClient"></param>
        /// <returns></returns>
        private void ValidateCall123TestSpecialTags(ModelClient modelClient)
        {
            if (modelClient == null)
                throw new ArgumentNullException(nameof(modelClient));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="modelClient"></param>
        private void AfterCall123TestSpecialTagsDefaultImplementation(ICall123TestSpecialTagsApiResponse apiResponseLocalVar, ModelClient modelClient)
        {
            bool suppressDefaultLog = false;
            AfterCall123TestSpecialTags(ref suppressDefaultLog, apiResponseLocalVar, modelClient);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="modelClient"></param>
        partial void AfterCall123TestSpecialTags(ref bool suppressDefaultLog, ICall123TestSpecialTagsApiResponse apiResponseLocalVar, ModelClient modelClient);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="modelClient"></param>
        private void OnErrorCall123TestSpecialTagsDefaultImplementation(Exception exception, string pathFormat, string path, ModelClient modelClient)
        {
            bool suppressDefaultLog = false;
            OnErrorCall123TestSpecialTags(ref suppressDefaultLog, exception, pathFormat, path, modelClient);
            if (!suppressDefaultLog)
                Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="modelClient"></param>
        partial void OnErrorCall123TestSpecialTags(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, ModelClient modelClient);

        /// <summary>
        /// To test special tags To test special tags and operation ID starting with number
        /// </summary>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICall123TestSpecialTagsApiResponse"/>&gt;</returns>
        public async Task<ICall123TestSpecialTagsApiResponse> Call123TestSpecialTagsOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await Call123TestSpecialTagsAsync(modelClient, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// To test special tags To test special tags and operation ID starting with number
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ICall123TestSpecialTagsApiResponse"/>&gt;</returns>
        public async Task<ICall123TestSpecialTagsApiResponse> Call123TestSpecialTagsAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateCall123TestSpecialTags(modelClient);

                FormatCall123TestSpecialTags(modelClient);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/another-fake/dummy";

                    httpRequestMessageLocalVar.Content = (modelClient as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(modelClient, _jsonSerializerOptions));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Patch;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<Call123TestSpecialTagsApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<Call123TestSpecialTagsApiResponse>();

                        Call123TestSpecialTagsApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/another-fake/dummy", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterCall123TestSpecialTagsDefaultImplementation(apiResponseLocalVar, modelClient);

                        Events.ExecuteOnCall123TestSpecialTags(apiResponseLocalVar);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorCall123TestSpecialTagsDefaultImplementation(e, "/another-fake/dummy", uriBuilderLocalVar.Path, modelClient);
                Events.ExecuteOnErrorCall123TestSpecialTags(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="Call123TestSpecialTagsApiResponse"/>
        /// </summary>
        public partial class Call123TestSpecialTagsApiResponse : Org.OpenAPITools.Client.ApiResponse, ICall123TestSpecialTagsApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<Call123TestSpecialTagsApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="Call123TestSpecialTagsApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public Call123TestSpecialTagsApiResponse(ILogger<Call123TestSpecialTagsApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Org.OpenAPITools.Model.ModelClient Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Org.OpenAPITools.Model.ModelClient>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Org.OpenAPITools.Model.ModelClient result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
