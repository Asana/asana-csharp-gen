# asana.Api.StoriesApi

All URIs are relative to *https://app.asana.com/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStoryForTask**](StoriesApi.md#createstoryfortask) | **POST** /tasks/{task_gid}/stories | Create a story on a task
[**DeleteStory**](StoriesApi.md#deletestory) | **DELETE** /stories/{story_gid} | Delete a story
[**GetStoriesForTask**](StoriesApi.md#getstoriesfortask) | **GET** /tasks/{task_gid}/stories | Get stories from a task
[**GetStory**](StoriesApi.md#getstory) | **GET** /stories/{story_gid} | Get a story
[**UpdateStory**](StoriesApi.md#updatestory) | **PUT** /stories/{story_gid} | Update a story



## CreateStoryForTask

> GetStory200Response CreateStoryForTask (string taskGid, UpdateStoryRequest updateStoryRequest, bool? optPretty = null, List<string> optFields = null)

Create a story on a task

Adds a story to a task. This endpoint currently only allows for comment stories to be created. The comment will be authored by the currently authenticated user, and timestamped when the server receives the request.  Returns the full record for the new story added to the task.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class CreateStoryForTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoriesApi(Configuration.Default);
            var taskGid = 321654;  // string | The task to operate on.
            var updateStoryRequest = new UpdateStoryRequest(); // UpdateStoryRequest | The story to create.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Create a story on a task
                GetStory200Response result = apiInstance.CreateStoryForTask(taskGid, updateStoryRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoriesApi.CreateStoryForTask: " + e.Message );
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
 **taskGid** | **string**| The task to operate on. | 
 **updateStoryRequest** | [**UpdateStoryRequest**](UpdateStoryRequest.md)| The story to create. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**GetStory200Response**](GetStory200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created a new story. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteStory

> DeleteAttachment200Response DeleteStory (string storyGid, bool? optPretty = null, List<string> optFields = null)

Delete a story

Deletes a story. A user can only delete stories they have created.  Returns an empty data record.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class DeleteStoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoriesApi(Configuration.Default);
            var storyGid = 35678;  // string | Globally unique identifier for the story.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Delete a story
                DeleteAttachment200Response result = apiInstance.DeleteStory(storyGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoriesApi.DeleteStory: " + e.Message );
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
 **storyGid** | **string**| Globally unique identifier for the story. | 
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
| **200** | Successfully deleted the specified story. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStoriesForTask

> GetStoriesForTask200Response GetStoriesForTask (string taskGid, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get stories from a task

Returns the compact records for all stories on the task.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetStoriesForTaskExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoriesApi(Configuration.Default);
            var taskGid = 321654;  // string | The task to operate on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get stories from a task
                GetStoriesForTask200Response result = apiInstance.GetStoriesForTask(taskGid, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoriesApi.GetStoriesForTask: " + e.Message );
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
 **taskGid** | **string**| The task to operate on. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetStoriesForTask200Response**](GetStoriesForTask200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified task&#39;s stories. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetStory

> GetStory200Response GetStory (string storyGid, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get a story

Returns the full record for a single story.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetStoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoriesApi(Configuration.Default);
            var storyGid = 35678;  // string | Globally unique identifier for the story.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get a story
                GetStory200Response result = apiInstance.GetStory(storyGid, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoriesApi.GetStory: " + e.Message );
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
 **storyGid** | **string**| Globally unique identifier for the story. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetStory200Response**](GetStory200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified story. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateStory

> GetStory200Response UpdateStory (string storyGid, UpdateStoryRequest updateStoryRequest, bool? optPretty = null, List<string> optFields = null)

Update a story

Updates the story and returns the full record for the updated story. Only comment stories can have their text updated, and only comment stories and attachment stories can be pinned. Only one of `text` and `html_text` can be specified.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class UpdateStoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StoriesApi(Configuration.Default);
            var storyGid = 35678;  // string | Globally unique identifier for the story.
            var updateStoryRequest = new UpdateStoryRequest(); // UpdateStoryRequest | The comment story to update.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Update a story
                GetStory200Response result = apiInstance.UpdateStory(storyGid, updateStoryRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StoriesApi.UpdateStory: " + e.Message );
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
 **storyGid** | **string**| Globally unique identifier for the story. | 
 **updateStoryRequest** | [**UpdateStoryRequest**](UpdateStoryRequest.md)| The comment story to update. | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**GetStory200Response**](GetStory200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified story. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

