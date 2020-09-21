// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.BigQueryReservation.v1alpha2
{
    /// <summary>The BigQueryReservation Service.</summary>
    public class BigQueryReservationService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BigQueryReservationService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BigQueryReservationService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "bigqueryreservation";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://bigqueryreservation.googleapis.com/";
        #else
            "https://bigqueryreservation.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://bigqueryreservation.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the BigQuery Reservation API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data in Google BigQuery</summary>
            public static string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the BigQuery Reservation API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data in Google BigQuery</summary>
            public const string Bigquery = "https://www.googleapis.com/auth/bigquery";

            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for BigQueryReservation requests.</summary>
    public abstract class BigQueryReservationBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BigQueryReservationBaseServiceRequest instance.</summary>
        protected BigQueryReservationBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes BigQueryReservation parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);

        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
                ReservationGrants = new ReservationGrantsResource(service);
                Reservations = new ReservationsResource(service);

            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best
                /// effort to cancel the operation, but success is not guaranteed. If the server doesn't support this
                /// method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                /// methods to check whether the cancellation succeeded or whether the operation completed despite
                /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                /// `Code.CANCELLED`.</summary>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(service, name);
                }

                /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best
                /// effort to cancel the operation, but success is not guaranteed. If the server doesn't support this
                /// method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                /// methods to check whether the cancellation succeeded or whether the operation completed despite
                /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                /// `Code.CANCELLED`.</summary>
                public class CancelRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Empty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+name}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }

                }

                /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
                /// operation result at intervals as recommended by the API service.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
                /// operation result at intervals as recommended by the API service.</summary>
                public class GetRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                        });
                    }

                }
            }
            /// <summary>Gets the ReservationGrants resource.</summary>
            public virtual ReservationGrantsResource ReservationGrants { get; }

            /// <summary>The "reservationGrants" collection of methods.</summary>
            public class ReservationGrantsResource
            {
                private const string Resource = "reservationGrants";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReservationGrantsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have 'bigquery.admin'
                /// permissions on the project using the reservation and the project that owns this reservation. Returns
                /// `google.rpc.Code.INVALID_ARGUMENT` when location of the grant does not match location of the
                /// reservation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">The parent resource name of the reservation grant E.g.:
                /// projects/myproject/location/eu.</param>
                public virtual CreateRequest Create(Google.Apis.BigQueryReservation.v1alpha2.Data.ReservationGrant body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have 'bigquery.admin'
                /// permissions on the project using the reservation and the project that owns this reservation. Returns
                /// `google.rpc.Code.INVALID_ARGUMENT` when location of the grant does not match location of the
                /// reservation.</summary>
                public class CreateRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.ReservationGrant>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1alpha2.Data.ReservationGrant body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The parent resource name of the reservation grant E.g.:
                    /// projects/myproject/location/eu.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1alpha2.Data.ReservationGrant Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+parent}/reservationGrants";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }

                }

                /// <summary>Deletes a reservation grant. No expansion will happen. E.g: organizationA contains project1
                /// and project2. Reservation res1 exists. CreateReservationGrant was invoked previously and following
                /// grants were created explicitly: Then deletion of won't affect . After deletion of , queries from
                /// project1 will still use res1, while queries from project2 will use on-demand mode.</summary>
                /// <param name="name">Name of the resource, e.g.: projects/myproject/locations/eu/reservationGrants/123</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a reservation grant. No expansion will happen. E.g: organizationA contains project1
                /// and project2. Reservation res1 exists. CreateReservationGrant was invoked previously and following
                /// grants were created explicitly: Then deletion of won't affect . After deletion of , queries from
                /// project1 will still use res1, while queries from project2 will use on-demand mode.</summary>
                public class DeleteRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Name of the resource, e.g.:
                    /// projects/myproject/locations/eu/reservationGrants/123</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservationGrants/[^/]+$",
                        });
                    }

                }

                /// <summary>Lists reservation grants. Only explicitly created grants will be returned. E.g:
                /// organizationA contains project1 and project2. Reservation res1 exists. CreateReservationGrant was
                /// invoked previously and following grants were created explicitly: Then this API will just return the
                /// above two grants for reservation res1, and no expansion/merge will happen.</summary>
                /// <param name="parent">The parent resource name e.g.: projects/myproject/location/eu.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists reservation grants. Only explicitly created grants will be returned. E.g:
                /// organizationA contains project1 and project2. Reservation res1 exists. CreateReservationGrant was
                /// invoked previously and following grants were created explicitly: Then this API will just return the
                /// above two grants for reservation res1, and no expansion/merge will happen.</summary>
                public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.ListReservationGrantsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>The parent resource name e.g.: projects/myproject/location/eu.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+parent}/reservationGrants";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }
            }
            /// <summary>Gets the Reservations resource.</summary>
            public virtual ReservationsResource Reservations { get; }

            /// <summary>The "reservations" collection of methods.</summary>
            public class ReservationsResource
            {
                private const string Resource = "reservations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ReservationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    SlotPools = new SlotPoolsResource(service);

                }

                /// <summary>Gets the SlotPools resource.</summary>
                public virtual SlotPoolsResource SlotPools { get; }

                /// <summary>The "slotPools" collection of methods.</summary>
                public class SlotPoolsResource
                {
                    private const string Resource = "slotPools";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SlotPoolsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Deletes a slot pool. Attempting to delete slot pool before its commitment_end_time will
                    /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.</summary>
                    /// <param name="name">Resource name of the slot pool to delete. E.g., projects/myproject/locations/us-
                    /// central1/reservations/my_reservation/slotPools/123</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a slot pool. Attempting to delete slot pool before its commitment_end_time will
                    /// fail with the error code `google.rpc.Code.FAILED_PRECONDITION`.</summary>
                    public class DeleteRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Resource name of the slot pool to delete. E.g., projects/myproject/locations/us-
                        /// central1/reservations/my_reservation/slotPools/123</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha2/{+name}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/slotPools/[^/]+$",
                            });
                        }

                    }

                    /// <summary>Returns information about the slot pool.</summary>
                    /// <param name="name">Resource name of the slot pool to retrieve. E.g., projects/myproject/locations/us-
                    /// central1/reservations/my_reservation/slotPools/123</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Returns information about the slot pool.</summary>
                    public class GetRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.SlotPool>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Resource name of the slot pool to retrieve. E.g., projects/myproject/locations/us-
                        /// central1/reservations/my_reservation/slotPools/123</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha2/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/slotPools/[^/]+$",
                            });
                        }

                    }

                    /// <summary>Lists all the slot pools for the reservation.</summary>
                    /// <param name="parent">Resource name of the parent reservation. Only top-level reservations can have slot pools. E.g.,
                    /// projects/myproject/locations/us-central1/reservations/my_reservation</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists all the slot pools for the reservation.</summary>
                    public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.ListSlotPoolsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Resource name of the parent reservation. Only top-level reservations can have slot
                        /// pools. E.g., projects/myproject/locations/us-central1/reservations/my_reservation</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of items to return.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha2/{+parent}/slotPools";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+$",
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }

                    }
                }

                /// <summary>Creates a new reservation resource. Multiple reservations are created if the ancestor
                /// reservations do not exist.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Project, location, and (optionally) reservation name. E.g., projects/myproject/locations/us-
                /// central1/reservations/parent</param>
                public virtual CreateRequest Create(Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a new reservation resource. Multiple reservations are created if the ancestor
                /// reservations do not exist.</summary>
                public class CreateRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Project, location, and (optionally) reservation name. E.g.,
                    /// projects/myproject/locations/us-central1/reservations/parent</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The reservation ID relative to the parent, e.g., "dev". This field must only contain
                    /// alphanumeric characters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("reservationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReservationId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+parent}/reservations";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("reservationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reservationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Creates a new reservation resource. Multiple reservations are created if the ancestor
                /// reservations do not exist.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Project, location, and (optionally) reservation name. E.g., projects/myproject/locations/us-
                /// central1/reservations/parent</param>
                public virtual CreateReservationRequest CreateReservation(Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation body, string parent)
                {
                    return new CreateReservationRequest(service, body, parent);
                }

                /// <summary>Creates a new reservation resource. Multiple reservations are created if the ancestor
                /// reservations do not exist.</summary>
                public class CreateReservationRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation>
                {
                    /// <summary>Constructs a new CreateReservation request.</summary>
                    public CreateReservationRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Project, location, and (optionally) reservation name. E.g.,
                    /// projects/myproject/locations/us-central1/reservations/parent</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The reservation ID relative to the parent, e.g., "dev". This field must only contain
                    /// alphanumeric characters.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("reservationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ReservationId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "createReservation";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+parent}";

                    /// <summary>Initializes CreateReservation parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/.*$",
                        });
                        RequestParameters.Add("reservationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "reservationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Deletes a reservation. Returns `google.rpc.Code.FAILED_PRECONDITION` in the following
                /// cases: 1. When reservation has child reservations. This check can be bypassed by setting
                /// DeleteReservationRequest.force flag to true. 2. When top-level reservation with slot pools is being
                /// deleted.</summary>
                /// <param name="name">Resource name of the reservation to retrieve. E.g., projects/myproject/locations/us-
                /// central1/reservations/my_reservation</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a reservation. Returns `google.rpc.Code.FAILED_PRECONDITION` in the following
                /// cases: 1. When reservation has child reservations. This check can be bypassed by setting
                /// DeleteReservationRequest.force flag to true. 2. When top-level reservation with slot pools is being
                /// deleted.</summary>
                public class DeleteRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Resource name of the reservation to retrieve. E.g., projects/myproject/locations/us-
                    /// central1/reservations/my_reservation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>If true, deletes all the child reservations of the given reservation. Otherwise,
                    /// attempting to delete a reservation that has child reservations will fail with error code
                    /// `google.rpc.Code.FAILED_PRECONDITION`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Force { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/.*$",
                        });
                        RequestParameters.Add("force", new Google.Apis.Discovery.Parameter
                        {
                            Name = "force",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Returns information about the reservation.</summary>
                /// <param name="name">Resource name of the reservation to retrieve. E.g., projects/myproject/locations/us-
                /// central1/reservations/path/to/reserv</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Returns information about the reservation.</summary>
                public class GetRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Resource name of the reservation to retrieve. E.g., projects/myproject/locations/us-
                    /// central1/reservations/path/to/reserv</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/.*$",
                        });
                    }

                }

                /// <summary>Lists all the reservations for the project in the specified location.</summary>
                /// <param name="parent">The parent resource name containing project and location, e.g.: "projects/myproject/locations
                /// /us-central1"</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all the reservations for the project in the specified location.</summary>
                public class ListRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.ListReservationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>The parent resource name containing project and location, e.g.:
                    /// "projects/myproject/locations/us-central1"</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Can be used to filter out reservations based on names, capacity, etc, e.g.:
                    /// filter="reservation.slot_capacity > 200" filter="reservation.name = \"*dev\"" Advanced filtering
                    /// syntax can be [here](https://cloud.google.com/logging/docs/view/advanced-filters).</summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>The maximum number of items to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+parent}/reservations";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }

                /// <summary>Updates an existing reservation resource. Applicable only for child reservations.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The resource name of the reservation, e.g., "projects/locations/reservations/dev/team/product".
                /// Reservation names (e.g., "dev/team/product") exceeding a depth of six will fail with
                /// `google.rpc.Code.INVALID_ARGUMENT`.</param>
                public virtual PatchRequest Patch(Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates an existing reservation resource. Applicable only for child reservations.</summary>
                public class PatchRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The resource name of the reservation, e.g.,
                    /// "projects/locations/reservations/dev/team/product". Reservation names (e.g., "dev/team/product")
                    /// exceeding a depth of six will fail with `google.rpc.Code.INVALID_ARGUMENT`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Standard field mask for the set of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.BigQueryReservation.v1alpha2.Data.Reservation Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha2/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/reservations/[^/]+/.*$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }

                }
            }

            /// <summary>Look up grants for a specified resource for a particular region. If the request is about a
            /// project: 1) Grants created on the project will be returned if they exist. 2) Otherwise grants created on
            /// the closest ancestor will be returned. 3) Grants for different JobTypes will all be returned. Same logic
            /// applies if the request is about a folder. If the request is about an organization, then grants created
            /// on the organization will be returned (organization doesn't have ancestors). Comparing to
            /// ListReservationGrants, there are two behavior differences: 1) permission on the grantee will be verified
            /// in this API. 2) Hierarchy lookup (project->folder->organization) happens in this API.</summary>
            /// <param name="parent">The parent resource name (containing project and location), which owns the grants. e.g.:
            /// "projects/myproject/locations/us-central1".</param>
            public virtual SearchReservationGrantsRequest SearchReservationGrants(string parent)
            {
                return new SearchReservationGrantsRequest(service, parent);
            }

            /// <summary>Look up grants for a specified resource for a particular region. If the request is about a
            /// project: 1) Grants created on the project will be returned if they exist. 2) Otherwise grants created on
            /// the closest ancestor will be returned. 3) Grants for different JobTypes will all be returned. Same logic
            /// applies if the request is about a folder. If the request is about an organization, then grants created
            /// on the organization will be returned (organization doesn't have ancestors). Comparing to
            /// ListReservationGrants, there are two behavior differences: 1) permission on the grantee will be verified
            /// in this API. 2) Hierarchy lookup (project->folder->organization) happens in this API.</summary>
            public class SearchReservationGrantsRequest : BigQueryReservationBaseServiceRequest<Google.Apis.BigQueryReservation.v1alpha2.Data.SearchReservationGrantsResponse>
            {
                /// <summary>Constructs a new SearchReservationGrants request.</summary>
                public SearchReservationGrantsRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>The parent resource name (containing project and location), which owns the grants. e.g.:
                /// "projects/myproject/locations/us-central1".</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of items to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Please specify resource name as grantee in the query. e.g., "grantee=projects/myproject"
                /// "grantee=folders/123" "grantee=organizations/456"</summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }


                /// <summary>Gets the method name.</summary>
                public override string MethodName => "searchReservationGrants";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha2/{+parent}:SearchReservationGrants";

                /// <summary>Initializes SearchReservationGrants parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

            }
        }
    }
}

namespace Google.Apis.BigQueryReservation.v1alpha2.Data
{    

    /// <summary>The metadata for operation returned from ReservationService.CreateSlotPool.</summary>
    public class CreateSlotPoolMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource name of the slot pool that is being created. E.g., projects/myproject/locations/us-
        /// central1/reservations/foo/slotPools/123</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotPool")]
        public virtual string SlotPool { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response for ReservationService.ListReservationGrants.</summary>
    public class ListReservationGrantsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of reservation grants visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationGrants")]
        public virtual System.Collections.Generic.IList<ReservationGrant> ReservationGrants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response for ReservationService.ListReservations.</summary>
    public class ListReservationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of reservations visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservations")]
        public virtual System.Collections.Generic.IList<Reservation> Reservations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response for ReservationService.ListSlotPools.</summary>
    public class ListSlotPoolsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of slot pools visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotPools")]
        public virtual System.Collections.Generic.IList<SlotPool> SlotPools { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>Service-specific metadata associated with the operation. It typically contains progress information
        /// and common metadata such as create time. Some services might not provide such metadata. Any method that
        /// returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// If you use the default HTTP mapping, the `name` should be a resource name ending with
        /// `operations/{unique_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The normal response of the operation in case of success. If the original method returns no data on
        /// success, such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A reservation is a mechanism used to guarantee slots to users.</summary>
    public class Reservation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the reservation, e.g., "projects/locations/reservations/dev/team/product".
        /// Reservation names (e.g., "dev/team/product") exceeding a depth of six will fail with
        /// `google.rpc.Code.INVALID_ARGUMENT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Maximum slots available to this reservation and its children. A slot is a unit of computational
        /// power in BigQuery, and serves as the unit of parallelism. In a scan of a multi-partitioned table, a single
        /// slot operates on a single partition of the table. If the new reservation's slot capacity exceed the parent's
        /// slot capacity or if total slot capacity of the new reservation and its siblings exceeds the parent's slot
        /// capacity, the request will fail with `google.rpc.Code.RESOURCE_EXHAUSTED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotCapacity")]
        public virtual System.Nullable<long> SlotCapacity { get; set; }

        /// <summary>If true, any query using this reservation will also be submitted to the parent reservation. This
        /// allows the query to share the additional slot capacity of the parent with other queries in the parent
        /// reservation. If the parent also has this field set to true, then this process will continue until it
        /// encounters a reservation for which this is false. If false, a query using this reservation will execute with
        /// the maximum slot capacity as specified above. If not specified, default value is true. Ignored for top-level
        /// reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useParentReservation")]
        public virtual System.Nullable<bool> UseParentReservation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A ReservationGrant allows a project to submit jobs of a certain type using slots from the specified
    /// reservation.</summary>
    public class ReservationGrant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource which will use the reservation. E.g. projects/myproject, folders/123,
        /// organizations/456.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantee")]
        public virtual string Grantee { get; set; }

        /// <summary>Which type of jobs will use the reservation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobType")]
        public virtual string JobType { get; set; }

        /// <summary>Output only. Name of the resource. E.g.:
        /// projects/myproject/locations/eu/reservationGrants/123.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Resource name of the reservation. E.g.,
        /// projects/myproject/locations/eu/reservations/my_reservation. This reservation must be in the same location
        /// as the grant. This reservation should belong to the same parent project.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservation")]
        public virtual string Reservation { get; set; }

        /// <summary>Output only. State of the ReservationGrant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response for ReservationService.SearchReservationGrants.</summary>
    public class SearchReservationGrantsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of reservation grants visible to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservationGrants")]
        public virtual System.Collections.Generic.IList<ReservationGrant> ReservationGrants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Slot pool is a way to purchase slots with some minimum committed period of usage. Slot pool is
    /// immutable and cannot be deleted until the end of the commitment period. After the end of the commitment period,
    /// slots are still available but can be freely removed any time. Annual commitments will automatically be
    /// downgraded to monthly after the commitment ends. A slot pool resource exists as a child resource of a top-level
    /// reservation. Sum of all the ACTIVE pools slot_count is always equal to the reservation slot_capacity.</summary>
    public class SlotPool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The end of the commitment period. Slot pool cannot be removed before
        /// commitment_end_time. It is applicable only for ACTIVE slot pools and is computed as a combination of the
        /// plan and the time when the slot pool became ACTIVE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commitmentEndTime")]
        public virtual object CommitmentEndTime { get; set; }

        /// <summary>Output only. For FAILED slot pool, provides the reason of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failureStatus")]
        public virtual Status FailureStatus { get; set; }

        /// <summary>Output only. The resource name of the slot pool, e.g., projects/myproject/locations/us-
        /// central1/reservations/myreservation/slotPools/123</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Slot pool commitment plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plan")]
        public virtual string Plan { get; set; }

        /// <summary>Number of slots in this pool.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slotCount")]
        public virtual System.Nullable<long> SlotCount { get; set; }

        /// <summary>Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
