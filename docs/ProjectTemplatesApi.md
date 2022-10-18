# asana.Api.ProjectTemplatesApi

All URIs are relative to *https://app.asana.com/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetProjectTemplate**](ProjectTemplatesApi.md#getprojecttemplate) | **GET** /project_templates/{project_template_gid} | Get a project template
[**GetProjectTemplates**](ProjectTemplatesApi.md#getprojecttemplates) | **GET** /project_templates | Get multiple project templates
[**GetProjectTemplatesForTeam**](ProjectTemplatesApi.md#getprojecttemplatesforteam) | **GET** /teams/{team_gid}/project_templates | Get a team&#39;s project templates
[**InstantiateProject**](ProjectTemplatesApi.md#instantiateproject) | **POST** /project_templates/{project_template_gid}/instantiateProject | Instantiate a project from a project template



## GetProjectTemplate

> GetProjectTemplate200Response GetProjectTemplate (string projectTemplateGid, bool? optPretty = null, List<string> optFields = null)

Get a project template

Returns the complete project template record for a single project template.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetProjectTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectTemplatesApi(Configuration.Default);
            var projectTemplateGid = 1331;  // string | Globally unique identifier for the project template.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Get a project template
                GetProjectTemplate200Response result = apiInstance.GetProjectTemplate(projectTemplateGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProjectTemplatesApi.GetProjectTemplate: " + e.Message );
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
 **projectTemplateGid** | **string**| Globally unique identifier for the project template. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**GetProjectTemplate200Response**](GetProjectTemplate200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested project template. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProjectTemplates

> GetProjectTemplates200Response GetProjectTemplates (bool? optPretty = null, List<string> optFields = null, string workspace = null, string team = null, int? limit = null, string offset = null)

Get multiple project templates

Returns the compact project template records for all project templates in the given team or workspace.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetProjectTemplatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectTemplatesApi(Configuration.Default);
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var workspace = 12345;  // string | The workspace to filter results on. (optional) 
            var team = 14916;  // string | The team to filter projects on. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get multiple project templates
                GetProjectTemplates200Response result = apiInstance.GetProjectTemplates(optPretty, optFields, workspace, team, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProjectTemplatesApi.GetProjectTemplates: " + e.Message );
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
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **workspace** | **string**| The workspace to filter results on. | [optional] 
 **team** | **string**| The team to filter projects on. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetProjectTemplates200Response**](GetProjectTemplates200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested team&#39;s or workspace&#39;s project templates. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProjectTemplatesForTeam

> GetProjectTemplates200Response GetProjectTemplatesForTeam (string teamGid, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get a team's project templates

Returns the compact project template records for all project templates in the team.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetProjectTemplatesForTeamExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectTemplatesApi(Configuration.Default);
            var teamGid = 159874;  // string | Globally unique identifier for the team.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get a team's project templates
                GetProjectTemplates200Response result = apiInstance.GetProjectTemplatesForTeam(teamGid, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProjectTemplatesApi.GetProjectTemplatesForTeam: " + e.Message );
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

[**GetProjectTemplates200Response**](GetProjectTemplates200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested team&#39;s project templates. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## InstantiateProject

> GetJob200Response InstantiateProject (string projectTemplateGid, bool? optPretty = null, List<string> optFields = null, InstantiateProjectRequest instantiateProjectRequest = null)

Instantiate a project from a project template

Creates and returns a job that will asynchronously handle the project instantiation.  To form this request, it is recommended to first make a request to [get a project template](/docs/get-a-project-template). Then, from the response, copy the `gid` from the object in the `requested_dates` array. This `gid` should be used in `requested_dates` to instantiate a project.  _Note: The body of this request will differ if your workspace is an organization. To determine if your workspace is an organization, use the [is_organization](/docs/workspace) parameter._

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class InstantiateProjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProjectTemplatesApi(Configuration.Default);
            var projectTemplateGid = 1331;  // string | Globally unique identifier for the project template.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var instantiateProjectRequest = new InstantiateProjectRequest(); // InstantiateProjectRequest | Describes the inputs used for instantiating a project, such as the resulting project's name, which team it should be created in, and values for date variables. (optional) 

            try
            {
                // Instantiate a project from a project template
                GetJob200Response result = apiInstance.InstantiateProject(projectTemplateGid, optPretty, optFields, instantiateProjectRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProjectTemplatesApi.InstantiateProject: " + e.Message );
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
 **projectTemplateGid** | **string**| Globally unique identifier for the project template. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **instantiateProjectRequest** | [**InstantiateProjectRequest**](InstantiateProjectRequest.md)| Describes the inputs used for instantiating a project, such as the resulting project&#39;s name, which team it should be created in, and values for date variables. | [optional] 

### Return type

[**GetJob200Response**](GetJob200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created the job to handle project instantiation. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

