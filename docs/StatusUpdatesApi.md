# asana.Api.StatusUpdatesApi

All URIs are relative to *https://app.asana.com/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStatusForObject**](StatusUpdatesApi.md#createstatusforobject) | **POST** /status_updates | Create a status update
[**DeleteStatus**](StatusUpdatesApi.md#deletestatus) | **DELETE** /status_updates/{status_gid} | Delete a status update
[**GetStatus**](StatusUpdatesApi.md#getstatus) | **GET** /status_updates/{status_gid} | Get a status update
[**GetStatusesForObject**](StatusUpdatesApi.md#getstatusesforobject) | **GET** /status_updates | Get status updates from an object



## CreateStatusForObject

> GetStatus200Response CreateStatusForObject (CreateStatusForObjectRequest createStatusForObjectRequest, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Create a status update

Creates a new status update on an object. Returns the full record of the newly created status update.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class CreateStatusForObjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatusUpdatesApi(Configuration.Default);
            var createStatusForObjectRequest = new CreateStatusForObjectRequest(); // CreateStatusForObjectRequest | The status update to create.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Create a status update
                GetStatus200Response result = apiInstance.CreateStatusForObject(createStatusForObjectRequest, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatusUpdatesApi.CreateStatusForObject: " + e.Message );
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
 **createStatusForObjectRequest** | [**CreateStatusForObjectRequest**](CreateStatusForObjectRequest.md)| The status update to create. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetStatus200Response**](GetStatus200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created a new status update. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteStatus

> DeleteAttachment200Response DeleteStatus (string statusGid, bool? optPretty = null, List<string> optFields = null)

Delete a status update

Deletes a specific, existing status update.  Returns an empty data record.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class DeleteStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatusUpdatesApi(Configuration.Default);
            var statusGid = 321654;  // string | The status update to get.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Delete a status update
                DeleteAttachment200Response result = apiInstance.DeleteStatus(statusGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatusUpdatesApi.DeleteStatus: " + e.Message );
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
 **statusGid** | **string**| The status update to get. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully deleted the specified status. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStatus

> GetStatus200Response GetStatus (string statusGid, bool? optPretty = null, List<string> optFields = null)

Get a status update

Returns the complete record for a single status update.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatusUpdatesApi(Configuration.Default);
            var statusGid = 321654;  // string | The status update to get.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Get a status update
                GetStatus200Response result = apiInstance.GetStatus(statusGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatusUpdatesApi.GetStatus: " + e.Message );
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
 **statusGid** | **string**| The status update to get. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**GetStatus200Response**](GetStatus200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified object&#39;s status updates. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStatusesForObject

> GetStatusesForObject200Response GetStatusesForObject (string parent, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null, DateTime? createdSince = null)

Get status updates from an object

Returns the compact status update records for all updates on the object.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetStatusesForObjectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StatusUpdatesApi(Configuration.Default);
            var parent = 159874;  // string | Globally unique identifier for object to fetch statuses from. Must be a GID for a project, portfolio, or goal.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var createdSince = 2012-02-22T02:06:58.158Z;  // DateTime? | Only return statuses that have been created since the given time. (optional) 

            try
            {
                // Get status updates from an object
                GetStatusesForObject200Response result = apiInstance.GetStatusesForObject(parent, optPretty, optFields, limit, offset, createdSince);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatusUpdatesApi.GetStatusesForObject: " + e.Message );
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
 **parent** | **string**| Globally unique identifier for object to fetch statuses from. Must be a GID for a project, portfolio, or goal. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 
 **createdSince** | **DateTime?**| Only return statuses that have been created since the given time. | [optional] 

### Return type

[**GetStatusesForObject200Response**](GetStatusesForObject200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified object&#39;s status updates. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

