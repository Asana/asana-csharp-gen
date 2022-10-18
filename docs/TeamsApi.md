# asana.Api.TeamsApi

All URIs are relative to *https://app.asana.com/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddUserForTeam**](TeamsApi.md#adduserforteam) | **POST** /teams/{team_gid}/addUser | Add a user to a team
[**CreateTeam**](TeamsApi.md#createteam) | **POST** /teams | Create a team
[**GetTeam**](TeamsApi.md#getteam) | **GET** /teams/{team_gid} | Get a team
[**GetTeamsForUser**](TeamsApi.md#getteamsforuser) | **GET** /users/{user_gid}/teams | Get teams for a user
[**GetTeamsForWorkspace**](TeamsApi.md#getteamsforworkspace) | **GET** /workspaces/{workspace_gid}/teams | Get teams in a workspace
[**RemoveUserForTeam**](TeamsApi.md#removeuserforteam) | **POST** /teams/{team_gid}/removeUser | Remove a user from a team
[**UpdateTeam**](TeamsApi.md#updateteam) | **PUT** /teams | Update a team



## AddUserForTeam

> GetTeamMembership200Response AddUserForTeam (string teamGid, AddUserForTeamRequest addUserForTeamRequest, bool? optPretty = null, List<string> optFields = null)

Add a user to a team

The user making this call must be a member of the team in order to add others. The user being added must exist in the same organization as the team.  Returns the complete team membership record for the newly added user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class AddUserForTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var teamGid = 159874;  // string | Globally unique identifier for the team.
            var addUserForTeamRequest = new AddUserForTeamRequest(); // AddUserForTeamRequest | The user to add to the team.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Add a user to a team
                GetTeamMembership200Response result = apiInstance.AddUserForTeam(teamGid, addUserForTeamRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.AddUserForTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamGid** | **string**| Globally unique identifier for the team. | 
 **addUserForTeamRequest** | [**AddUserForTeamRequest**](AddUserForTeamRequest.md)| The user to add to the team. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**GetTeamMembership200Response**](GetTeamMembership200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully added user to the team. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateTeam

> UpdateTeam200Response CreateTeam (UpdateTeamRequest updateTeamRequest, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Create a team

Creates a team within the current workspace.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class CreateTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var updateTeamRequest = new UpdateTeamRequest(); // UpdateTeamRequest | The team to create.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Create a team
                UpdateTeam200Response result = apiInstance.CreateTeam(updateTeamRequest, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.CreateTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateTeamRequest** | [**UpdateTeamRequest**](UpdateTeamRequest.md)| The team to create. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**UpdateTeam200Response**](UpdateTeam200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created a new team. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeam

> UpdateTeam200Response GetTeam (string teamGid, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get a team

Returns the full record for a single team.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var teamGid = 159874;  // string | Globally unique identifier for the team.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get a team
                UpdateTeam200Response result = apiInstance.GetTeam(teamGid, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamGid** | **string**| Globally unique identifier for the team. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**UpdateTeam200Response**](UpdateTeam200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the record for a single team. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsForUser

> GetTeamsForWorkspace200Response GetTeamsForUser (string userGid, string organization, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get teams for a user

Returns the compact records for all teams to which the given user is assigned.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetTeamsForUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var userGid = me;  // string | A string identifying a user. This can either be the string \"me\", an email, or the gid of a user.
            var organization = 1331;  // string | The workspace or organization to filter teams on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get teams for a user
                GetTeamsForWorkspace200Response result = apiInstance.GetTeamsForUser(userGid, organization, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamsForUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGid** | **string**| A string identifying a user. This can either be the string \&quot;me\&quot;, an email, or the gid of a user. | 
 **organization** | **string**| The workspace or organization to filter teams on. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetTeamsForWorkspace200Response**](GetTeamsForWorkspace200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the team records for all teams in the organization or workspace to which the given user is assigned. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTeamsForWorkspace

> GetTeamsForWorkspace200Response GetTeamsForWorkspace (string workspaceGid, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get teams in a workspace

Returns the compact records for all teams in the workspace visible to the authorized user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetTeamsForWorkspaceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var workspaceGid = 12345;  // string | Globally unique identifier for the workspace or organization.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get teams in a workspace
                GetTeamsForWorkspace200Response result = apiInstance.GetTeamsForWorkspace(workspaceGid, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.GetTeamsForWorkspace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **workspaceGid** | **string**| Globally unique identifier for the workspace or organization. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetTeamsForWorkspace200Response**](GetTeamsForWorkspace200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the team records for all teams in the organization or workspace accessible to the authenticated user. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveUserForTeam

> DeleteAttachment200Response RemoveUserForTeam (string teamGid, RemoveUserForTeamRequest removeUserForTeamRequest, bool? optPretty = null, List<string> optFields = null)

Remove a user from a team

The user making this call must be a member of the team in order to remove themselves or others.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class RemoveUserForTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var teamGid = 159874;  // string | Globally unique identifier for the team.
            var removeUserForTeamRequest = new RemoveUserForTeamRequest(); // RemoveUserForTeamRequest | The user to remove from the team.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Remove a user from a team
                DeleteAttachment200Response result = apiInstance.RemoveUserForTeam(teamGid, removeUserForTeamRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.RemoveUserForTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamGid** | **string**| Globally unique identifier for the team. | 
 **removeUserForTeamRequest** | [**RemoveUserForTeamRequest**](RemoveUserForTeamRequest.md)| The user to remove from the team. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Returns an empty data record |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateTeam

> UpdateTeam200Response UpdateTeam (UpdateTeamRequest updateTeamRequest, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Update a team

Updates a team within the current workspace.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class UpdateTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TeamsApi(Configuration.Default);
            var updateTeamRequest = new UpdateTeamRequest(); // UpdateTeamRequest | The team to update.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Update a team
                UpdateTeam200Response result = apiInstance.UpdateTeam(updateTeamRequest, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updateTeamRequest** | [**UpdateTeamRequest**](UpdateTeamRequest.md)| The team to update. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**UpdateTeam200Response**](UpdateTeam200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the team. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

