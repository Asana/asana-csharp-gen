# asana.Api.PortfolioMembershipsApi

All URIs are relative to *https://app.asana.com/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPortfolioMembership**](PortfolioMembershipsApi.md#getportfoliomembership) | **GET** /portfolio_memberships/{portfolio_membership_gid} | Get a portfolio membership
[**GetPortfolioMemberships**](PortfolioMembershipsApi.md#getportfoliomemberships) | **GET** /portfolio_memberships | Get multiple portfolio memberships
[**GetPortfolioMembershipsForPortfolio**](PortfolioMembershipsApi.md#getportfoliomembershipsforportfolio) | **GET** /portfolios/{portfolio_gid}/portfolio_memberships | Get memberships from a portfolio



## GetPortfolioMembership

> GetPortfolioMembership200Response GetPortfolioMembership (string portfolioMembershipGid, bool? optPretty = null, List<string> optFields = null)

Get a portfolio membership

Returns the complete portfolio record for a single portfolio membership.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetPortfolioMembershipExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioMembershipsApi(Configuration.Default);
            var portfolioMembershipGid = 1331;  // string | 
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 

            try
            {
                // Get a portfolio membership
                GetPortfolioMembership200Response result = apiInstance.GetPortfolioMembership(portfolioMembershipGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioMembershipsApi.GetPortfolioMembership: " + e.Message );
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
 **portfolioMembershipGid** | **string**|  | 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 

### Return type

[**GetPortfolioMembership200Response**](GetPortfolioMembership200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested portfolio membership. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioMemberships

> GetPortfolioMemberships200Response GetPortfolioMemberships (string portfolio = null, string workspace = null, string user = null, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get multiple portfolio memberships

Returns a list of portfolio memberships in compact representation. You must specify `portfolio`, `portfolio` and `user`, or `workspace` and `user`.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetPortfolioMembershipsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioMembershipsApi(Configuration.Default);
            var portfolio = 12345;  // string | The portfolio to filter results on. (optional) 
            var workspace = 12345;  // string | The workspace to filter results on. (optional) 
            var user = me;  // string | A string identifying a user. This can either be the string \"me\", an email, or the gid of a user. (optional) 
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get multiple portfolio memberships
                GetPortfolioMemberships200Response result = apiInstance.GetPortfolioMemberships(portfolio, workspace, user, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioMembershipsApi.GetPortfolioMemberships: " + e.Message );
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
 **portfolio** | **string**| The portfolio to filter results on. | [optional] 
 **workspace** | **string**| The workspace to filter results on. | [optional] 
 **user** | **string**| A string identifying a user. This can either be the string \&quot;me\&quot;, an email, or the gid of a user. | [optional] 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetPortfolioMemberships200Response**](GetPortfolioMemberships200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved portfolio memberships. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioMembershipsForPortfolio

> GetPortfolioMemberships200Response GetPortfolioMembershipsForPortfolio (string portfolioGid, string user = null, bool? optPretty = null, List<string> optFields = null, int? limit = null, string offset = null)

Get memberships from a portfolio

Returns the compact portfolio membership records for the portfolio.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using asana.Api;
using asana.Client;
using asana.Model;

namespace Example
{
    public class GetPortfolioMembershipsForPortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://app.asana.com/api/1.0";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure HTTP bearer authorization: personalAccessToken
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfolioMembershipsApi(Configuration.Default);
            var portfolioGid = 12345;  // string | Globally unique identifier for the portfolio.
            var user = me;  // string | A string identifying a user. This can either be the string \"me\", an email, or the gid of a user. (optional) 
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>(); // List<string> | Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 

            try
            {
                // Get memberships from a portfolio
                GetPortfolioMemberships200Response result = apiInstance.GetPortfolioMembershipsForPortfolio(portfolioGid, user, optPretty, optFields, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfolioMembershipsApi.GetPortfolioMembershipsForPortfolio: " + e.Message );
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
 **portfolioGid** | **string**| Globally unique identifier for the portfolio. | 
 **user** | **string**| A string identifying a user. This can either be the string \&quot;me\&quot;, an email, or the gid of a user. | [optional] 
 **optPretty** | **bool?**| Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional] 
 **optFields** | [**List&lt;string&gt;**](string.md)| Defines fields to return. Some requests return *compact* representations of objects in order to conserve resources and complete the request more efficiently. Other times requests return more information than you may need. This option allows you to list the exact set of fields that the API should be sure to return for the objects. The field names should be provided as paths, described below. The id of included objects will always be returned, regardless of the field options. | [optional] 
 **limit** | **int?**| Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional] 
 **offset** | **string**| Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional] 

### Return type

[**GetPortfolioMemberships200Response**](GetPortfolioMemberships200Response.md)

### Authorization

[oauth2](../README.md#oauth2), [personalAccessToken](../README.md#personalAccessToken)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested portfolio&#39;s memberships. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

